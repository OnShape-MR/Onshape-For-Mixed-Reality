using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Part appearance info
  /// </summary>
  [DataContract]
  public class PartsUpdatePartMetadataResponse200Appearance {
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
    public PartsUpdatePartMetadataResponse200AppearanceColor Color { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsUpdatePartMetadataResponse200Appearance {\n");
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
