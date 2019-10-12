using IO.Swagger.Client;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

[CustomEditor(typeof(OnShapeMain))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        if (GUILayout.Button("LoadAndDisplayDocuments"))
        {
            ((OnShapeMain)target).LoadAndDisplayDocuments();
        }
    }
}


#endif


public class OnShapeMain : MonoBehaviour
{
    public GameObject StartPanel;

    public MenuDocument MenuDocument;



    // Start is called before the first frame update
    void Start()
    {
        StartPanel.SetActive(true);
        MenuDocument.gameObject.SetActive(false);
    }

    public void AfterConnect()
    {
        StartCoroutine(LoadAndDisplayDocuments());

    }

    public IEnumerator LoadAndDisplayDocuments()
    {
        yield return OnshapeOAuth.Instance.GetTokens();

        if (string.IsNullOrEmpty(ApiClient.Instance.AccessToken))
        {
            LogError("Unable to retrieve Access tocken");
            yield break;
        }
               
        var docRequest = ApiClient.Instance.Documents.GetDocuments(null, null, null, null, null, null, null, null);

        yield return docRequest.CallApi();

        if(!docRequest.OK)
        {
            LogError("Unable to retrieve document list");
            yield break;
        }

        foreach(var doc in docRequest.Response.Items)
        {
            if (doc.Thumbnail.Sizes.Count == 0) continue;

            var url = doc.Thumbnail.Sizes[0].Href;

            var imgReq = new ApiRequest<byte[]>(url, Method.GET, new Dictionary<string, string>(), null, true);

            yield return imgReq.CallApi();

            if (imgReq.Response!= null && imgReq.OK)
            {
                var Tex2D = new Texture2D(2, 2);
                if (Tex2D.LoadImage(imgReq.Response))
                {

                }
                var spr = Sprite.Create(Tex2D, new Rect(0,0,Tex2D.width, Tex2D.height),new Vector2(0, 0));

                doc.Thumbnail.Image = spr;
            }
            else
            {
                LogError("Unable to get image : " + url);
            }


        }

        MenuDocument.RefreshDocumentList(docRequest.Response);

    }

    public void LogError(string text)
    {

    }



    public void OpenDocument(string id)
    {



    }

    public void OpenTab(string id)
    {

    }

}
