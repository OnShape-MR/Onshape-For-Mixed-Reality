using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual facet
  /// </summary>
  [DataContract]
  public class PartStudiosGetFacesResponse200Facets {
    /// <summary>
    /// Normal     vectors to face surface at the corresponding facet vertices (Only output if query param \"outputVertexNormals\"     is true).
    /// </summary>
    /// <value>Normal     vectors to face surface at the corresponding facet vertices (Only output if query param \"outputVertexNormals\"     is true).</value>
    [DataMember(Name="vertexNormals", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vertexNormals")]
    public List<List<decimal?>> VertexNormals { get; set; }

    /// <summary>
    /// Texture     coordinates of a facet (Only output if query param \"outputTextureCoordinates\" is true)
    /// </summary>
    /// <value>Texture     coordinates of a facet (Only output if query param \"outputTextureCoordinates\" is true)</value>
    [DataMember(Name="textureCoordinates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textureCoordinates")]
    public List<decimal?> TextureCoordinates { get; set; }

    /// <summary>
    /// Unit normal vector     for the facet
    /// </summary>
    /// <value>Unit normal vector     for the facet</value>
    [DataMember(Name="normal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normal")]
    public List<decimal?> Normal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFacesResponse200Facets {\n");
      sb.Append("  VertexNormals: ").Append(VertexNormals).Append("\n");
      sb.Append("  TextureCoordinates: ").Append(TextureCoordinates).Append("\n");
      sb.Append("  Normal: ").Append(Normal).Append("\n");
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
}
