using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single configuration parameter
  /// </summary>
  [DataContract]
  public class ElementsEncodeConfigurationBodyParameters {
    /// <summary>
    /// The value of this configuration parameter
    /// </summary>
    /// <value>The value of this configuration parameter</value>
    [DataMember(Name="parameterValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterValue")]
    public string ParameterValue { get; set; }

    /// <summary>
    /// The ID of this configuration parameter
    /// </summary>
    /// <value>The ID of this configuration parameter</value>
    [DataMember(Name="parameterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterId")]
    public string ParameterId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementsEncodeConfigurationBodyParameters {\n");
      sb.Append("  ParameterValue: ").Append(ParameterValue).Append("\n");
      sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
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
