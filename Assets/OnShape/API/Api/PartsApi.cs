using System;
using System.Collections.Generic;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
 
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class PartsApi 
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PartsApi"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public PartsApi(ApiClient apiClient)
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
        /// Update Part metadata Part metadata batch update
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <param name="editDescription">Description of the update (as appear in document history)</param> 
        /// <returns></returns>            
        public ApiRequest<PartsBatchUpdatePartMetadataBody> BatchUpdatePartMetadata (string wvmChar, string did, string wvm, PartsBatchUpdatePartMetadataBody body, string editDescription)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling BatchUpdatePartMetadata");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling BatchUpdatePartMetadata");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling BatchUpdatePartMetadata");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (editDescription != null) queryParams.Add("editDescription", ApiClient.ParameterToString(editDescription)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter
        

            // make the HTTP request
            return new ApiRequest<PartsBatchUpdatePartMetadataBody>(path, Method.POST, queryParams, postBody);

        }

        /// <summary>
        /// Export Part to Parasolid Export the part in text Parasolid format; returns a 307 redirect.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Part studio element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="version">Parasolid version</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>System.IO.Stream</returns>            
        public ApiRequest<System.IO.Stream> ExportParasolid (string wvmChar, string did, string wvm, string eid, string partid, decimal? version, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling ExportParasolid");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ExportParasolid");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling ExportParasolid");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ExportParasolid");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling ExportParasolid");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/parasolid";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (version != null) queryParams.Add("version", ApiClient.ParameterToString(version)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter
                                        
            return new ApiRequest<System.IO.Stream>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Export Part to STL Export the part in text or binary STL format; returns a 307 redirect.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Part studio element ID</param> 
        /// <param name="partid">Part ID</param> 
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
        public ApiRequest<System.IO.Stream> ExportStl (string wvmChar, string did, string wvm, string eid, string partid, bool? grouping, decimal? scale, string units, decimal? angleTolerance, decimal? chordTolerance, decimal? maxFacetWidth, decimal? minFacetWidth, string mode, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling ExportStl");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling ExportStl");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling ExportStl");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling ExportStl");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling ExportStl");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/stl";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
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
            return new ApiRequest<System.IO.Stream>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Get Sheet Metal Bend Table Get the bend table a sheet metal part.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <returns>PartsGetBendTableResponse200</returns>            
        public ApiRequest<PartsGetBendTableResponse200> GetBendTable (string wvmChar, string did, string wvm, string eid, string partid, string linkDocumentId)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetBendTable");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetBendTable");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetBendTable");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetBendTable");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetBendTable");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/sheetmetal/bendtable";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartsGetBendTableResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Body Details Get the body details of a part. All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartsGetBodyDetailsResponse200</returns>            
        public ApiRequest<PartsGetBodyDetailsResponse200> GetBodyDetails (string wvmChar, string did, string wvm, string eid, string partid, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetBodyDetails");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetBodyDetails");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetBodyDetails");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetBodyDetails");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetBodyDetails");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/bodydetails";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            // make the HTTP request
            return new ApiRequest<PartsGetBodyDetailsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Bounding Boxes Get the bounding box of a part. All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="includeHidden">Whether or not to include bounding boxes for hidden parts</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartsGetBoundingBoxesResponse200</returns>            
        public ApiRequest<PartsGetBoundingBoxesResponse200> GetBoundingBoxes (string wvmChar, string did, string wvm, string eid, string partid, bool? includeHidden, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetBoundingBoxes");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetBoundingBoxes");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetBoundingBoxes");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetBoundingBoxes");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetBoundingBoxes");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/boundingboxes";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (includeHidden != null) queryParams.Add("includeHidden", ApiClient.ParameterToString(includeHidden)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            return new ApiRequest<PartsGetBoundingBoxesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Tessellated Edges Get the tessellated edges of a part. The accuracy of the tessellation approximation to exact                 geometry is controlled by the angleTolerance and chordTolerance parameters. The tessellation                 points are computed close enough so that neither the angle tolerance nor the chord tolerance are                 exceeded. All coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="angleTolerance">Angle tolerance (in radians). This specifies the limit on the           sum of the angular deviations of a tessellation chord from the tangent vectors at two chord endpoints.           The specified value must be less than PI/2. This parameter currently has a default value chosen based           on the complexity of the parts being tessellated.</param> 
        /// <param name="chordTolerance">Chord tolerance (in meters). This specifies the limit on the           maximum deviation of a tessellation chord from the true edge. This parameter currently has a default           value chosen based on the size and complexity of the part being tessellated.</param> 
        /// <param name="edgeId">Edges to tessellate (repeat query param to add more than one, i.e.           edgeId&#x3D;JHK&amp;edgeId&#x3D;JHD)</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartsGetEdgesResponse200</returns>            
        public ApiRequest<PartsGetEdgesResponse200> GetEdges (string wvmChar, string did, string wvm, string eid, string partid, decimal? angleTolerance, decimal? chordTolerance, string edgeId, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetEdges");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetEdges");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetEdges");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetEdges");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetEdges");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/tessellatededges";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (angleTolerance != null) queryParams.Add("angleTolerance", ApiClient.ParameterToString(angleTolerance)); // query parameter
 if (chordTolerance != null) queryParams.Add("chordTolerance", ApiClient.ParameterToString(chordTolerance)); // query parameter
 if (edgeId != null) queryParams.Add("edgeId", ApiClient.ParameterToString(edgeId)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            return new ApiRequest<PartsGetEdgesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Tessellated Faces Get the tessellated faces of a part. The accuracy of the tessellation approximation to exact                 geometry is controlled by the angleTolerance, chordTolerance and maxFacetWidth parameters. The                 tessellation points are computed close enough so that none of these parameters are exceeded. All                 coordinates are in meters.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="angleTolerance">Angle tolerance (in radians). This specifies the limit on the           sum of the angular deviations of a tessellation chord from the tangent vectors at two chord endpoints.           The specified value must be less than PI/2. This parameter currently has a default value chosen based           on the complexity of the part being tessellated.</param> 
        /// <param name="chordTolerance">Chord tolerance (in meters). This specifies the limit on the           maximum deviation of a tessellation chord from the true surface/edge. This parameter currently has a           default value chosen based on the size and complexity of the parts being tessellated.</param> 
        /// <param name="maxFacetWidth">Max facet width. This specifies the limit on the size of any side           of a tessellation facet.</param> 
        /// <param name="outputVertexNormals">Output vertex normals</param> 
        /// <param name="outputFacetNormals">Output facet normals</param> 
        /// <param name="outputTextureCoordinates">Output texture coordinates</param> 
        /// <param name="outputIndexTable">Output index table</param> 
        /// <param name="faceId">IDs of the faces to tessellate (repeat query param to add more than one,           i.e. faceId&#x3D;JHK&amp;faceId&#x3D;JHD)</param> 
        /// <param name="outputErrorFaces">Whether or not to output faces that cause an error</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartsGetFacesResponse200</returns>            
        public ApiRequest<PartsGetFacesResponse200> GetFaces (string wvmChar, string did, string wvm, string eid, string partid, decimal? angleTolerance, decimal? chordTolerance, decimal? maxFacetWidth, bool? outputVertexNormals, bool? outputFacetNormals, bool? outputTextureCoordinates, bool? outputIndexTable, string faceId, bool? outputErrorFaces, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetFaces");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetFaces");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetFaces");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetFaces");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetFaces");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/tessellatedfaces";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
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
 if (outputErrorFaces != null) queryParams.Add("outputErrorFaces", ApiClient.ParameterToString(outputErrorFaces)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter

            return new ApiRequest<PartsGetFacesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Mass Properties Get the mass properties of a part; parts must have density in order to have mass. For properties                 that come in sets of three, the first set is the calculated value, and the second and third are                 minimum and maximum possible values considering tolerance.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="inferMetadataOwner">If the referenced part is a Standard Content part,           specifying a value of true causes the API to look for metadata owned by the owner of the referencing           linkDocument prior to calculating mass properties. If Standard Content metadata is found and it           contains a material assignment, the density from that material is applied to the mass properties           calculation.</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <returns>PartsGetMassPropertiesResponse200</returns>            
        public ApiRequest<PartsGetMassPropertiesResponse200> GetMassProperties (string wvmChar, string did, string wvm, string eid, string partid, bool? inferMetadataOwner, string linkDocumentId, string configuration)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetMassProperties");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetMassProperties");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetMassProperties");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetMassProperties");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetMassProperties");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/massproperties";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            return new ApiRequest<PartsGetMassPropertiesResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Metadata Get a part&#39;s metadata
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <param name="inferMetadataOwner">If the URL references a Standard Content part,       specifying a value of true causes the API to use the owner of the referencing linkDocument as the       metadata scope and the href of the returned part is modified to reflect this metadata scope. If not       explictly set or if set to false, the part metadata returned is the metadata defined internal to the       Standard Content document.</param> 
        /// <param name="includePropertyDefaults">If true, include metadata schema property       defaults in response</param> 
        /// <returns>PartsGetPartMetadataResponse200</returns>            
        public ApiRequest<PartsGetPartMetadataResponse200> GetPartMetadata (string wvmChar, string did, string wvm, string eid, string partid, string linkDocumentId, string configuration, bool? inferMetadataOwner, bool? includePropertyDefaults)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetPartMetadata");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetPartMetadata");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetPartMetadata");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetPartMetadata");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetPartMetadata");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter
 if (inferMetadataOwner != null) queryParams.Add("inferMetadataOwner", ApiClient.ParameterToString(inferMetadataOwner)); // query parameter
 if (includePropertyDefaults != null) queryParams.Add("includePropertyDefaults", ApiClient.ParameterToString(includePropertyDefaults)); // query parameter

            return new ApiRequest<PartsGetPartMetadataResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Parts Get list of parts
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="withThumbnails">Whether or not to include thumbnails (not supported for           microversion)</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="includePropertyDefaults">If true, include metadata schema property       defaults in response</param> 
        /// <returns>List&lt;Part&gt;</returns>            
        public ApiRequest<List<Part>> GetParts (string wvmChar, string did, string wvm, bool? withThumbnails, string linkDocumentId, bool? includePropertyDefaults)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetParts");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetParts");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetParts");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (withThumbnails != null) queryParams.Add("withThumbnails", ApiClient.ParameterToString(withThumbnails)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (includePropertyDefaults != null) queryParams.Add("includePropertyDefaults", ApiClient.ParameterToString(includePropertyDefaults)); // query parameter

            return new ApiRequest<List<Part>>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Parts In Part Studio Get list of parts in a part studio. An error is returned if the specified element is not a part                 studio. Surface, wire, and mesh parts are not returned for a version but are included for a                 workspace or microversion.
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Part studio element ID</param> 
        /// <param name="withThumbnails">Whether or not to include thumbnails (not supported for           microversion)</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="includePropertyDefaults">If true, include metadata schema property       defaults in response</param> 
        /// <returns>List&lt;Part&gt;</returns>            
        public ApiRequest<List<Part>> GetPartsInPartstudio (string wvmChar, string did, string wvm, string eid, bool? withThumbnails, string linkDocumentId, bool? includePropertyDefaults)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetPartsInPartstudio");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetPartsInPartstudio");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetPartsInPartstudio");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetPartsInPartstudio");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}";
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
    
             if (withThumbnails != null) queryParams.Add("withThumbnails", ApiClient.ParameterToString(withThumbnails)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (includePropertyDefaults != null) queryParams.Add("includePropertyDefaults", ApiClient.ParameterToString(includePropertyDefaults)); // query parameter

            return new ApiRequest<List<Part>>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Shaded views Get a shaded image rendering of a part
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="outputHeight">Output image height (in pixels)</param> 
        /// <param name="outputWidth">Output image width (in pixels)</param> 
        /// <param name="pixelSize">Height and width represented by each pixel (in meters). If the           value is 0, the display will be sized to fit the output image dimensions.</param> 
        /// <param name="edges">The treatment to be applied to edges in the display. Options are           show: show visible edges, hide: hide visible edges</param> 
        /// <param name="useAntiAliasing">If true, an anti-aliasing factor will be used to smooth           model boundaries in the final image result. If false, the image will be rasterized at the given           resolution. Setting to true can have negative performance implications with respect to rendering time           and memory usage. If a high-resolution image is requested and anti-aliasing is turned on, the server           may not be able to fulfill the request.</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <param name="viewMatrix">12-number view matrix (comma-separated), or one of the following named views: top, bottom, front, back, left, right The 12 entries in the view matrix form three rows and four columns, which is a linear transformation applied to the model itself. The matrix&#39;s first three columns maps the coordinate axes of the model to the coordinate axes of the view, and the fourth column translates the origin (in meters). The view coordinates have x pointing right, y pointing up, and z pointing towards the viewer, while a front view of the model has x pointing right, y pointing away from the viewer, and z pointing up. For example, the identity matrix viewMatrix&#x3D;1,0,0,0,0,1,0,0,0,0,1,0 corresponds to the top view, and viewMatrix&#x3D;0.612,0.612,0,0,-0.354,0.354,0.707,0,0.707,-0.707,0.707,0 corresponds (approximately) to the isometric view. The first three columns of the view matrix should be orthonormal and have a positive determinant.  If this is not the case, view behavior may be undefined.</param> 
        /// <returns>PartsGetShadedViewsResponse200</returns>            
        public ApiRequest<PartsGetShadedViewsResponse200> GetShadedViews (string wvmChar, string did, string wvm, string eid, string partid, decimal? outputHeight, decimal? outputWidth, decimal? pixelSize, string edges, bool? useAntiAliasing, string linkDocumentId, string configuration, string viewMatrix)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling GetShadedViews");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetShadedViews");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling GetShadedViews");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetShadedViews");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetShadedViews");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/shadedviews";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (outputHeight != null) queryParams.Add("outputHeight", ApiClient.ParameterToString(outputHeight)); // query parameter
 if (outputWidth != null) queryParams.Add("outputWidth", ApiClient.ParameterToString(outputWidth)); // query parameter
 if (pixelSize != null) queryParams.Add("pixelSize", ApiClient.ParameterToString(pixelSize)); // query parameter
 if (edges != null) queryParams.Add("edges", ApiClient.ParameterToString(edges)); // query parameter
 if (useAntiAliasing != null) queryParams.Add("useAntiAliasing", ApiClient.ParameterToString(useAntiAliasing)); // query parameter
 if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter
 if (viewMatrix != null) queryParams.Add("viewMatrix", ApiClient.ParameterToString(viewMatrix)); // query parameter

            return new ApiRequest<PartsGetShadedViewsResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Get Standard Content Metadata Get metadata for a standard content part in the context of a user or company
        /// </summary>
        /// <param name="cuChar">One of c or u corresponding to whether a company or user was entered.</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="vid">Version ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="oid">Company (c) or User (u) ID of metadata owner</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="configuration">Configuration string</param> 
        /// <param name="includePropertyDefaults">If true, include metadata schema property       defaults in response</param> 
        /// <returns>PartsGetStandardContentPartMetadataResponse200</returns>            
        public ApiRequest<PartsGetStandardContentPartMetadataResponse200> GetStandardContentPartMetadata (string cuChar, string partid, string did, string vid, string eid, string oid, string linkDocumentId, string configuration, bool? includePropertyDefaults)
        {
            
            // verify the required parameter 'cuChar' is set
            if (cuChar == null) throw new ApiException(400, "Missing required parameter 'cuChar' when calling GetStandardContentPartMetadata");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling GetStandardContentPartMetadata");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling GetStandardContentPartMetadata");
            
            // verify the required parameter 'vid' is set
            if (vid == null) throw new ApiException(400, "Missing required parameter 'vid' when calling GetStandardContentPartMetadata");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling GetStandardContentPartMetadata");
            
            // verify the required parameter 'oid' is set
            if (oid == null) throw new ApiException(400, "Missing required parameter 'oid' when calling GetStandardContentPartMetadata");
            
    
            var path = "/parts/standardcontent/d/{did}/v/{vid}/e/{eid}/{cu_char}/{oid}/partid/{partid}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "cu_char" + "}", ApiClient.ParameterToString(cuChar));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "vid" + "}", ApiClient.ParameterToString(vid));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "oid" + "}", ApiClient.ParameterToString(oid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (configuration != null) queryParams.Add("configuration", ApiClient.ParameterToString(configuration)); // query parameter
 if (includePropertyDefaults != null) queryParams.Add("includePropertyDefaults", ApiClient.ParameterToString(includePropertyDefaults)); // query parameter

            return new ApiRequest<PartsGetStandardContentPartMetadataResponse200>(path, Method.GET, queryParams, postBody);
        }

        /// <summary>
        /// Update Metadata Update a part&#39;s metadata
        /// </summary>
        /// <param name="wvmChar">One of w or v or m corresponding to whether a workspace or version or microversion was entered.</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="wvm">Workspace (w), Version (v) or Microversion (m) ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <returns>PartsUpdatePartMetadataResponse200</returns>            
        public ApiRequest<PartsUpdatePartMetadataResponse200> UpdatePartMetadata (string wvmChar, string did, string wvm, string eid, string partid, PartsUpdatePartMetadataBody body)
        {
            
            // verify the required parameter 'wvmChar' is set
            if (wvmChar == null) throw new ApiException(400, "Missing required parameter 'wvmChar' when calling UpdatePartMetadata");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdatePartMetadata");
            
            // verify the required parameter 'wvm' is set
            if (wvm == null) throw new ApiException(400, "Missing required parameter 'wvm' when calling UpdatePartMetadata");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdatePartMetadata");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling UpdatePartMetadata");
            
    
            var path = "/parts/d/{did}/{wvm_char}/{wvm}/e/{eid}/partid/{partid}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "wvm_char" + "}", ApiClient.ParameterToString(wvmChar));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "wvm" + "}", ApiClient.ParameterToString(wvm));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
                                                postBody = ApiClient.Serialize(body); // http body (model) parameter

            return new ApiRequest<PartsUpdatePartMetadataResponse200>(path, Method.POST, queryParams, postBody);
        }

        /// <summary>
        /// Update Standard Content Metadata Update metadata for a standard content part in the context of a company or user
        /// </summary>
        /// <param name="cuChar">One of c or u corresponding to whether a company or user was entered.</param> 
        /// <param name="partid">Part ID</param> 
        /// <param name="did">Document ID</param> 
        /// <param name="vid">Version ID</param> 
        /// <param name="eid">Element ID</param> 
        /// <param name="oid">Company (c) or User (u) ID of metadata owner</param> 
        /// <param name="body">The JSON request body.</param> 
        /// <param name="linkDocumentId">Id of document that links to the document being accessed.     This may provide additional access rights to the document. Allowed only with version (v) path parameter.</param> 
        /// <param name="includePropertyDefaults">If true, include metadata schema property       defaults in response</param> 
        /// <returns>PartsUpdateStandardContentPartMetadataResponse200</returns>            
        public ApiRequest<PartsUpdateStandardContentPartMetadataResponse200> UpdateStandardContentPartMetadata (string cuChar, string partid, string did, string vid, string eid, string oid, PartsUpdateStandardContentPartMetadataBody body, string linkDocumentId, bool? includePropertyDefaults)
        {
            
            // verify the required parameter 'cuChar' is set
            if (cuChar == null) throw new ApiException(400, "Missing required parameter 'cuChar' when calling UpdateStandardContentPartMetadata");
            
            // verify the required parameter 'partid' is set
            if (partid == null) throw new ApiException(400, "Missing required parameter 'partid' when calling UpdateStandardContentPartMetadata");
            
            // verify the required parameter 'did' is set
            if (did == null) throw new ApiException(400, "Missing required parameter 'did' when calling UpdateStandardContentPartMetadata");
            
            // verify the required parameter 'vid' is set
            if (vid == null) throw new ApiException(400, "Missing required parameter 'vid' when calling UpdateStandardContentPartMetadata");
            
            // verify the required parameter 'eid' is set
            if (eid == null) throw new ApiException(400, "Missing required parameter 'eid' when calling UpdateStandardContentPartMetadata");
            
            // verify the required parameter 'oid' is set
            if (oid == null) throw new ApiException(400, "Missing required parameter 'oid' when calling UpdateStandardContentPartMetadata");
            
    
            var path = "/parts/standardcontent/d/{did}/v/{vid}/e/{eid}/{cu_char}/{oid}/partid/{partid}/metadata";
            path = path.Replace("{format}", "json");
            path = path.Replace("{" + "cu_char" + "}", ApiClient.ParameterToString(cuChar));
path = path.Replace("{" + "partid" + "}", ApiClient.ParameterToString(partid));
path = path.Replace("{" + "did" + "}", ApiClient.ParameterToString(did));
path = path.Replace("{" + "vid" + "}", ApiClient.ParameterToString(vid));
path = path.Replace("{" + "eid" + "}", ApiClient.ParameterToString(eid));
path = path.Replace("{" + "oid" + "}", ApiClient.ParameterToString(oid));
    
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
             if (linkDocumentId != null) queryParams.Add("linkDocumentId", ApiClient.ParameterToString(linkDocumentId)); // query parameter
 if (includePropertyDefaults != null) queryParams.Add("includePropertyDefaults", ApiClient.ParameterToString(includePropertyDefaults)); // query parameter
                                    postBody = ApiClient.Serialize(body); // http body (model) parameter

            return new ApiRequest<PartsUpdateStandardContentPartMetadataResponse200>(path, Method.POST, queryParams, postBody);
        }

    }
}
