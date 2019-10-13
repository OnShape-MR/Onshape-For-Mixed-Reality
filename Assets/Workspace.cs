using IO.Swagger.Client;
using IO.Swagger.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;



public class Workspace : MonoBehaviour
{
    public OnShapeMain Main;

    public Material TemplateMaterial;

    public void Show(string did, string wid, DocumentsGetElementListResponse200Elements element)
    {
        StopPolling();

        Main.ShowProgress("Loading studio data...");

        foreach (Transform child in gameObject.transform) { Destroy(child.gameObject); }

        ResetScale();

        if (string.IsNullOrEmpty(did) || string.IsNullOrEmpty(wid) || element == null)
        {
            Main.HideProgress();
            return;
        }

        if(element.ElementType != "PARTSTUDIO")
        {
            LogError("Only part studios are supported");
            return;
        }


        StartCoroutine(Show(did, wid, element.Id));
    }

    private void LogError(string message)
    {
        Main.LogError(message);
        Main.HideProgress();
    }

    private IEnumerator Show(string did, string wid, string eid)
    {

        var request = ApiClient.Instance.PartStudios.GetFaces("w", did, wid, eid, null, null, null, null);

        yield return request.CallApi();

        if (!request.OK)
        {
            LogError("Unable to load part faces");
            yield break;
        }

        yield return new WaitWhile(() => _pollingInProgress);

        yield return InternalDisplay(request.Response, did, wid, eid, true);


        yield return PollModifications(did, wid, eid);
                
    }

    private bool _continuePolling;
    private bool _pollingInProgress;
    public void StopPolling()
    {
        _continuePolling = false;
    }

    private IEnumerator PollModifications(string did, string wid, string eid)
    {
        _continuePolling = true;
        _pollingInProgress = true;

        var poll = ApiClient.Instance.PartStudios.GetConfiguration("w", did, wid, eid);

        yield return poll.CallApi();


        if (!poll.OK)
        {
            LogError("Unable to check live modifications");
            yield break;
        }

        var _lastMicroversion = poll.Response.SourceMicroversion;

        do
        {
            yield return new WaitForSeconds(1);

            if (!_continuePolling)
            {
                _pollingInProgress = false;
                yield break;
            }

            poll = ApiClient.Instance.PartStudios.GetConfiguration("w", did, wid, eid);

            yield return poll.CallApi();

            if (!_continuePolling)
            {
                _pollingInProgress = false;
                yield break;
            }

            if (!poll.OK)
            {
                LogError("Unable to check live modifications");
                yield break;
            }

            if(_lastMicroversion != poll.Response.SourceMicroversion)
            {
                _lastMicroversion = poll.Response.SourceMicroversion;

                var request = ApiClient.Instance.PartStudios.GetFaces("w", did, wid, eid,(decimal)1.5, 1, 1, null);

                yield return request.CallApi();

                if (!request.OK)
                {
                    LogError("Unable to load faces modifications");
                    yield break;
                }

                if (!_continuePolling)
                {
                    _pollingInProgress = false;
                    yield break;
                }

                yield return InternalDisplay(request.Response, did, wid, eid, false);

                if (!_continuePolling)
                {
                    _pollingInProgress = false;
                    yield break;
                }

                foreach (Transform child in gameObject.transform)
                {
                    if (child.gameObject.activeSelf)
                    {
                        Destroy(child.gameObject);
                    }
                    else
                    {
                        child.gameObject.SetActive(true);
                    }
                }
            }


        } while (true);

    }


    public GameObject FaceTemplate;
    public GameObject BodyTemplate;


    //public void GetWebSocketURL()
    //{

    //    StartCoroutine(yieldGetWebSocketURL());

    //}

    //private IEnumerator yieldGetWebSocketURL()
    //{

    //    var queryParams = new Dictionary<String, String>();

    //    var request = new ApiRequest<string>("/documents/637e96dc894ed4cf0d272fe8:062c89e758d0e2ba03b556b3/modelingServiceRequest", Method.GET, queryParams, null);
    //    //  var request = new ApiRequest<string>("/documents", Method.GET, queryParams, null);
    //    //https://cad.onshape.com/api/documents/637e96dc894ed4cf0d272fe8:062c89e758d0e2ba03b556b3/modelingServiceRequest
    //    //Location : wss://cad-euw1.onshape.com/btwssm/637e96dc894ed4cf0d272fe8/062c89e758d0e2ba03b556b3?_m=027d5fb0&locale=en-US&version=1.1.18"

    //    //request.www.SetRequestHeader("Pragma", "no-cache");
    //    //request.www.SetRequestHeader("Sec-Fetch-Site", "same-origin");
    //    //request.www.SetRequestHeader("DNT", "1");
    //    request.www.SetRequestHeader("X-XSRF-TOKEN", ApiClient.Instance.AccessToken);
    //    //request.www.SetRequestHeader("Accept-Encoding", "gzip, deflate, br");
    //    request.www.SetRequestHeader("Accept-Language", "en-US");
    //    // request.www.SetRequestHeader("Sec-Fetch-Mode", "no-cache");
    //    // request.www.SetRequestHeader("Accept", "cors");
    //    // request.www.SetRequestHeader("Pragma", "application/json, text/plain, */*");
    //    // request.www.SetRequestHeader("Cache-Control", "no-cache");
    //    // request.www.SetRequestHeader("Referer", "https://cad.onshape.com/documents/637e96dc894ed4cf0d272fe8/w/062c89e758d0e2ba03b556b3/e/f2a56f809704aee78079fb51");
    //    // request.www.SetRequestHeader("Connection", "keep-alive");

    //    yield return request.CallApi();

    //    var rep = request.Response;
    //}

        public void ResetScale()
    {
        // Mettre la mise à l'echelle pour transformer le repère P up de OnShape en Y up
        this.gameObject.transform.localScale = new Vector3(1, 1, -1);
        this.gameObject.transform.localRotation = Quaternion.Euler(90, 0, 0);
    }

    public void Homing()
    {
        this.gameObject.transform.position = Camera.main.transform.position + Camera.main.transform.forward;

    }

    private IEnumerator InternalDisplay(PartStudiosGetTesseletedFaceResponse200 faces, string did, string wid, string eid, bool visible)
    {
        foreach (var onshapeBody in faces.bodies)
        {
            var metadata = ApiClient.Instance.Parts.GetPartMetadata("w", did, wid, eid, onshapeBody.id, null, null, null, false);

            yield return metadata.CallApi();

            Material faceMaterial;

            if (metadata.OK)
            {
                faceMaterial = Instantiate(TemplateMaterial);

                float r = ((float)metadata.Response.Appearance.Color.Red) / 255.0f;
                float g = ((float)metadata.Response.Appearance.Color.Green) / 255.0f;
                float b = ((float)metadata.Response.Appearance.Color.Blue) / 255.0f;

                faceMaterial.color = new Color(r,g,b); // new Color(/ 255.0f, ((float)metadata.Response.Appearance.Color.Green) / 255.0f, ((float)metadata.Response.Appearance.Color.Blue) / 255.0f);
               
            }
            else
            {
                faceMaterial = TemplateMaterial;
            }


            var body = Instantiate(BodyTemplate, this.transform);
            body.name = onshapeBody.id;
            body.SetActive(visible);
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
                var meshFilter = face.GetComponent<MeshFilter>();
                meshFilter.mesh = m;

                var collider = face.GetComponent<MeshCollider>();
                collider.sharedMesh = m;

                var meshRenderer = face.GetComponent<MeshRenderer>();
                meshRenderer.material = faceMaterial;


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


           foreach(var collider in body.GetComponentsInChildren<MeshCollider>())
            {
                collider.convex = true;
            }
      
        }

        Main.HideProgress();
    }

}
