using IO.Swagger.Client;
using IO.Swagger.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(LocalServer))]
public class ObjectBuilderEditor : Editor
{
    public override void OnInspectorGUI()
    {

        LocalServer myScript = (LocalServer)target;
        if (GUILayout.Button("Get Websocket"))
        {
            myScript.GetWebSocketURL();
        }
        DrawDefaultInspector();
    }
}
public class LocalServer : MonoBehaviour
{

    private TcpListener server;

    // Start is called before the first frame update
    void Start()
    {
        // TcpListener server = new TcpListener(port);
        server = new TcpListener(IPAddress.Any, OnshapeOAuth.SERVER_PORT);

        // Start listening for client requests.
        server.Start();

        server.BeginAcceptTcpClient(OnData, null);
    }

    private void OnData(IAsyncResult ar)
    {
        var client = server.EndAcceptTcpClient(ar);

        var stream = client.GetStream();


        var sr = new StreamReader(stream);
        string inputString;

        var inputLines = new List<string>();


        string code = null;

        do
        {
            inputString = sr.ReadLine();
            inputLines.Add(inputString);

            if (inputString != null && inputString.Contains("code="))
            {
                code=inputString.Split(new string[] { "ode=" }, StringSplitOptions.None)[1].Split(new string[] { " ", "&" }, StringSplitOptions.None)[0];
            }

        } while (!String.IsNullOrEmpty(inputString));

        var content = "<!DOCTYPE html><html><head><meta charset=\"UTF-8\"><title>Hey!</title></head><body onload='history.go(-1);'></body></html>";

        var sw = new StreamWriter(stream);

        sw.Write("HTTP/1.1 200 OK\r\n");
        sw.Write("Content-Type: text/html; charset=UTF-8\r\n");
        sw.Write("Content-Length: " + content.Length + "\r\n");
        sw.Write("\r\n");
        sw.Write(content);

        sw.Flush();


        client.Close();


        if (!string.IsNullOrEmpty(code))
        {
            OnshapeOAuth.Instance.AuthCode = code;
            _flagAfterConnect = true;
        }
        else
        {

            server.BeginAcceptTcpClient(OnData, null);
        }
    }

    private bool _flagAfterConnect = false;

    void Update()
    {
        if (_flagAfterConnect)
        {
            _flagAfterConnect = false;
            StartCoroutine(AfterConnect());

        }
    }


    public IEnumerator AfterConnect()
    {

        yield return OnshapeOAuth.Instance.GetTokens();

        if (ApiClient.Instance.Authenticated)
        {
            var docQuery = ApiClient.Instance.Documents.GetDocuments(null, null, null, null, null, null, null, null);

            yield return docQuery.CallApi();

            foreach(var doc in docQuery.Response.Items)
            {
                Debug.Log(doc.Name);
            }

            var tesselationQuery = ApiClient.Instance.PartStudios.GetFaces("w", "51c9152be6ae840545b1074b", "ca0a6477829de5350cbcb229", "25f1d1375ec9d12653c537e0", null, null, null, null);

            yield return tesselationQuery.CallApi();

            yield return yieldDisplay(tesselationQuery.Response);
        }
        else
        {
            Debug.LogError("Authentication failed");
        }


    }

    public GameObject FaceTemplate;
    public GameObject BodyTemplate;


   public void GetWebSocketURL()
    {

        StartCoroutine(yieldGetWebSocketURL());

    }

    private IEnumerator yieldGetWebSocketURL()
    {

        var queryParams = new Dictionary<String, String>();

        var request = new ApiRequest<string>("/documents/637e96dc894ed4cf0d272fe8:062c89e758d0e2ba03b556b3/modelingServiceRequest", Method.GET, queryParams, null);
        //  var request = new ApiRequest<string>("/documents", Method.GET, queryParams, null);
        //https://cad.onshape.com/api/documents/637e96dc894ed4cf0d272fe8:062c89e758d0e2ba03b556b3/modelingServiceRequest
        //Location : wss://cad-euw1.onshape.com/btwssm/637e96dc894ed4cf0d272fe8/062c89e758d0e2ba03b556b3?_m=027d5fb0&locale=en-US&version=1.1.18"

        //request.www.SetRequestHeader("Pragma", "no-cache");
        //request.www.SetRequestHeader("Sec-Fetch-Site", "same-origin");
        //request.www.SetRequestHeader("DNT", "1");
        request.www.SetRequestHeader("X-XSRF-TOKEN", ApiClient.Instance.AccessToken);
        //request.www.SetRequestHeader("Accept-Encoding", "gzip, deflate, br");
        request.www.SetRequestHeader("Accept-Language", "en-US");
       // request.www.SetRequestHeader("Sec-Fetch-Mode", "no-cache");
       // request.www.SetRequestHeader("Accept", "cors");
       // request.www.SetRequestHeader("Pragma", "application/json, text/plain, */*");
       // request.www.SetRequestHeader("Cache-Control", "no-cache");
       // request.www.SetRequestHeader("Referer", "https://cad.onshape.com/documents/637e96dc894ed4cf0d272fe8/w/062c89e758d0e2ba03b556b3/e/f2a56f809704aee78079fb51");
       // request.www.SetRequestHeader("Connection", "keep-alive");

        yield return request.CallApi();

        var rep = request.Response;
    }

    private IEnumerator yieldDisplay(PartStudiosGetTesseletedFaceResponse200 faces)
    {
        foreach (var onshapeBody in faces.bodies)
        {
            var body = Instantiate(BodyTemplate, this.transform);
            body.name = onshapeBody.id;
            //body.tag = onshapeBody.bodyType;

            var mesh = new Mesh();

            mesh.name = onshapeBody.id;

            var allVertices = new Vector3[faces.facetPoints.Length];

            // tableau d'association des normals au tableau local des normales. correspondanceNormals[i,0] : indice t du triangle où il est utilisé
            var correspondanceNormals = new int[faces.facetPoints.Length, 2];

            // _uv = new Vector2[faces.facetPoints.Length];
            for (int i = 0; i < faces.facetPoints.Length; i++)
            {
                // _vertices[i] = new Vector3(faces.facetPoints[i][0], faces.facetPoints[i][1], faces.facetPoints[i][2]);
                allVertices[i].x = faces.facetPoints[i][0];
                allVertices[i].y = faces.facetPoints[i][1];
                allVertices[i].z = faces.facetPoints[i][2];
                correspondanceNormals[i, 0] = -1;
                correspondanceNormals[i, 1] = -1;
            }


            for (int f = 0; f < onshapeBody.faces.Length; f++)
            {
                var onshapeFace = onshapeBody.faces[f];
                var face = Instantiate(FaceTemplate, body.transform);
                var m = new Mesh();
                m.name = onshapeFace.id;
                face.name = onshapeFace.id;
                face.GetComponent<MeshFilter>().mesh = m;
                face.GetComponent<MeshCollider>().sharedMesh = m;

                var nbFacets = onshapeFace.facets.Length;

                var nbTriangles = 3 * nbFacets;

                // var normals = new Vector3[nbTriangles * 3];
                var triangles = new int[nbTriangles];

                var normals = new List<Vector3>(nbTriangles);
                var vertices = new List<Vector3>(nbTriangles);

                for (int t = 0; t < nbFacets; t++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        var indiceInAllVertices = onshapeFace.facets[t].indices[n];

                        int indiceInVertices;

                        if (correspondanceNormals[indiceInAllVertices, 0] != f)
                        {
                            correspondanceNormals[indiceInAllVertices, 0] = f;
                            indiceInVertices = vertices.Count;
                            correspondanceNormals[indiceInAllVertices, 1] = indiceInVertices;
                            vertices.Add(allVertices[indiceInAllVertices]);

                            var vertexNormal = onshapeFace.facets[t].vertexNormals[n];
                            normals.Add(new Vector3(vertexNormal[0], vertexNormal[1], vertexNormal[2]));
                        }
                        else
                        {
                            indiceInVertices = correspondanceNormals[indiceInAllVertices, 1];
                        }

                        triangles[3 * t + n] = indiceInVertices;
                    }

                }
                m.vertices = vertices.ToArray();

                m.triangles = triangles;
                m.normals = normals.ToArray();
                // m.uv = _uv;

                yield return null;
            }
        }
    }
           

}
