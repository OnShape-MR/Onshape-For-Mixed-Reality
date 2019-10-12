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
  public class PartsGetMassPropertiesResponse200 {
    /// <summary>
    /// Current microversion
    /// </summary>
    /// <value>Current microversion</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Object containing parts with mass properties, with the keys being the part             ID or \"-all-\" for a set of parts considered together
    /// </summary>
    /// <value>Object containing parts with mass properties, with the keys being the part             ID or \"-all-\" for a set of parts considered together</value>
    [DataMember(Name="bodies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bodies")]
    public Dictionary<string, Body> Bodies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetMassPropertiesResponse200 {\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  Bodies: ").Append(Bodies).Append("\n");
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
