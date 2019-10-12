using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Part appearance
  /// </summary>
  [DataContract]
  public class PartAppearance {
    /// <summary>
    /// Part opacity
    /// </summary>
    /// <value>Part opacity</value>
    [DataMember(Name="opacity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "opacity")]
    public decimal? Opacity { get; set; }

    /// <summary>
    /// Whether the appearance was set by the user or             generated by Onshape
    /// </summary>
    /// <value>Whether the appearance was set by the user or             generated by Onshape</value>
    [DataMember(Name="isGenerated", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isGenerated")]
    public bool? IsGenerated { get; set; }

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
      sb.Append("class PartAppearance {\n");
      sb.Append("  Opacity: ").Append(Opacity).Append("\n");
      sb.Append("  IsGenerated: ").Append(IsGenerated).Append("\n");
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
