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
  public class PartStudiosGetBoundingBoxesResponse200 {
    /// <summary>
    /// highest Y point
    /// </summary>
    /// <value>highest Y point</value>
    [DataMember(Name="highY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highY")]
    public decimal? HighY { get; set; }

    /// <summary>
    /// highest X point
    /// </summary>
    /// <value>highest X point</value>
    [DataMember(Name="highX", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highX")]
    public decimal? HighX { get; set; }

    /// <summary>
    /// highest Z point
    /// </summary>
    /// <value>highest Z point</value>
    [DataMember(Name="highZ", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "highZ")]
    public decimal? HighZ { get; set; }

    /// <summary>
    /// lowest Z point
    /// </summary>
    /// <value>lowest Z point</value>
    [DataMember(Name="lowZ", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowZ")]
    public decimal? LowZ { get; set; }

    /// <summary>
    /// lowest X point
    /// </summary>
    /// <value>lowest X point</value>
    [DataMember(Name="lowX", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowX")]
    public decimal? LowX { get; set; }

    /// <summary>
    /// lowest Y point
    /// </summary>
    /// <value>lowest Y point</value>
    [DataMember(Name="lowY", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lowY")]
    public decimal? LowY { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetBoundingBoxesResponse200 {\n");
      sb.Append("  HighY: ").Append(HighY).Append("\n");
      sb.Append("  HighX: ").Append(HighX).Append("\n");
      sb.Append("  HighZ: ").Append(HighZ).Append("\n");
      sb.Append("  LowZ: ").Append(LowZ).Append("\n");
      sb.Append("  LowX: ").Append(LowX).Append("\n");
      sb.Append("  LowY: ").Append(LowY).Append("\n");
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
