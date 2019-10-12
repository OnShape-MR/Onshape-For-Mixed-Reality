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
  public class ThumbnailsGetDocumentThumbnailResponse200Sizes {
    /// <summary>
    /// View orientation at which thumbnail is rendered, example trimetric
    /// </summary>
    /// <value>View orientation at which thumbnail is rendered, example trimetric</value>
    [DataMember(Name="viewOrientation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewOrientation")]
    public string ViewOrientation { get; set; }

    /// <summary>
    /// URI for thumbnail
    /// </summary>
    /// <value>URI for thumbnail</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Media type for thumbnail, typically image/png
    /// </summary>
    /// <value>Media type for thumbnail, typically image/png</value>
    [DataMember(Name="mediaType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mediaType")]
    public string MediaType { get; set; }

    /// <summary>
    /// Size o this thumbnail, typically one of 70x40, 300x170, 300x300, or 600x340
    /// </summary>
    /// <value>Size o this thumbnail, typically one of 70x40, 300x170, 300x300, or 600x340</value>
    [DataMember(Name="size", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "size")]
    public string Size { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThumbnailsGetDocumentThumbnailResponse200Sizes {\n");
      sb.Append("  ViewOrientation: ").Append(ViewOrientation).Append("\n");
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
