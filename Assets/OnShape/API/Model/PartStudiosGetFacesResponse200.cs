using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class PartStudiosGetFacesResponse200 {
    /// <summary>
    /// Array of information for each part
    /// </summary>
    /// <value>Array of information for each part</value>
    [DataMember(Name="parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parts")]
    public List<PartStudiosGetFacesResponse200Parts> Parts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFacesResponse200 {\n");
      sb.Append("  Parts: ").Append(Parts).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}

    [Serializable]
    public class PartStudiosGetTesseletedFaceResponse200
    {
        public float[][] facetPoints;

        public PartBody[] bodies;
    }

    public class PartBody
    {
        public string id;
        public string bodyType;
        public PartFace[] faces;
    }

    public class PartFace
    {
        public string id;
        public PartFacet[] facets;
    }

    public class PartFacet
    {
        public float[][] vertexNormals;
        public int[] indices;
    }
}
