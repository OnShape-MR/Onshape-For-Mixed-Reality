using IO.Swagger.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.Networking;

public class OnShapeAuthentificator : MonoBehaviour
{
    public TextMesh Text;

    // Start is called before the first frame update
    void Start()
    {

        OnshapeOAuth.Instance.DoAuthentication();



        StartCoroutine(TestStart());
    }

    private IEnumerator TestStart()
    {
        yield return OnshapeOAuth.Instance.GetTokens();

       
        var oauthToken = OnshapeOAuth.Instance.AccessToken;
        var oauthRefreshToken = OnshapeOAuth.Instance.RefreshToken;
        ApiClient.Instance.AccessToken = oauthToken;
        ApiClient.Instance.RefreshToken = oauthRefreshToken;

         yield return TestRequest(oauthToken);
/*

        yield return CallApiTest();
        */
    }


    private IEnumerator TestRequest(string token)
    {
        var uri = "http://cad.onshape.com/api/documents";

        UnityWebRequest www = UnityWebRequest.Get(uri);

        www.SetRequestHeader("Authorization", "Bearer " + token);

        yield return www.SendWebRequest();


        if (www.isNetworkError || www.isHttpError)
        {
            Debug.LogError(www.error);
            yield return null;
        }
        else
        {
            Debug.Log(www.downloadHandler.text);
        }
        try
        {



            TextReader sr = new StringReader(www.downloadHandler.text);


            var reader = new Newtonsoft.Json.JsonTextReader(sr);

            var ser = Newtonsoft.Json.JsonSerializer.Create();
            var docs = ser.Deserialize<IO.Swagger.Model.DocumentsGetDocumentsResponse200>(reader);

            var txt = "";

            foreach (var doc in docs.Items)
            {
                txt += doc.Name + "(Modified by : " + doc.ModifiedBy.Name + " - Created by : " + doc.CreatedBy.Name + ")\r\n";
            }
            Text.text = txt;

            Debug.Log(docs);
        }
        catch (Exception ex)
        {
            Debug.LogError(ex);
        }
    }

    private IEnumerator CallApiTest()
    {
        var req = ApiClient.Instance.Documents.GetDocuments(null, null, null, null, null, null, null, null);

        yield return req.CallApi();

        Debug.Log(req.Response);
    }
}
