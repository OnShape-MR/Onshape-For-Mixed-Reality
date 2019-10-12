using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// One of the principal axes
  /// </summary>
  [DataContract]
  public class BodyPrincipalAxes {
    /// <summary>
    /// y coordinate of principal axis
    /// </summary>
    /// <value>y coordinate of principal axis</value>
    [DataMember(Name="y", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "y")]
    public decimal? Y { get; set; }

    /// <summary>
    /// x coordinate of principal axis
    /// </summary>
    /// <value>x coordinate of principal axis</value>
    [DataMember(Name="x", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "x")]
    public decimal? X { get; set; }

    /// <summary>
    /// z coordinate of principal axis
    /// </summary>
    /// <value>z coordinate of principal axis</value>
    [DataMember(Name="z", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "z")]
    public decimal? Z { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BodyPrincipalAxes {\n");
      sb.Append("  Y: ").Append(Y).Append("\n");
      sb.Append("  X: ").Append(X).Append("\n");
      sb.Append("  Z: ").Append(Z).Append("\n");
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
