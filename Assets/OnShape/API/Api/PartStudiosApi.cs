using System;
using System.Collections.Generic;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{

  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PartStudiosApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartStudiosApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PartStudiosApi(ApiClient apiClient = null)
        {
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
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
        public ApiClient ApiClient {get; set;}
    
        /// <summary>
        /// Add Feature Add a feature to the feature list for a part studio. See the developer portal feature list                 help topic for additional information
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosAddFeatureResponse200</returns>            
        public ApiRequest<PartStudiosAddFeatureResponse200> AddFeature (string did, string wid, string eid, PartStudiosAddFeatureBody body)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling AddFeature");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling AddFeature");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling AddFeature");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/features";
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
            return new ApiRequest<PartStudiosAddFeatureResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Compare Part Studio Compare Part Studio in different versions / workspaces of a Document. Comparison can be done                 between any combinations of source Workspace | Version | Microversion (specified in URL) and                 target Workspace | Version | Microversion (specified as a query parameter). One of versionId,                 workspaceId, or microversionId query parameters needs to be specified to identify target                 microversion of the comparison. The result of the comparison is indicated by the following                 values: of NONE - entity exists in both source and target states and there&#39;s no change in its                 state | MODIFIED - entity exists in both source and target states and there&#39;s some change in its                 state | ADDED - entity exists in target only | DELETED - entity exists in source only.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="workspaceId">Id of the Workspace to compare the Part Studio with</param> 
        /// <param name="versionId">Id of a Version to compare the Part Studio with</param> 
        /// <param name="microversionId">Id of a document microversion to compare the Part Studio with</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartStudiosComparePartStudioResponse200</returns>            
        public ApiRequest<PartStudiosComparePartStudioResponse200> ComparePartStudio (string wvmChar, string did, string wvm, string eid, string workspaceId, string versionId, decimal? microversionId, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling ComparePartStudio");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ComparePartStudio");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling ComparePartStudio");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ComparePartStudio");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/compare";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (workspaceId != null) queryParams.Add("workspaceId", ApiClient.ParameterToString(workspaceId)); // query parameter
 if (versionId != null) queryParams.Add("versionId", ApiClient.ParameterToString(versionId)); // query parameter
 if (microversionId != null) queryParams.Add("microversionId", ApiClient.ParameterToString(microversionId)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosComparePartStudioResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Create Part Studio Create an new part studio tab in the document.
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosCreatePartStudioResponse200</returns>            
        public ApiRequest<PartStudiosCreatePartStudioResponse200> CreatePartStudio (string did, string wid, PartStudiosCreatePartStudioBody body)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling CreatePartStudio");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling CreatePartStudio");
            
    
            var path = "/partstudios/d/{did}/w/{wid}";
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
            return new ApiRequest<PartStudiosCreatePartStudioResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Create Part Studio translation Create an element translation. The translation may be incomplete at the time that the call                 completes. If the requestState is ACTIVE, the translation can be polled until the state becomes                 either DONE or FAILED. Alternatively, a webhook callback can be registered for notification of                 translation completion. (Requires Write scope if storeInDocument is true)
        /// </summary>
        /// <param name="wvChar">One of w or v corresponding to whether a workspace or version was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wv">Workspace (w) or Version (v) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosCreateTranslationResponse200</returns>            
        public ApiRequest<PartStudiosCreateTranslationResponse200> CreateTranslation (string wvChar, string did, string wv, string eid, PartStudiosCreateTranslationBody body)
        {
            
            // verify the required parameter 'wvChar' is set
            if (wvChar == null) throw new ApiException(400, "Missing required parameter 'wvChar' when calling CreateTranslation");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling CreateTranslation");
            
            // verify the required parameter 'wv' is set
            if (wv == null) throw new ApiException(400, "Missing required parameter 'wv' when calling CreateTranslation");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling CreateTranslation");
            
    
            var path = "/partstudios/d/{did}/{wv_char}/{wv}/e/{eid}/translations";
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
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosCreateTranslationResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Delete Feature Delete an existing feature in the feature list for a part studio. See the developer                 portal feature list help topic for additional information
        /// </summary>
        /// <param name="fid">The id of the feature being updated.  This id should be URL encoded</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <returns>PartStudiosDeleteFeatureResponse200</returns>            
        public ApiRequest<PartStudiosDeleteFeatureResponse200> DeleteFeature (string fid, string did, string wid, string eid)
        {
            
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling DeleteFeature");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling DeleteFeature");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling DeleteFeature");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling DeleteFeature");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/features/featureid/{fid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wid" + "}", ApiClient.ParameterToString(wid));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // make the HTTP request
            return new ApiRequest<PartStudiosDeleteFeatureResponse200>(path, Method.DELETE, queryParams, postBody);
        }

        /// <summary>
        /// Evaluate FeatureScript Evaluate featurescript in the context of a part studio. See the developer portal feature list                 help topic for additional information
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosEvalFeatureScriptResponse200</returns>            
        public ApiRequest<PartStudiosEvalFeatureScriptResponse200> EvalFeatureScript (string wvmChar, string did, string wvm, string eid, PartStudiosEvalFeatureScriptBody body)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling EvalFeatureScript");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling EvalFeatureScript");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling EvalFeatureScript");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling EvalFeatureScript");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/featurescript";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosEvalFeatureScriptResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Export Part Studio to Parasolid Export the part studio in text Parasolid format; returns a 307 redirect.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partIds">Comma-separated list of part IDs to export (omit to export entire part           studio)</param> 
        /// <param name="version">Parasolid version</param> 
        /// <param name="includeExportIds">Whether topolgy ids should be exported as parasolid           attributes</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>System.IO.Stream</returns>            
        public ApiRequest<System.IO.Stream> ExportParasolid (string wvmChar, string did, string wvm, string eid, string partIds, decimal? version, bool? includeExportIds, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling ExportParasolid");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ExportParasolid");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling ExportParasolid");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ExportParasolid");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/parasolid";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (partIds != null) queryParams.Add("partIds", ApiClient.ParameterToString(partIds)); // query parameter
 if (version != null) queryParams.Add("version", ApiClient.ParameterToString(version)); // query parameter
 if (includeExportIds != null) queryParams.Add("includeExportIds", ApiClient.ParameterToString(includeExportIds)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<System.IO.Stream>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Export Part Studio to STL Export the part studio in text or binary STL format; returns a 307 redirect.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partIds">Comma-separated list of part IDs to export (omit to export entire part           studio)</param> 
        /// <param name="grouping">Whether parts should be exported as a group or individually in a           .zip file</param> 
        /// <param name="scale">Scale for measurements</param> 
        /// <param name="units">Name of base unit (meter, centimeter, millimeter, inch, foot, or           yard)</param> 
        /// <param name="angleTolerance">Angle tolerance (in radians; must be &lt; pi/2)</param> 
        /// <param name="chordTolerance">Chord tolerance (in selected units)</param> 
        /// <param name="maxFacetWidth">Maximum facet width (in selected units)</param> 
        /// <param name="minFacetWidth">Minimum facet width (in selected units - must be &lt;           maximumFacetWidth)</param> 
        /// <param name="mode">Type of file: text, binary</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>System.IO.Stream</returns>            
        public ApiRequest<System.IO.Stream> ExportStl (string wvmChar, string did, string wvm, string eid, string partIds, bool? grouping, decimal? scale, string units, decimal? angleTolerance, decimal? chordTolerance, decimal? maxFacetWidth, decimal? minFacetWidth, string mode, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling ExportStl");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ExportStl");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling ExportStl");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ExportStl");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/stl";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (partIds != null) queryParams.Add("partIds", ApiClient.ParameterToString(partIds)); // query parameter
 if (grouping != null) queryParams.Add("grouping", ApiClient.ParameterToString(grouping)); // query parameter
 if (scale != null) queryParams.Add("scale", ApiClient.ParameterToString(scale)); // query parameter
 if (units != null) queryParams.Add("units", ApiClient.ParameterToString(units)); // query parameter
 if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance)); // query parameter
 if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
 if (maxFacetWidth != null) queryParams.Add("maxFacetWidth", ApiClient.ParameterToString(maxFacetWidth)); // query parameter
 if (minFacetWidth != null) queryParams.Add("minFacetWidth", ApiClient.ParameterToString(minFacetWidth)); // query parameter
 if (mode != null) queryParams.Add("mode", ApiClient.ParameterToString(mode)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<System.IO.Stream>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Body Details Get the body details of a Part Studio.  All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartStudiosGetBodyDetailsResponse200</returns>            
        public ApiRequest<PartStudiosGetBodyDetailsResponse200> GetBodyDetails (string wvmChar, string did, string wvm, string eid, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetBodyDetails");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetBodyDetails");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetBodyDetails");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetBodyDetails");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/bodydetails";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetBodyDetailsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Bounding Box Get the bounding box of a Part Studio, or an empty object if the Part Studio is empty. All                 coordinates are in meters. Sketches are not used in computing the result.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="includeHidden">Whether or not to include bounding boxes for hidden parts</param> 
        /// <param name="includeWireBodies">Whether to include wire bodies in the bounding box           calculation</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartStudiosGetBoundingBoxesResponse200</returns>            
        public ApiRequest<PartStudiosGetBoundingBoxesResponse200> GetBoundingBoxes (string wvmChar, string did, string wvm, string eid, bool? includeHidden, bool? includeWireBodies, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetBoundingBoxes");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetBoundingBoxes");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetBoundingBoxes");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetBoundingBoxes");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/boundingboxes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeHidden != null) queryParams.Add("includeHidden", ApiClient.ParameterToString(includeHidden)); // query parameter
 if (includeWireBodies != null) queryParams.Add("includeWireBodies", ApiClient.ParameterToString(includeWireBodies)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetBoundingBoxesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Sketch Bounding Box Get the bounding box of a sketch. All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="sid">Sketch feature ID</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartStudiosGetBoundingBoxesForSketchResponse200</returns>            
        public ApiRequest<PartStudiosGetBoundingBoxesForSketchResponse200> GetBoundingBoxesForSketch (string wvmChar, string did, string wvm, string eid, string sid, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetBoundingBoxesForSketch");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetBoundingBoxesForSketch");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetBoundingBoxesForSketch");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetBoundingBoxesForSketch");
            
            // verify the required parameter 'sid' is set
            if (sid == null) throw new ApiException(400, "Missing required parameter 'sid' when calling GetBoundingBoxesForSketch");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/sketches/{sid}/boundingboxes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "sid" + "}", ApiClient.ParameterToString(sid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetBoundingBoxesForSketchResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Configuration Get the configuration definition for a part studio. See the developer portal feature list                 help topic for additional information
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <returns>PartStudiosGetConfigurationResponse200</returns>            
        public ApiRequest<PartStudiosGetConfigurationResponse200> GetConfiguration (string wvmChar, string did, string wvm, string eid)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetConfiguration");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetConfiguration");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetConfiguration");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetConfiguration");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/configuration";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // make the HTTP request
            return new ApiRequest<PartStudiosGetConfigurationResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Tessellated Edges Get the tessellated edges of the parts in a Part Studio. The accuracy of the tessellation     approximation to exact geometry is controlled by the angleTolerance and chordTolerance parameters. The     tessellation points are computed close enough so that neither the angle tolerance nor the chord tolerance are     exceeded.     All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="angleTolerance">Angle tolerance (in radians). This specifies the limit     on the sum of the angular deviations of a tessellation chord from the tangent vectors at two chord endpoints.     The specified value must be less than PI/2. This parameter currently has a default value chosen based on     the complexity of the parts being tessellated.</param> 
        /// <param name="chordTolerance">Chord tolerance (in meters). This specifies the limit on     the maximum deviation of a tessellation chord from the true edge. This parameter currently has a default     value chosen based on the size and complexity of the parts being tessellated.</param> 
        /// <param name="edgeId">IDs of edges to tessellate (repeat query param to add more than one,     i.e. edgeId&#x3D;JHK&amp;edgeId&#x3D;JHD)</param> 
        /// <param name="partId">IDs of the parts to tessellate (repeat query param to add more than one,     i.e. partId&#x3D;JHK&amp;partId&#x3D;JHD).  May not be combined with edgeId</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartStudiosGetEdgesResponse200</returns>            
        public ApiRequest<PartStudiosGetEdgesResponse200> GetEdges (string wvmChar, string did, string wvm, string eid, decimal? angleTolerance, decimal? chordTolerance, string edgeId, string partId, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetEdges");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetEdges");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetEdges");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetEdges");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/tessellatededges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance)); // query parameter
 if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
 if (edgeId != null) queryParams.Add("edgeId", ApiClient.ParameterToString(edgeId)); // query parameter
 if (partId != null) queryParams.Add("partId", ApiClient.ParameterToString(partId)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetEdgesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Tessellated Faces Get the tessellated faces of the parts in a Part Studio. The accuracy of the tessellation                 approximation to exact geometry is controlled by the angleTolerance, chordTolerance and                 maxFacetWidth parameters. The tessellation points are computed close enough so that none of these                 parameters are exceeded. All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="angleTolerance">Angle tolerance (in radians). This specifies the limit on the           sum of the angular deviations of a tessellation chord from the tangent vectors at two chord endpoints.           The specified value must be less than PI/2. This parameter currently has a default value chosen based           on the complexity of the parts being tessellated.</param> 
        /// <param name="chordTolerance">Chord tolerance (in meters). This specifies the limit on the           maximum deviation of a tessellation chord from the true surface/edge. This parameter currently has a           default value chosen based on the size and complexity of the parts being tessellated.</param> 
        /// <param name="maxFacetWidth">Max facet width. This specifies the limit on the size of any side           of a tessellation facet.</param> 
        /// <param name="outputVertexNormals">If true, output vertex normals corresponding to           surface normals at facet vertex points.</param> 
        /// <param name="outputFacetNormals">Output facet normals</param> 
        /// <param name="outputTextureCoordinates">Output texture coordinates</param> 
        /// <param name="outputIndexTable">Output index table</param> 
        /// <param name="faceId">IDs of the faces to tessellate (repeat query param to add more than one,           i.e. faceId&#x3D;JHK&amp;faceId&#x3D;JHD)</param> 
        /// <param name="partId">IDs of the parts to tessellate (repeat query param to add more than one,           i.e. partId&#x3D;JHK&amp;partId&#x3D;JHD). May not be combined with faceId</param> 
        /// <param name="outputErrorFaces">Whether or not to output faces that cause an error</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartStudiosGetFacesResponse200</returns>            
        public ApiRequest<PartStudiosGetFacesResponse200> GetFaces (string wvmChar, string did, string wvm, string eid, decimal? angleTolerance, decimal? chordTolerance, decimal? maxFacetWidth, bool? outputVertexNormals, bool? outputFacetNormals, bool? outputTextureCoordinates, bool? outputIndexTable, string faceId, string partId, bool? outputErrorFaces, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetFaces");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetFaces");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetFaces");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetFaces");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/tessellatedfaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance)); // query parameter
 if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
 if (maxFacetWidth != null) queryParams.Add("maxFacetWidth", ApiClient.ParameterToString(maxFacetWidth)); // query parameter
 if (outputVertexNormals != null) queryParams.Add("outputVertexNormals", ApiClient.ParameterToString(outputVertexNormals)); // query parameter
 if (outputFacetNormals != null) queryParams.Add("outputFacetNormals", ApiClient.ParameterToString(outputFacetNormals)); // query parameter
 if (outputTextureCoordinates != null) queryParams.Add("outputTextureCoordinates", ApiClient.ParameterToString(outputTextureCoordinates)); // query parameter
 if (outputIndexTable != null) queryParams.Add("outputIndexTable", ApiClient.ParameterToString(outputIndexTable)); // query parameter
 if (faceId != null) queryParams.Add("faceId", ApiClient.ParameterToString(faceId)); // query parameter
 if (partId != null) queryParams.Add("partId", ApiClient.ParameterToString(partId)); // query parameter
 if (outputErrorFaces != null) queryParams.Add("outputErrorFaces", ApiClient.ParameterToString(outputErrorFaces)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetFacesResponse200>(path, Method.GET, queryParams, postBody);
        }

        public ApiRequest<PartStudiosGetTesseletedFaceResponse200> GetFaces(string wvmChar, string did, string wvm, string eid, decimal? angleTolerance, decimal? chordTolerance, decimal? maxFacetWidth, string configuration)
        {

            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetFaces");

            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetFaces");

            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetFaces");

            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetFaces");

            bool? outputVertexNormals = true;
            bool? outputFacetNormals = false;
            bool? outputTextureCoordinates = false;
            bool? outputIndexTable = true;
            bool? outputErrorFaces = true;


            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/tessellatedfaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
            path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
            path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));

            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance).Replace(",", ".")); // query parameter
            if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
            if (maxFacetWidth != null) queryParams.Add("maxFacetWidth", ApiClient.ParameterToString(maxFacetWidth)); // query parameter
            if (outputVertexNormals != null) queryParams.Add("outputVertexNormals", ApiClient.ParameterToString(outputVertexNormals)); // query parameter
            if (outputFacetNormals != null) queryParams.Add("outputFacetNormals", ApiClient.ParameterToString(outputFacetNormals)); // query parameter
            if (outputTextureCoordinates != null) queryParams.Add("outputTextureCoordinates", ApiClient.ParameterToString(outputTextureCoordinates)); // query parameter
            if (outputIndexTable != null) queryParams.Add("outputIndexTable", ApiClient.ParameterToString(outputIndexTable)); // query parameter
            if (outputErrorFaces != null) queryParams.Add("outputErrorFaces", ApiClient.ParameterToString(outputErrorFaces)); // query parameter
            if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetTesseletedFaceResponse200>(path, Method.GET, queryParams, postBody);
        }


        /// <summary>
        /// Get Feature Specs Get the definition of the feature specs for a part studio. See the developer                 portal feature list help topic for additional information
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <returns>PartStudiosGetFeatureSpecsResponse200</returns>            
        public ApiRequest<PartStudiosGetFeatureSpecsResponse200> GetFeatureSpecs (string wvmChar, string did, string wvm, string eid)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetFeatureSpecs");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetFeatureSpecs");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetFeatureSpecs");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetFeatureSpecs");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/featurespecs";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;


            // make the HTTP request
            return new ApiRequest<PartStudiosGetFeatureSpecsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Feature List Get the definition of the feature list for a part studio. See the developer portal feature list                 help topic for additional information
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="featureId">ID of a feature; repeat query param to add more than one</param> 
        /// <param name="noSketchGeometry">Whether or not to output simple sketch info without           geometry</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartStudiosGetFeaturesResponse200</returns>            
        public ApiRequest<PartStudiosGetFeaturesResponse200> GetFeatures (string wvmChar, string did, string wvm, string eid, string featureId, bool? noSketchGeometry, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetFeatures");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetFeatures");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetFeatures");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetFeatures");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/features";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (featureId != null) queryParams.Add("featureId", ApiClient.ParameterToString(featureId)); // query parameter
 if (noSketchGeometry != null) queryParams.Add("noSketchGeometry", ApiClient.ParameterToString(noSketchGeometry)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetFeaturesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Mass Properties Get the mass properties of a part studio or parts; parts must have density in order to have mass.                 For properties that come in sets of three, the first set is the calculated value, and the second                 and third are minimum and maximum possible values considering tolerance.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partId">IDs of the parts for which to retrieve mass properties (repeat query           param to add more than one, i.e. partId&#x3D;JHK&amp;partId&#x3D;JHD)</param> 
        /// <param name="massAsGroup">If true, specified parts will be evaluated as a single object           instead of individually</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartStudiosGetMassPropertiesResponse200</returns>            
        public ApiRequest<PartStudiosGetMassPropertiesResponse200> GetMassProperties (string wvmChar, string did, string wvm, string eid, string partId, bool? massAsGroup, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetMassProperties");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetMassProperties");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetMassProperties");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetMassProperties");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/massproperties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (partId != null) queryParams.Add("partId", ApiClient.ParameterToString(partId)); // query parameter
 if (massAsGroup != null) queryParams.Add("massAsGroup", ApiClient.ParameterToString(massAsGroup)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetMassPropertiesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Part Metadata Get metadata for the parts in the part studio
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partIds">Comma-separated list of part IDs for which to get part metadata (omit           to get part metadata for entire part studio)</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartStudiosGetMetadataResponse200</returns>            
        public ApiRequest<PartStudiosGetMetadataResponse200> GetMetadata (string wvmChar, string did, string wvm, string eid, string partIds, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetMetadata");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetMetadata");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetMetadata");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetMetadata");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (partIds != null) queryParams.Add("partIds", ApiClient.ParameterToString(partIds)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetMetadataResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Named Views Returns a map from view name to view data for the given element
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="skipPerspective">Whether views with a perspective projection should be omitted.</param> 
        /// <returns>PartStudiosGetNamedViewsResponse200</returns>            
        public ApiRequest<PartStudiosGetNamedViewsResponse200> GetNamedViews (string did, string eid, bool? skipPerspective)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetNamedViews");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetNamedViews");
            
    
            var path = "/partstudios/d/{did}/e/{eid}/namedViews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (skipPerspective != null) queryParams.Add("skipPerspective", ApiClient.ParameterToString(skipPerspective)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetNamedViewsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Shaded Views Get a shaded image rendering of a Part Studio
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="outputHeight">Output image height (in pixels)</param> 
        /// <param name="outputWidth">Output image width (in pixels)</param> 
        /// <param name="pixelSize">Height and width represented by each pixel (in meters). If the           value is 0, the display will be sized to fit the output image dimensions.</param> 
        /// <param name="edges">The treatment to be applied to edges in the display. Options are           show: show visible edges, hide: hide visible edges</param> 
        /// <param name="showAllParts">Whether or not all parts should be shown in the element,           regardless of user setting. If false, the visibility setting made by the user will be reflected in the           image. If true, all parts will be shown.</param> 
        /// <param name="includeSurfaces">Whether or not surfaces should be shown in the element.           It is applicable only when showAllParts is true. If false, surfaces will be excluded.           If true, all surfaces will be shown.</param> 
        /// <param name="useAntiAliasing">If true, an anti-aliasing factor will be used to smooth           model boundaries in the final image result. If false, the image will be rasterized at the given           resolution. Setting to true can have negative performance implications with respect to rendering time           and memory usage. If a high-resolution image is requested and anti-aliasing is turned on, the server           may not be able to fulfill the request.</param> 
        /// <param name="viewMatrix">12-number view matrix (comma-separated), or one of the following named views: top, bottom, front, back, left, right The 12 entries in the view matrix form three rows and four columns, which is a linear transformation applied to the model itself. The matrix&#39;s first three columns maps the coordinate axes of the model to the coordinate axes of the view, and the fourth column translates the origin (in meters). The view coordinates have x pointing right, y pointing up, and z pointing towards the viewer, while a front view of the model has x pointing right, y pointing away from the viewer, and z pointing up. For example, the identity matrix viewMatrix&#x3D;1,0,0,0,0,1,0,0,0,0,1,0 corresponds to the top view, and viewMatrix&#x3D;0.612,0.612,0,0,-0.354,0.354,0.707,0,0.707,-0.707,0.707,0 corresponds (approximately) to the isometric view. The first three columns of the view matrix should be orthonormal and have a positive determinant.  If this is not the case, view behavior may be undefined.</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartStudiosGetShadedViewsResponse200</returns>            
        public ApiRequest<PartStudiosGetShadedViewsResponse200> GetShadedViews (string wvmChar, string did, string wvm, string eid, decimal? outputHeight, decimal? outputWidth, decimal? pixelSize, string edges, bool? showAllParts, bool? includeSurfaces, bool? useAntiAliasing, string viewMatrix, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetShadedViews");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetShadedViews");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetShadedViews");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetShadedViews");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/shadedviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (outputHeight != null) queryParams.Add("outputHeight", ApiClient.ParameterToString(outputHeight)); // query parameter
 if (outputWidth != null) queryParams.Add("outputWidth", ApiClient.ParameterToString(outputWidth)); // query parameter
 if (pixelSize != null) queryParams.Add("pixelSize", ApiClient.ParameterToString(pixelSize)); // query parameter
 if (edges != null) queryParams.Add("edges", ApiClient.ParameterToString(edges)); // query parameter
 if (showAllParts != null) queryParams.Add("showAllParts", ApiClient.ParameterToString(showAllParts)); // query parameter
 if (includeSurfaces != null) queryParams.Add("includeSurfaces", ApiClient.ParameterToString(includeSurfaces)); // query parameter
 if (useAntiAliasing != null) queryParams.Add("useAntiAliasing", ApiClient.ParameterToString(useAntiAliasing)); // query parameter
 if (viewMatrix != null) queryParams.Add("viewMatrix", ApiClient.ParameterToString(viewMatrix)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetShadedViewsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Sketch Information Get information for sketches in a part studio
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="sketchId">ID of a sketch feature; repeat query param to add more than one. If no sketchId query     parameter is passed, all sketches in the part studio are returned.</param> 
        /// <param name="output3D">Whether or not to output with respect to global 3D coordinate system</param> 
        /// <param name="curvePoints">Whether or not to output start/quarter/mid/end points, start/end tangent vectors, and length of sketch curves</param> 
        /// <param name="includeGeometry">Whether or not to just output simple sketch info without geometry</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartStudiosGetSketchInfoResponse200</returns>            
        public ApiRequest<PartStudiosGetSketchInfoResponse200> GetSketchInfo (string wvmChar, string did, string wvm, string eid, string sketchId, bool? output3D, bool? curvePoints, bool? includeGeometry, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetSketchInfo");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetSketchInfo");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetSketchInfo");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetSketchInfo");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/sketches";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (sketchId != null) queryParams.Add("sketchId", ApiClient.ParameterToString(sketchId)); // query parameter
 if (output3D != null) queryParams.Add("output3D", ApiClient.ParameterToString(output3D)); // query parameter
 if (curvePoints != null) queryParams.Add("curvePoints", ApiClient.ParameterToString(curvePoints)); // query parameter
 if (includeGeometry != null) queryParams.Add("includeGeometry", ApiClient.ParameterToString(includeGeometry)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetSketchInfoResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Tessellated sketch entitites Get the tessellations of the sketch entities of a sketch in a part studio. The accuracy of the                 tessellation to exact geometry is controlled by the angleTolerance and chordTolerance parameters.                 The tessellation points are computed close enough so that neither the angle tolerance nor the                 chord tolerance are exceeded. For most parts, the angular tolerance is the most restrictive of                 the two default tolerances.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="sid">Sketch feature ID</param> 
        /// <param name="entityId">Sketch entity id to be tessellated. All entities in the sketch are           tessellated if none are provided.</param> 
        /// <param name="angleTolerance">Angle tolerance (in radians). This specifies the limit on the           sum of the angular deviations of a tessellation chord from the tangent vectors at two chord endpoints.           The specified value must be less than PI/2. This parameter currently has a default value of 0.087267           radians, but is subject to change.</param> 
        /// <param name="chordTolerance">Chord tolerance (in meters). This specifies the limit on the           maximum deviation of a tessellation chord from the true curve. This parameter currently has a default           value of 0.02 meters, but is subject to change.</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartStudiosGetTessellatedEntitiesResponse200</returns>            
        public ApiRequest<PartStudiosGetTessellatedEntitiesResponse200> GetTessellatedEntities (string wvmChar, string did, string wvm, string eid, string sid, string entityId, decimal? angleTolerance, decimal? chordTolerance, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetTessellatedEntities");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetTessellatedEntities");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetTessellatedEntities");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetTessellatedEntities");
            
            // verify the required parameter 'sid' is set
            if (sid == null) throw new ApiException(400, "Missing required parameter 'sid' when calling GetTessellatedEntities");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/sketches/{sid}/tessellatedentities";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "sid" + "}", ApiClient.ParameterToString(sid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (entityId != null) queryParams.Add("entityId", ApiClient.ParameterToString(entityId)); // query parameter
 if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance)); // query parameter
 if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetTessellatedEntitiesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Translation Formats Returns a list of the available formats to which this Part Studio can be translated
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="checkContent">Whether the current content or lack thereof should be        considered when determining the available formats. Empty part studios cannot be translated into any format.</param> 
        /// <returns>PartStudiosGetTranslationFormatsResponse200</returns>            
        public ApiRequest<PartStudiosGetTranslationFormatsResponse200> GetTranslationFormats (string did, string wid, string eid, bool? checkContent)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetTranslationFormats");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling GetTranslationFormats");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetTranslationFormats");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/translationformats";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wid" + "}", ApiClient.ParameterToString(wid));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (checkContent != null) queryParams.Add("checkContent", ApiClient.ParameterToString(checkContent)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosGetTranslationFormatsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Id Translations Translate a list of part, face, etc ids defined in a specific microversion of a document to a                 corresponding list of ids in the current microversion of a workspace of the document or other                 specific version/microversion. This will also allow converting between configurations, although a                 particular ID might not have an equivalent in another configuration.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosIdTranslationsResponse200</returns>            
        public ApiRequest<PartStudiosIdTranslationsResponse200> IdTranslations (string wvmChar, string did, string wvm, string eid, PartStudiosIdTranslationsBody body)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling IdTranslations");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling IdTranslations");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling IdTranslations");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling IdTranslations");
            
    
            var path = "/partstudios/d/{did}/{wvm_char}/{wvm}/e/{eid}/idtranslations";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter

            // make the HTTP request
            return new ApiRequest<PartStudiosIdTranslationsResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Update Configuration Update the configuration for a part studio. See the developer portal feature list                 help topic for additional information
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosUpdateConfigurationResponse200</returns>            
        public ApiRequest<PartStudiosUpdateConfigurationResponse200> UpdateConfiguration (string did, string wid, string eid, PartStudiosUpdateConfigurationBody body)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateConfiguration");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling UpdateConfiguration");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdateConfiguration");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/configuration";
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
            return new ApiRequest<PartStudiosUpdateConfigurationResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Update Feature Update an existing feature in the feature list for a part studio. See the developer portal                 feature list help topic for additional information
        /// </summary>
        /// <param name="fid">The id of the feature being updated.  This id should be URL encoded and must   match the featureId found in the serialized structure</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosUpdateFeatureResponse200</returns>            
        public ApiRequest<PartStudiosUpdateFeatureResponse200> UpdateFeature (string fid, string did, string wid, string eid, PartStudiosUpdateFeatureBody body)
        {
            
            // verify the required parameter 'fid' is set
            if (fid == null) throw new ApiException(400, "Missing required parameter 'fid' when calling UpdateFeature");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateFeature");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling UpdateFeature");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdateFeature");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/features/featureid/{fid}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "fid" + "}", ApiClient.ParameterToString(fid));
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
            return new ApiRequest<PartStudiosUpdateFeatureResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Update Features Update parameters of existing features in the feature list for a part studio. Multiple features                 may be updated simultaneously with a single call, allowing for faster regeneration. Only the                 parameters that are present in the passed features are updated. Existing parameters that are                 not included in the passed feature are left untouched. In addition, if the field                 updateSuppressionAttributes is set to true, the suppress and suppressionState values for the                 updated features are set from the passed feature objects. See the developer portal feature list                 help topic for additional information
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosUpdateFeaturesResponse200</returns>            
        public ApiRequest<PartStudiosUpdateFeaturesResponse200> UpdateFeatures (string did, string wid, string eid, PartStudiosUpdateFeaturesBody body)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateFeatures");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling UpdateFeatures");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdateFeatures");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/features/updates";
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
            return new ApiRequest<PartStudiosUpdateFeaturesResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Update Feature Rollback Move the rollback bar in the feature list for a part studio. See the developer portal                 feature list help topic for additional information
        /// </summary>
        /// <param name="did">Document ID</param> 
        /// <param name="wid">Workspace ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartStudiosUpdateRollbackResponse200</returns>            
        public ApiRequest<PartStudiosUpdateRollbackResponse200> UpdateRollback (string did, string wid, string eid, PartStudiosUpdateRollbackBody body)
        {
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateRollback");
            
            // verify the required parameter 'wid' is set
            if (wid == null) throw new ApiException(400, "Missing required parameter 'wid' when calling UpdateRollback");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdateRollback");
            
    
            var path = "/partstudios/d/{did}/w/{wid}/e/{eid}/features/rollback";
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
            return new ApiRequest<PartStudiosUpdateRollbackResponse200>(path, Method.POST, queryParams, postBody);
        }

    }
}
