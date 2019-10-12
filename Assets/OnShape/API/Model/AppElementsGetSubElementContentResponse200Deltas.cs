using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single delta-content entry
  /// </summary>
  [DataContract]
  public class AppElementsGetSubElementContentResponse200Deltas {
    /// <summary>
    /// A single content delta, in Base-64 encodding
    /// </summary>
    /// <value>A single content delta, in Base-64 encodding</value>
    [DataMember(Name="delta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delta")]
    public string Delta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsGetSubElementContentResponse200Deltas {\n");
      sb.Append("  Delta: ").Append(Delta).Append("\n");
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
