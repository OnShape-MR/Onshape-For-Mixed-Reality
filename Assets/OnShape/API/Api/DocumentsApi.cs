using System;
using System.Collections.Generic;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary
    public class DocumentsApi 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public DocumentsApi(ApiClient apiClient)
        {
            this.ApiClient = apiClient;
        }


        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }

        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public ApiClient ApiClient { get; set; }

        /// <summary>
        /// Copy Workspace Copy a workspace
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsCopyWorkspaceResponse200</returns>            
        public ApiRequest<DocumentsCopyWorkspaceResponse200> CopyWorkspace(string did, string wid, DocumentsCopyWorkspaceBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling CopyWorkspace");

            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling CopyWorkspace");


            var path = "/documents/{did}/workspaces/{wid}/copy";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wid" + "}", ApiClient.ParameterToString(wid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter




            // make the HTTP request
            return new ApiRequest<DocumentsCopyWorkspaceResponse200>(path, Method.POST, queryParams, postBody);

        }

        /// <summary>
        /// Create Document Create document
        /// </summary>
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsCreateDocumentResponse200</returns>            
        public ApiRequest<DocumentsCreateDocumentResponse200> CreateDocument(DocumentsCreateDocumentBody body)
        {


            var path = "/documents";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            return new ApiRequest<DocumentsCreateDocumentResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Create Version Create version at the current microversion of the specified workspace or a target microversion.                 Versions should be created only for tracking the state of a document that will need to be                 referenced by the user in the future. An application should not use versions as a convenience                 mechanism for an application to remember document states.
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsCreateVersionResponse200</returns>            
        public ApiRequest<DocumentsCreateVersionResponse200> CreateVersion(string did, DocumentsCreateVersionBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling CreateVersion");


            var path = "/documents/d/{did}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            return new ApiRequest<DocumentsCreateVersionResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Create Workspace Creates a new workspace. The starting point for the workspace can be specified using one of                 microversionId, workspaceId, versionId in that precedence order. A workspace also has a parent                 that may be specified or implied. If the starting point is taken from workspaceId or versionId,                 the parent version is implied to be the workspace parent or the version, respectively. If the                 starting point used is microversionId then the parent version is chosen based on workspaceId,                 versionId and default workspace, in that precedence order. If chosen based on a workspaceId, the                 version is the parent of the chosen workspace. If the effective version parentId is not a true                 parent of the starting microversion, an error is returned.
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsCreateWorkspaceResponse200</returns>            
        public ApiRequest<DocumentsCreateWorkspaceResponse200> CreateWorkspace(string did, DocumentsCreateWorkspaceBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling CreateWorkspace");


            var path = "/documents/d/{did}/workspaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter


            // make the HTTP request
            return new ApiRequest<DocumentsCreateWorkspaceResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Delete Document Delete a document
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <returns></returns>            
        public ApiRequest DeleteDocument(string did)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling DeleteDocument");


            var path = "/documents/{did}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // make the HTTP request
            return new ApiRequest(path, Method.DELETE, queryParams, postBody);

        }

        /// <summary>
        /// Delete Workspace Delete workspace
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <returns></returns>            
        public ApiRequest DeleteWorkspace(string did, string wid)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling DeleteWorkspace");

            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling DeleteWorkspace");


            var path = "/documents/d/{did}/workspaces/{wid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wid" + "}", ApiClient.ParameterToString(wid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // make the HTTP request
            return new ApiRequest(path, Method.DELETE, queryParams, postBody);

        }

        /// <summary>
        /// Download External Data Download external data
        /// </summary>
        /// <param name="fid">External data ID</param> 
        /// <param name="did">Document ID</param> 
        /// <returns>System.IO.Stream</returns>            
        public ApiRequest<System.IO.Stream> DownloadExternalData(string fid, string did)
        {

            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling DownloadExternalData");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling DownloadExternalData");


            var path = "/documents/d/{did}/externaldata/{fid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // make the HTTP request
            return new ApiRequest<System.IO.Stream>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Export Element (307) Export the given element in STL or Parasolid (PS) formats; returns a 307 redirect.
        /// </summary>
        /// <param name="wvChar">One of w or v corresponding to whether a workspace or version was entered.</param> 
        /// <param name="format">Export format: STL, PS</param> 
        /// <param name="scale">Scale for measurements (STL)</param> 
        /// <param name="mode">Type of file: text, binary (STL)</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wv">Workspace (w) or Version (v) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="storeInDocument">whether the output should be stored as a new element</param> 
        /// <param name="linkDocumentWorkspaceId">The id of the workspace in which the result should be           stored if storeInDocument is true and linkDocumentId is set.</param> 
        /// <param name="partIds">Comma-separated list of part IDs to export</param> 
        /// <param name="microversion">Specified microversion for operation</param> 
        /// <param name="grouping">Whether parts should be exported as a group or individually in a           .zip file (STL)</param> 
        /// <param name="zipSingleFileOutput">Whether single file output should be returned as a           .zip file (STL, grouping&#x3D;&#x3D;true)</param> 
        /// <param name="units">Name of base unit: meter, centimeter, millimeter, inch, foot, yard (STL)</param> 
        /// <param name="angleTolerance">Angle tolerance (must be &lt; pi/2) (STL)</param> 
        /// <param name="chordTolerance">Chord tolerance (STL)</param> 
        /// <param name="maxFacetWidth">Maximum facet width (STL)</param> 
        /// <param name="minFacetWidth">Minimum facet width (must be &lt; maximumFacetWidth) (STL)</param> 
        /// <param name="version">Parasolid version (PS)</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>System.IO.Stream</returns>            
        public ApiRequest<System.IO.Stream> ExportElement(string wvChar, string format, decimal? scale, string mode, string did, string wv, string eid, bool? storeInDocument, string linkDocumentWorkspaceId, string partIds, string microversion, bool? grouping, bool? zipSingleFileOutput, string units, decimal? angleTolerance, decimal? chordTolerance, decimal? maxFacetWidth, decimal? minFacetWidth, decimal? version, string linkDocumentId)
        {

            // verify the required parameter 'wvChar' is set
            if (wvChar == null) throw new ApiException(400, "Missing required parameter 'wvChar' when calling ExportElement");

            // verify the required parameter 'format' is set
            if (format == null) throw new ApiException(400, "Missing required parameter 'format' when calling ExportElement");

            // verify the required parameter 'scale' is set
            if (scale == null) throw new ApiException(400, "Missing required parameter 'scale' when calling ExportElement");

            // verify the required parameter 'mode' is set
            if (mode == null) throw new ApiException(400, "Missing required parameter 'mode' when calling ExportElement");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ExportElement");

            // verify the required parameter 'wv' is set
            if (wv == null) throw new ApiException(400, "Missing required parameter 'wv' when calling ExportElement");

            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ExportElement");


            var path = "/documents/d/{did}/{wv_char}/{wv}/e/{eid}/export";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wv_char" + "}", ApiClient.ParameterToString(wvChar));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wv" + "}", ApiClient.ParameterToString(wv));
            path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (format != null) queryParams.Add("format", ApiClient.ParameterToString(format)); // query parameter
            if (storeInDocument != null) queryParams.Add("storeInDocument", ApiClient.ParameterToString(storeInDocument)); // query parameter
            if (linkDocumentWorkspaceId != null) queryParams.Add("linkDocumentWorkspaceId", ApiClient.ParameterToString(linkDocumentWorkspaceId)); // query parameter
            if (partIds != null) queryParams.Add("partIds", ApiClient.ParameterToString(partIds)); // query parameter
            if (microversion != null) queryParams.Add("microversion", ApiClient.ParameterToString(microversion)); // query parameter
            if (grouping != null) queryParams.Add("grouping", ApiClient.ParameterToString(grouping)); // query parameter
            if (zipSingleFileOutput != null) queryParams.Add("zipSingleFileOutput", ApiClient.ParameterToString(zipSingleFileOutput)); // query parameter
            if (scale != null) queryParams.Add("scale", ApiClient.ParameterToString(scale)); // query parameter
            if (units != null) queryParams.Add("units", ApiClient.ParameterToString(units)); // query parameter
            if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance)); // query parameter
            if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
            if (maxFacetWidth != null) queryParams.Add("maxFacetWidth", ApiClient.ParameterToString(maxFacetWidth)); // query parameter
            if (minFacetWidth != null) queryParams.Add("minFacetWidth", ApiClient.ParameterToString(minFacetWidth)); // query parameter
            if (mode != null) queryParams.Add("mode", ApiClient.ParameterToString(mode)); // query parameter
            if (version != null) queryParams.Add("version", ApiClient.ParameterToString(version)); // query parameter
            if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter



            // make the HTTP request
            return new ApiRequest<System.IO.Stream>(path, Method.GET, queryParams, postBody);

        }

        /// <summary>
        /// Export Element (URI) Export the given element in STL or Parasolid (PS) formats; returns an URI in the response body,                 client should GET this URI to initiate the export.
        /// </summary>
        /// <param name="wvChar">One of w or v corresponding to whether a workspace or version was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wv">Workspace (w) or Version (v) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>DocumentsExportElementPostJsonResponse200</returns>            
        public ApiRequest<DocumentsExportElementPostJsonResponse200> ExportElementPostJson(string wvChar, string did, string wv, string eid, DocumentsExportElementPostJsonBody body, string linkDocumentId)
        {

            // verify the required parameter 'wvChar' is set
            if (wvChar == null) throw new ApiException(400, "Missing required parameter 'wvChar' when calling ExportElementPostJson");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ExportElementPostJson");

            // verify the required parameter 'wv' is set
            if (wv == null) throw new ApiException(400, "Missing required parameter 'wv' when calling ExportElementPostJson");

            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ExportElementPostJson");


            var path = "/documents/d/{did}/{wv_char}/{wv}/e/{eid}/export";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wv_char" + "}", ApiClient.ParameterToString(wvChar));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wv" + "}", ApiClient.ParameterToString(wv));
            path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
            postBody = ApiClient.Serialize(body); // http body (model) parameter




            // make the HTTP request
            return new ApiRequest<DocumentsExportElementPostJsonResponse200>(path, Method.POST, queryParams, postBody);

        }

        /// <summary>
        /// Get Access Control List Get list of entities with access to a document and the permissions granted to them. The caller     must have read access for the document.
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <returns>DocumentsGetAclResponse200</returns>            
        public ApiRequest<DocumentsGetAclResponse200> GetAcl(string did)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetAcl");


            var path = "/documents/{did}/acl";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // make the HTTP request
            return new ApiRequest<DocumentsGetAclResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Current Document Microversion Get current microversion from a version or workspace
        /// </summary>
        /// <param name="wvChar">One of w or v corresponding to whether a workspace or version was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wv">Workspace (w) or Version (v) ID</param> 
        /// <returns>DocumentsGetCurrentMicroversionResponse200</returns>            
        public ApiRequest<DocumentsGetCurrentMicroversionResponse200> GetCurrentMicroversion(string wvChar, string did, string wv)
        {

            // verify the required parameter 'wvChar' is set
            if (wvChar == null) throw new ApiException(400, "Missing required parameter 'wvChar' when calling GetCurrentMicroversion");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetCurrentMicroversion");

            // verify the required parameter 'wv' is set
            if (wv == null) throw new ApiException(400, "Missing required parameter 'wv' when calling GetCurrentMicroversion");


            var path = "/documents/d/{did}/{wv_char}/{wv}/currentmicroversion";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wv_char" + "}", ApiClient.ParameterToString(wvChar));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wv" + "}", ApiClient.ParameterToString(wv));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // make the HTTP request
            return new ApiRequest<DocumentsGetCurrentMicroversionResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Document Get full details about a document
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <returns>DocumentsGetDocumentResponse200</returns>            
        public ApiRequest<DocumentsGetDocumentResponse200> GetDocument(string did)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetDocument");


            var path = "/documents/{did}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            // make the HTTP request
            return new ApiRequest<DocumentsGetDocumentResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Document Permissions Get the permission set for a document
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <returns></returns>            
        public ApiRequest GetDocumentPermissionSet(string did)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetDocumentPermissionSet");


            var path = "/documents/{did}/permissionset";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;



            // make the HTTP request
            return new ApiRequest(path, Method.GET, queryParams, postBody);

        }

        /// <summary>
        /// Get Documents Search for documents
        /// </summary>
        /// <param name="q">Search for documents that contain the given string in the name. Search is           not case-sensitive.</param> 
        /// <param name="filter">Filter ID, which can be 0: my docs, 1: created, 2: shared, 3: trash,           4: public, 5: recent, 6: by owner, 7: by company, or 9: by team</param> 
        /// <param name="owner">Document owner&#39;s ID if filter is 6 or 7. Team Id if filter is 9</param> 
        /// <param name="ownerType">Type of owner, which can be 0: user, 1: company, 2: onshape. If           owner is a teamId, leave this unspecified.</param> 
        /// <param name="sortColumn">Column by which to sort search results. Valid options           are name, modifiedAt, createdAt, email, modifiedBy, and promotedAt</param> 
        /// <param name="sortOrder">Sort order, which can be desc: descending, or asc: ascending</param> 
        /// <param name="offset">Where to begin search results</param> 
        /// <param name="limit">Number of results to return per page (max is 20)</param> 
        /// <returns>DocumentsGetDocumentsResponse200</returns>            
        public ApiRequest<DocumentsGetDocumentsResponse200> GetDocuments(string q, decimal? filter, string owner, decimal? ownerType, string sortColumn, string sortOrder, decimal? offset, decimal? limit)
        {


            var path = "/documents";
            path = path.Replace("{format}", "json");

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (q != null) queryParams.Add("q", ApiClient.ParameterToString(q)); // query parameter
            if (filter != null) queryParams.Add("filter", ApiClient.ParameterToString(filter)); // query parameter
            if (owner != null) queryParams.Add("owner", ApiClient.ParameterToString(owner)); // query parameter
            if (ownerType != null) queryParams.Add("ownerType", ApiClient.ParameterToString(ownerType)); // query parameter
            if (sortColumn != null) queryParams.Add("sortColumn", ApiClient.ParameterToString(sortColumn)); // query parameter
            if (sortOrder != null) queryParams.Add("sortOrder", ApiClient.ParameterToString(sortOrder)); // query parameter
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter


            // make the HTTP request
            return new ApiRequest<DocumentsGetDocumentsResponse200>(path, Method.GET, queryParams, postBody);

        }

        /// <summary>
        /// Element List Get a list of elements in the workspace, version, or microversion of the document.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="elementType">Return only elements of this elementType</param> 
        /// <param name="elementId">Return only element with this ID</param> 
        /// <param name="withThumbnails">If true, include element thumbnail information</param> 
        /// <returns>DocumentsGetElementListResponse200</returns>            
        public ApiRequest<DocumentsGetElementListResponse200> GetElementList(string wvmChar, string did, string wvm, string elementType, string elementId, bool? withThumbnails)
        {

            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetElementList");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetElementList");

            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetElementList");


            var path = "/documents/d/{did}/{wvm_char}/{wvm}/elements";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (elementType != null) queryParams.Add("elementType", ApiClient.ParameterToString(elementType)); // query parameter
            if (elementId != null) queryParams.Add("elementId", ApiClient.ParameterToString(elementId)); // query parameter
            if (withThumbnails != null) queryParams.Add("withThumbnails", ApiClient.ParameterToString(withThumbnails)); // query parameter




            // make the HTTP request
            return new ApiRequest<DocumentsGetElementListResponse200>(path, Method.GET, queryParams, postBody);

        }

        /// <summary>
        /// Insertable List for Document Version. Get a list of insertables in the version of the document.
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="vid">Version ID</param> 
        /// <param name="betaCapabilityIds">Beta capablities of the document requesting insertables</param> 
        /// <param name="includeParts">Returns parts</param> 
        /// <param name="includeSurfaces">Returns surfaces</param> 
        /// <param name="includeWires">Returns wires</param> 
        /// <param name="includeSketches">Returns sketches</param> 
        /// <param name="includeReferenceFeatures">Returns reference features</param> 
        /// <param name="includeAssemblies">Returns assemblies</param> 
        /// <param name="includeFeatureStudios">Returns feature studios</param> 
        /// <param name="includeFeatures">Returns features</param> 
        /// <param name="includeBlobs">Returns blobs</param> 
        /// <param name="includeMeshes">Returns meshes</param> 
        /// <param name="includeFlattenedBodies">Returns flattened sheetmetal bodies</param> 
        /// <param name="includeApplications">Return applications</param> 
        /// <param name="allowedBlobMimeTypes">Comma separated list of blob mime types to include</param> 
        /// <param name="allowedApplicationMimeTypes">Comma separated list of application format ids to           include</param> 
        /// <param name="maxFeatureScriptVersion">If specified and is greater than zero, insertables           that are created using feature script version less than or equal to maxFeatureScriptVersion will be           returned</param> 
        /// <returns>DocumentsGetInsertablesResponse200</returns>            
        public ApiRequest<DocumentsGetInsertablesResponse200> GetInsertables(string did, string vid, string betaCapabilityIds, bool? includeParts, bool? includeSurfaces, bool? includeWires, bool? includeSketches, bool? includeReferenceFeatures, bool? includeAssemblies, bool? includeFeatureStudios, bool? includeFeatures, bool? includeBlobs, bool? includeMeshes, bool? includeFlattenedBodies, bool? includeApplications, string allowedBlobMimeTypes, string allowedApplicationMimeTypes, decimal? maxFeatureScriptVersion)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetInsertables");

            // verify the required parameter 'vid' is set
            if (vid == null) throw new ApiException(400, "Missing required parameter 'vid' when calling GetInsertables");


            var path = "/documents/d/{did}/v/{vid}/insertables";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "vid" + "}", ApiClient.ParameterToString(vid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (betaCapabilityIds != null) queryParams.Add("betaCapabilityIds", ApiClient.ParameterToString(betaCapabilityIds)); // query parameter
            if (includeParts != null) queryParams.Add("includeParts", ApiClient.ParameterToString(includeParts)); // query parameter
            if (includeSurfaces != null) queryParams.Add("includeSurfaces", ApiClient.ParameterToString(includeSurfaces)); // query parameter
            if (includeWires != null) queryParams.Add("includeWires", ApiClient.ParameterToString(includeWires)); // query parameter
            if (includeSketches != null) queryParams.Add("includeSketches", ApiClient.ParameterToString(includeSketches)); // query parameter
            if (includeReferenceFeatures != null) queryParams.Add("includeReferenceFeatures", ApiClient.ParameterToString(includeReferenceFeatures)); // query parameter
            if (includeAssemblies != null) queryParams.Add("includeAssemblies", ApiClient.ParameterToString(includeAssemblies)); // query parameter
            if (includeFeatureStudios != null) queryParams.Add("includeFeatureStudios", ApiClient.ParameterToString(includeFeatureStudios)); // query parameter
            if (includeFeatures != null) queryParams.Add("includeFeatures", ApiClient.ParameterToString(includeFeatures)); // query parameter
            if (includeBlobs != null) queryParams.Add("includeBlobs", ApiClient.ParameterToString(includeBlobs)); // query parameter
            if (includeMeshes != null) queryParams.Add("includeMeshes", ApiClient.ParameterToString(includeMeshes)); // query parameter
            if (includeFlattenedBodies != null) queryParams.Add("includeFlattenedBodies", ApiClient.ParameterToString(includeFlattenedBodies)); // query parameter
            if (includeApplications != null) queryParams.Add("includeApplications", ApiClient.ParameterToString(includeApplications)); // query parameter
            if (allowedBlobMimeTypes != null) queryParams.Add("allowedBlobMimeTypes", ApiClient.ParameterToString(allowedBlobMimeTypes)); // query parameter
            if (allowedApplicationMimeTypes != null) queryParams.Add("allowedApplicationMimeTypes", ApiClient.ParameterToString(allowedApplicationMimeTypes)); // query parameter
            if (maxFeatureScriptVersion != null) queryParams.Add("maxFeatureScriptVersion", ApiClient.ParameterToString(maxFeatureScriptVersion)); // query parameter




            // make the HTTP request
            return new ApiRequest<DocumentsGetInsertablesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Version Get information about a version
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="vid">Version ID</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>DocumentsGetVersionResponse200</returns>            
        public ApiRequest<DocumentsGetVersionResponse200> GetVersion(string did, string vid, string linkDocumentId)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetVersion");

            // verify the required parameter 'vid' is set
            if (vid == null) throw new ApiException(400, "Missing required parameter 'vid' when calling GetVersion");


            var path = "/documents/d/{did}/versions/{vid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "vid" + "}", ApiClient.ParameterToString(vid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter




            // make the HTTP request
            return new ApiRequest<DocumentsGetVersionResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Versions Get the versions in a document
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="offset">Where to begin search results</param> 
        /// <param name="limit">Number of results to return per page. When specified, it cannot exceed           20. Default is unlimited</param> 
        /// <returns>DocumentsGetVersionsResponse200</returns>            
        public ApiRequest<DocumentsGetVersionsResponse200> GetVersions(string did, decimal? offset, decimal? limit)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetVersions");


            var path = "/documents/d/{did}/versions";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter




            // make the HTTP request
            return new ApiRequest<DocumentsGetVersionsResponse200>(path, Method.GET, queryParams, postBody);

        }

        /// <summary>
        /// Get Workspaces List workspaces in document
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="noreadonly">Do not return read-only workspaces</param> 
        /// <returns>DocumentsGetWorkspacesResponse200</returns>            
        public ApiRequest<DocumentsGetWorkspacesResponse200> GetWorkspaces(string did, string noreadonly)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetWorkspaces");


            var path = "/documents/d/{did}/workspaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (noreadonly != null) queryParams.Add("noreadonly", ApiClient.ParameterToString(noreadonly)); // query parameter


            // make the HTTP request
            return new ApiRequest<DocumentsGetWorkspacesResponse200>(path, Method.GET, queryParams, postBody);

        }

        /// <summary>
        /// Move Elements Move elements from a source document to a destination document
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsMoveElementsToDocumentResponse200</returns>            
        public ApiRequest<DocumentsMoveElementsToDocumentResponse200> MoveElementsToDocument(string did, string wid, DocumentsMoveElementsToDocumentBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling MoveElementsToDocument");

            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling MoveElementsToDocument");


            var path = "/documents/d/{did}/w/{wid}/moveelement";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wid" + "}", ApiClient.ParameterToString(wid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter




            // make the HTTP request
            return new ApiRequest<DocumentsMoveElementsToDocumentResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Share Document Share document with one or more entities, which may be users, companies, teams or applications.
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsShareDocumentResponse200</returns>            
        public ApiRequest<DocumentsShareDocumentResponse200> ShareDocument(string did, DocumentsShareDocumentBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ShareDocument");


            var path = "/documents/{did}/share";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter




            // make the HTTP request
            return new ApiRequest<DocumentsShareDocumentResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Unshare Document Remove share permissions from document
        /// </summary>
        /// <param name="eid">Entry ID of the share entry to be deleted</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="entryType">The type of entity referenced by eid. Valid values are      0&#x3D;User, 1&#x3D;Company, 2&#x3D;Team, 4&#x3D;Application.</param> 
        /// <returns></returns>            
        public ApiRequest UnShare(string eid, string did, decimal? entryType)
        {

            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UnShare");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UnShare");


            var path = "/documents/{did}/share/{eid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (entryType != null) queryParams.Add("entryType", ApiClient.ParameterToString(entryType)); // query parameter




            // make the HTTP request
            return new ApiRequest(path, Method.DELETE, queryParams, postBody);

        }

        /// <summary>
        /// Update Document Attributes. Update document attributes name, description
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns></returns>            
        public ApiRequest UpdateDocumentAttributes(string did, DocumentsUpdateDocumentAttributesBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateDocumentAttributes");


            var path = "/documents/{did}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter




            // make the HTTP request
            return new ApiRequest(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Update External References to Latest Update the external references to the latest documents if the referenced external elements have been parted out
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>DocumentsUpdateExternalReferencesToLatestDocumentsResponse200</returns>            
        public ApiRequest<DocumentsUpdateExternalReferencesToLatestDocumentsResponse200> UpdateExternalReferencesToLatestDocuments(string did, string wid, string eid, DocumentsUpdateExternalReferencesToLatestDocumentsBody body)
        {

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateExternalReferencesToLatestDocuments");

            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling UpdateExternalReferencesToLatestDocuments");

            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdateExternalReferencesToLatestDocuments");


            var path = "/documents/d/{did}/w/{wid}/e/{eid}/latestdocumentreferences";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wid" + "}", ApiClient.ParameterToString(wid));
            path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            postBody = ApiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            return new ApiRequest<DocumentsUpdateExternalReferencesToLatestDocumentsResponse200>(path, Method.POST, queryParams, postBody);

        }

    }
}