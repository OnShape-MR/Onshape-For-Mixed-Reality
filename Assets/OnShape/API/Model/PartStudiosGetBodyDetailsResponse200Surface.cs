using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Face surface info
  /// </summary>
  [DataContract]
  public class PartStudiosGetBodyDetailsResponse200Surface {
    /// <summary>
    /// Surface origin
    /// </summary>
    /// <value>Surface origin</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public List<decimal?> Origin { get; set; }

    /// <summary>
    /// Surface type - this can be one of \"cone\",     \"cylinder\", \"plane\", \"sphere\", \"revolved\", \"extruded\", \"torus\", \"other\"
    /// </summary>
    /// <value>Surface type - this can be one of \"cone\",     \"cylinder\", \"plane\", \"sphere\", \"revolved\", \"extruded\", \"torus\", \"other\"</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Normalized surface info
    /// </summary>
    /// <value>Normalized surface info</value>
    [DataMember(Name="normal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normal")]
    public List<decimal?> Normal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetBodyDetailsResponse200Surface {\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Normal: ").Append(Normal).Append("\n");
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
