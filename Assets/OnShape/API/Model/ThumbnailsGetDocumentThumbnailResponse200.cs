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
  public class ThumbnailsGetDocumentThumbnailResponse200 {
    /// <summary>
    /// The base URI for accessing these thumbnails
    /// </summary>
    /// <value>The base URI for accessing these thumbnails</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Thumbnail Id
    /// </summary>
    /// <value>Thumbnail Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// List of thumbnails in available sizes
    /// </summary>
    /// <value>List of thumbnails in available sizes</value>
    [DataMember(Name="sizes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizes")]
    public List<ThumbnailsGetDocumentThumbnailResponse200Sizes> Sizes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThumbnailsGetDocumentThumbnailResponse200 {\n");
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
