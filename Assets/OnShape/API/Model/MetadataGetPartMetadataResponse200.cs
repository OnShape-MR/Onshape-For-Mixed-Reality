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
  public class MetadataGetPartMetadataResponse200 {
    /// <summary>
    /// Part id
    /// </summary>
    /// <value>Part id</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Part type
    /// </summary>
    /// <value>Part type</value>
    [DataMember(Name="partType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partType")]
    public string PartType { get; set; }

    /// <summary>
    /// Part properties
    /// </summary>
    /// <value>Part properties</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<Object> Properties { get; set; }

    /// <summary>
    /// URI of Part metadata
    /// </summary>
    /// <value>URI of Part metadata</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// True if part is a mesh
    /// </summary>
    /// <value>True if part is a mesh</value>
    [DataMember(Name="isMesh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isMesh")]
    public bool? IsMesh { get; set; }

    /// <summary>
    /// Part's thumbnail
    /// </summary>
    /// <value>Part's thumbnail</value>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public Object Thumbnail { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataGetPartMetadataResponse200 {\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  PartType: ").Append(PartType).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  IsMesh: ").Append(IsMesh).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
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
