using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Part color info
  /// </summary>
  [DataContract]
  public class PartsUpdatePartMetadataResponse200AppearanceColor {
    /// <summary>
    /// Blue RGB value
    /// </summary>
    /// <value>Blue RGB value</value>
    [DataMember(Name="blue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blue")]
    public Object Blue { get; set; }

    /// <summary>
    /// Green RGB value
    /// </summary>
    /// <value>Green RGB value</value>
    [DataMember(Name="green", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "green")]
    public Object Green { get; set; }

    /// <summary>
    /// Red RGB value
    /// </summary>
    /// <value>Red RGB value</value>
    [DataMember(Name="red", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "red")]
    public Object Red { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsUpdatePartMetadataResponse200AppearanceColor {\n");
      sb.Append("  Blue: ").Append(Blue).Append("\n");
      sb.Append("  Green: ").Append(Green).Append("\n");
      sb.Append("  Red: ").Append(Red).Append("\n");
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
