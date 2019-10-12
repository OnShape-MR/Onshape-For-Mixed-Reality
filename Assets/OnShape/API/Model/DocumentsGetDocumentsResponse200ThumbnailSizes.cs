using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A thumbnail size description
  /// </summary>
  [DataContract]
  public class DocumentsGetDocumentsResponse200ThumbnailSizes {
    /// <summary>
    /// Reserved for future use
    /// </summary>
    /// <value>Reserved for future use</value>
    [DataMember(Name="viewOrientation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewOrientation")]
    public string ViewOrientation { get; set; }

    /// <summary>
    /// Reserved for future use
    /// </summary>
    /// <value>Reserved for future use</value>
    [DataMember(Name="renderMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "renderMode")]
    public string RenderMode { get; set; }

    /// <summary>
    /// A URI to the thumbnail
    /// </summary>
    /// <value>A URI to the thumbnail</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// The image mediaType
    /// </summary>
    /// <value>The image mediaType</value>
    [DataMember(Name="mediaType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mediaType")]
    public string MediaType { get; set; }

    /// <summary>
    /// A size description string (e.g. 300x300)
    /// </summary>
    /// <value>A size description string (e.g. 300x300)</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public string Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetDocumentsResponse200ThumbnailSizes {\n");
      sb.Append("  ViewOrientation: ").Append(ViewOrientation).Append("\n");
      sb.Append("  RenderMode: ").Append(RenderMode).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  MediaType: ").Append(MediaType).Append("\n");
      sb.Append("  Size: ").Append(Size).Append("\n");
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
