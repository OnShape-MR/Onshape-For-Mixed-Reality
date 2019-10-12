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
  public class ThumbnailsSetApplicationElementThumbnailBody {
    /// <summary>
    /// List of thumbnails corresponding to an element
    /// </summary>
    /// <value>List of thumbnails corresponding to an element</value>
    [DataMember(Name="thumbnails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnails")]
    public List<ThumbnailsSetApplicationElementThumbnailBodyThumbnails> Thumbnails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ThumbnailsSetApplicationElementThumbnailBody {\n");
      sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
