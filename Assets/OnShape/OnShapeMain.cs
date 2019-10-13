using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

/*
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
*/

#endif


public class OnShapeMain : MonoBehaviour
{
    public MenuDocument MenuDocument;

    public Workspace Workspace;

    public ProgressBar ProgressBar;

    // Start is called before the first frame update
    void Start()
    {
        ShowProgress("Waiting for user to authenticate...");
    }

    public void AfterConnect()
    {
        StartCoroutine(LoadAndDisplayDocuments());

    }

    private bool _firstload = true;

    public IEnumerator LoadAndDisplayDocuments()
    {
        Workspace.StopPolling();

        ShowProgress("Retrieving documents...");

        if (_firstload)
        {
            yield return OnshapeOAuth.Instance.GetTokens();
            _firstload = false;
        }

        if (string.IsNullOrEmpty(ApiClient.Instance.AccessToken))
        {
            LogError("Unable to retrieve Access tocken");
            yield break;
        }
               
        var docRequest = ApiClient.Instance.Documents.GetDocuments(null, null, null, null, "modifiedAt", "desc", null, 8);

        yield return docRequest.CallApi();

        if(!docRequest.OK)
        {
            LogError("Unable to retrieve document list");
            yield break;
        }

        foreach (var doc in docRequest.Response.Items)
        {
            if (doc.Thumbnail.Sizes.Count == 0) continue;

            var url = doc.Thumbnail.Sizes[0].Href;

            var imgReq = new ImageRequest(url, Method.GET, new Dictionary<string, string>(), null, true);

            yield return imgReq.CallApi();

            if (imgReq.Image == null)
            {
                LogError("Unable to get image : " + url);
            }
            else
            {
                doc.Thumbnail.Image = imgReq.Image;
            }

        }

        HideProgress();

        MenuDocument.RefreshDocumentList(docRequest.Response);

    }


    public void LogError(string text)
    {
        HideProgress();
        Debug.LogError(text);
    }



    public void OpenDocument(DocumentsGetDocumentsResponse200Items doc)
    {
   
        StartCoroutine(AsyncOpenDocument(doc));
        
    }

    private string _currentWorkspace;
    private string _currentDocument;
    private DocumentsGetElementListResponse200Elements _currentElement;

    private IEnumerator AsyncOpenDocument(DocumentsGetDocumentsResponse200Items doc)
    {
        ShowProgress("Loading workspace...");

        _currentWorkspace = doc.DefaultWorkspace.Id;
        _currentDocument = doc.Id;
        _currentElement = null;

        var request = ApiClient.Instance.Documents.GetElementList("w", doc.Id, _currentWorkspace, "PARTSTUDIO", null, true);

        yield return request.CallApi();

        if (!request.OK)
        {
            LogError("Unable to retrieve document tab list");
            yield break;
        }

        
        foreach(var reponse in request.Response)
        {
            var imgReq = new ImageRequest(reponse.ThumbnailInfo.Sizes[0].Href, Method.GET, new Dictionary<string, string>(), null, true);

            yield return imgReq.CallApi();

            if (imgReq.Image == null)
            {
                LogError("Unable to get image : " + reponse.ThumbnailInfo.Href);
            }
            else
            {
                reponse.ThumbnailInfo.Image = imgReq.Image;
            }

        }
        
        var selectedTab = request.Response?[0];

        MenuDocument.RefreshTabList(request.Response, selectedTab);

        OpenTab(selectedTab);

        Workspace.gameObject.transform.position = MenuDocument.gameObject.transform.position + new Vector3(0, -0.5f, -0.5f);
    }



    public void OpenTab(DocumentsGetElementListResponse200Elements element)
    {
        _currentElement = element;

        Workspace.Show(_currentDocument, _currentWorkspace, element);

    }


    public void ShowProgress(string message)
    {
        MenuDocument.gameObject.SetActive(false);
        ProgressBar.Show(message);
    }

    public void HideProgress()
    {
        MenuDocument.gameObject.SetActive(true);
        ProgressBar.Hide();
    }

}
