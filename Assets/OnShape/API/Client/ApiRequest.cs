using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

namespace IO.Swagger.Client
{
    public class ApiRequest
    {
        public ApiRequest(string path, Method method, Dictionary<string, string> queryParams, string postBody)
        {
            var url = ApiClient.Instance.BasePath + path;

            if (queryParams != null && queryParams.Count > 0)
            {
                url += "?";
                foreach (var param in queryParams)
                {
                    url += param.Key + "=" + param.Value + "&";
                }
            }

            
            url = url.TrimEnd(new char[] { '&' });

            switch (method)
            {
                case Method.POST:
                    www = UnityWebRequest.Post(url, postBody);
                    break;
                case Method.DELETE:
                    www = UnityWebRequest.Delete(url);
                    break;
                default:
                    www = UnityWebRequest.Get(url);
                    break;
            }

            www.SetRequestHeader("Authorization", "Bearer " + ApiClient.Instance.AccessToken);
        }

        public readonly UnityWebRequest www;

        public virtual IEnumerator CallApi()
        {


            yield return www.SendWebRequest();
        }

        public virtual bool OK
        {
            get
            {
                return www != null && www.isDone && !www.isNetworkError;
            }
        }
    }

    public class ApiRequest<T> : ApiRequest
    {
      public T Response;

        private bool _ok = false;
        public override bool OK => base.OK && _ok;

        public override IEnumerator CallApi()
        {
           yield return base.CallApi();

            if (base.OK)
            {
                try
                {
                    Response = (T)ApiClient.Deserialize(www.downloadHandler.text, typeof(T));
                    _ok = true;
                }
                catch(Exception ex)
                {
                    Debug.LogError(www.downloadHandler.text);
                    Debug.LogException(ex);
                }
            }
        }


        public ApiRequest(string path, Method method, Dictionary<string, string> queryParams, string postBody)
            : base(path, method, queryParams, postBody)
        {
        }
    }
}