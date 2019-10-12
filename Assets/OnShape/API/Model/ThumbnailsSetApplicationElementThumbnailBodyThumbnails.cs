using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An individual thumbnail
  /// </summary>
  [DataContract]
  public class ThumbnailsSetApplicationElementThumbnailBodyThumbnails {
    /// <summary>
    /// Base-64 encoded image string.
    /// </summary>
    /// <value>Base-64 encoded image string.</value>
    [DataMember(Name="base64EncodedImage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "base64EncodedImage")]
    public string Base64EncodedImage { get; set; }

    /// <summary>
    /// An optional description of the image.
    /// </summary>
    /// <value>An optional description of the image.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The height of the image being supplied. Suggested minimum is 600 pixels.
    /// </summary>
    /// <value>The height of the image being supplied. Suggested minimum is 600 pixels.</value>
    [DataMember(Name="imageHeight", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageHeight")]
    public decimal? ImageHeight { get; set; }

    /// <summary>
    /// A per element unique identifier, which is consistent across document versions and microversions.
    /// </summary>
    /// <value>A per element unique identifier, which is consistent across document versions and microversions.</value>
    [DataMember(Name="uniqueId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "uniqueId")]
    public string UniqueId { get; set; }

    /// <summary>
    /// The width of the image being supplied. Suggested minimum is 600 pixels.
    /// </summary>
    /// <value>The width of the image being supplied. Suggested minimum is 600 pixels.</value>
    [DataMember(Name="imageWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imageWidth")]
    public decimal? ImageWidth { get; set; }

    /// <summary>
    /// If true, this image is used as the element image. Only one thumbnail can be designated as the primary thumbnail.
    /// </summary>
    /// <value>If true, this image is used as the element image. Only one thumbnail can be designated as the primary thumbnail.</value>
    [DataMember(Name="isPrimary", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPrimary")]
    public bool? IsPrimary { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThumbnailsSetApplicationElementThumbnailBodyThumbnails {\n");
      sb.Append("  Base64EncodedImage: ").Append(Base64EncodedImage).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  ImageHeight: ").Append(ImageHeight).Append("\n");
      sb.Append("  UniqueId: ").Append(UniqueId).Append("\n");
      sb.Append("  ImageWidth: ").Append(ImageWidth).Append("\n");
      sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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
