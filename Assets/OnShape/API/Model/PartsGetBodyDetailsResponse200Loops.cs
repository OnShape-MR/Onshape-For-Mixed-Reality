using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual loop
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Loops {
    /// <summary>
    /// Type of a loop
    /// </summary>
    /// <value>Type of a loop</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Coedges of a loop
    /// </summary>
    /// <value>Coedges of a loop</value>
    [DataMember(Name="coedges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "coedges")]
    public List<PartsGetBodyDetailsResponse200Coedges> Coedges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Loops {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Coedges: ").Append(Coedges).Append("\n");
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
