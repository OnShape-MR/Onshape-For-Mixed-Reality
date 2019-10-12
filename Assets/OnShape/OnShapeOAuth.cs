using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Net;
using System.Web;
using System.IO;
using System.Diagnostics;
using System.Threading;
using UnityEngine.Networking;
using IO.Swagger.Client;

public class JSONTokenResponse
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string refresh_token { get; set; }
        public int expires_in { get; set; }
        public string scope { get; set; }
    }

    public class OnshapeOAuth
    {
        #region OAuth Constants

        public const string AUTH_URI_TEMPLATE = @"{0}/oauth/authorize?response_type=code&client_id={1}&grant_type=authorization_code&redirect_uri={2}";
        public const string AUTH_FORM_TEMPLATE = "code={0}&client_id={1}&client_secret={2}&grant_type=authorization_code&redirect_uri={3}";
        public const string TOKEN_URI_TEMPLATE = @"{0}/oauth/token";
        public const string BROWSER_URI = @"urn:ietf:wg:oauth:2.0:oob";
        public const int SERVER_PORT = 1212;

    public string ServerURI => @"https://Rufus31415.github.io/"; // @"http://localhost:" + SERVER_PORT; 

        #endregion

        #region Variables

        public const string CLIENT_SECRET= "ROXJAA7UKWB5R7EU5LLQI2YH4DDRJWQY64N46PCOGSBTOG6XDNXQ====";
        public const String CLIENT_ID= "4OMIXKUICROTVQSOOGSBGM2YLE5KVHI2ADZ3IHY=";
        public const String BASE_URI= "https://oauth.onshape.com";

        public static readonly OnshapeOAuth Instance = new OnshapeOAuth();

        #endregion

        #region Properties
        /*
        private string AuthPath { get { return String.Format(AUTH_URI_TEMPLATE, baseUri, HttpUtility.UrlEncode(clientId), HttpUtility.UrlEncode(SERVER_URI)); } }

        private string FormAuthReq { get { return String.Format(AUTH_FORM_TEMPLATE, HttpUtility.UrlEncode(AuthCode), HttpUtility.UrlEncode(clientId), HttpUtility.UrlEncode(clientSecret), HttpUtility.UrlEncode(SERVER_URI)); } }
        */
        public string AuthPath { get { return String.Format(AUTH_URI_TEMPLATE, BASE_URI, CLIENT_ID, ServerURI); } }

        public string FormAuthReq { get { return String.Format(AUTH_FORM_TEMPLATE, AuthCode, CLIENT_ID, CLIENT_SECRET, ServerURI); } }

    public string AuthCode;

        public string AccessToken;

        public string RefreshToken;
        #endregion



        #region Constructors

        public OnshapeOAuth()
        {
            AuthCode = "";
            AccessToken = "";
            RefreshToken = "";
        }

        #endregion

        #region Private Methods

        public void DoAuthentication()
        {
#if UNITY_EDITOR
            Process pWeb = new Process();
            pWeb.StartInfo.FileName = AuthPath;
            pWeb.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            pWeb.Start();
            AddLogEntry("Browser opened...");
            Listen();
            pWeb.Close();
#endif  
        }

#if UNITY_EDITOR
        //Listener for callback
        private void Listen()
        {
            try
            {
                AddLogEntry("Starting listener...");
                HttpListener hlListener = new HttpListener();
                hlListener.Prefixes.Add(ServerURI + "/");
                hlListener.Start();

                AddLogEntry("Listener started...");
                HttpListenerContext hlcContext = hlListener.GetContext();

                AddLogEntry("Listener received request...sending response...");
                HttpListenerRequest hlrqRequest = hlcContext.Request;
                HttpListenerResponse hlrpResponse = hlcContext.Response;
                string strResponse = "<HTML><HEAD><TITLE>Authentication Successful</TITLE></HEAD><BODY>Please close the window.</BODY></HTML>";//This is what people will see after authenticating
                byte[] bBuffer = System.Text.Encoding.UTF8.GetBytes(strResponse);
                // Get a response stream and write the response to it.
                hlrpResponse.ContentLength64 = bBuffer.Length;
                System.IO.Stream smOutput = hlrpResponse.OutputStream;
                smOutput.Write(bBuffer, 0, bBuffer.Length);

                AddLogEntry("Response sent...");
                // You must close the output stream.
                smOutput.Close();
                hlListener.Stop();
                AddLogEntry("Listener closed...");

                AuthCode = hlrqRequest.QueryString["code"];

                AddLogEntry("Authentication code: " + AuthCode);
            }
            catch (Exception e)
            {
                AddLogEntry("Error occured in Listen: " + e.ToString());
            }

        }
#endif

        //After getting callback request token
        public IEnumerator GetTokens()
        {
            string strResponse;

            var frm = new UnityEngine.WWWForm();

            frm.AddField("code", AuthCode);
            frm.AddField("client_id", CLIENT_ID);
            frm.AddField("client_secret", CLIENT_SECRET);
            frm.AddField("grant_type", "authorization_code");
            frm.AddField("redirect_uri", ServerURI);

        // frm.headers.Add("Content-Type", "application/x-www-form-urlencoded");

        using (UnityWebRequest www = UnityWebRequest.Post(String.Format(TOKEN_URI_TEMPLATE, BASE_URI), frm))
        {

            www.SetRequestHeader("Content-Type", "application/x-www-form-urlencoded");

            yield return www.SendWebRequest();

            strResponse = www.downloadHandler.text;
        }

            /*
            AddLogEntry("Sending request for tokens...");

            WebRequest wrRequest = WebRequest.Create(String.Format(TOKEN_URI_TEMPLATE, BASE_URI));
            wrRequest.Method = "POST";
            wrRequest.ContentType = "application/x-www-form-urlencoded";

            StreamWriter swPost = new StreamWriter(wrRequest.GetRequestStream());
            swPost.Write(FormAuthReq);
            swPost.Flush();
            swPost.Close();

            AddLogEntry("Request sent...waiting for response...");

            WebResponse wrResponse = wrRequest.GetResponse();

            AddLogEntry("Processing response...");
            StreamReader srResponse = new StreamReader(wrResponse.GetResponseStream());
            strResponse = srResponse.ReadToEnd();
            srResponse.Close();
            */


            using (TextReader sr = new StringReader(strResponse))
                {
                    using (var reader = new Newtonsoft.Json.JsonTextReader(sr))
                    {
                        var ser = Newtonsoft.Json.JsonSerializer.Create();

                        var jtrResponse = ser.Deserialize<JSONTokenResponse>(reader);

                        AccessToken = jtrResponse.access_token;
                        RefreshToken = jtrResponse.refresh_token;
                    }
                }

        ApiClient.Instance.AccessToken = AccessToken;
        ApiClient.Instance.RefreshToken = RefreshToken;

    }


    private void AddLogEntry(string strEntry)
        {
        Debug.WriteLine(strEntry);
        }

        #endregion
    }
