using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Part appearance (Appearance can only be modified in workspace)
  /// </summary>
  [DataContract]
  public class PartsBatchUpdatePartMetadataBodyAppearance {
    /// <summary>
    /// Part opacity
    /// </summary>
    /// <value>Part opacity</value>
    [DataMember(Name="opacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opacity")]
    public decimal? Opacity { get; set; }

    /// <summary>
    /// Gets or Sets Color
    /// </summary>
    [DataMember(Name="color", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "color")]
    public PartAppearanceColor Color { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsBatchUpdatePartMetadataBodyAppearance {\n");
      sb.Append("  Opacity: ").Append(Opacity).Append("\n");
      sb.Append("  Color: ").Append(Color).Append("\n");
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
