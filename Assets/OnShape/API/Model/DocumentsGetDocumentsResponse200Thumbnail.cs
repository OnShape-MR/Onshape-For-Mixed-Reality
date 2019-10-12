using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Thumbnail information
  /// </summary>
  [DataContract]
  public class DocumentsGetDocumentsResponse200Thumbnail {
    /// <summary>
    /// Thumbnail URL
    /// </summary>
    /// <value>Thumbnail URL</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Thumbnail id
    /// </summary>
    /// <value>Thumbnail id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Thumbnail sizes
    /// </summary>
    /// <value>Thumbnail sizes</value>
    [DataMember(Name="sizes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizes")]
    public List<DocumentsGetDocumentsResponse200ThumbnailSizes> Sizes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetDocumentsResponse200Thumbnail {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Sizes: ").Append(Sizes).Append("\n");
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
