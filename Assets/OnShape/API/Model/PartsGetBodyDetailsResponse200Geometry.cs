using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Edge geometry
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Geometry {
    /// <summary>
    /// Start vector
    /// </summary>
    /// <value>Start vector</value>
    [DataMember(Name="startVector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startVector")]
    public List<decimal?> StartVector { get; set; }

    /// <summary>
    /// End point
    /// </summary>
    /// <value>End point</value>
    [DataMember(Name="endPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endPoint")]
    public List<decimal?> EndPoint { get; set; }

    /// <summary>
    /// Midpoint
    /// </summary>
    /// <value>Midpoint</value>
    [DataMember(Name="midPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "midPoint")]
    public List<decimal?> MidPoint { get; set; }

    /// <summary>
    /// Edge length
    /// </summary>
    /// <value>Edge length</value>
    [DataMember(Name="length", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "length")]
    public decimal? Length { get; set; }

    /// <summary>
    /// Quarter point
    /// </summary>
    /// <value>Quarter point</value>
    [DataMember(Name="quarterPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quarterPoint")]
    public List<decimal?> QuarterPoint { get; set; }

    /// <summary>
    /// Start point
    /// </summary>
    /// <value>Start point</value>
    [DataMember(Name="startPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startPoint")]
    public List<decimal?> StartPoint { get; set; }

    /// <summary>
    /// End vector
    /// </summary>
    /// <value>End vector</value>
    [DataMember(Name="endVector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endVector")]
    public List<decimal?> EndVector { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Geometry {\n");
      sb.Append("  StartVector: ").Append(StartVector).Append("\n");
      sb.Append("  EndPoint: ").Append(EndPoint).Append("\n");
      sb.Append("  MidPoint: ").Append(MidPoint).Append("\n");
      sb.Append("  Length: ").Append(Length).Append("\n");
      sb.Append("  QuarterPoint: ").Append(QuarterPoint).Append("\n");
      sb.Append("  StartPoint: ").Append(StartPoint).Append("\n");
      sb.Append("  EndVector: ").Append(EndVector).Append("\n");
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
