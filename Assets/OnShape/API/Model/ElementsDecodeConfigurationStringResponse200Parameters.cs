using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single decoded parameter
  /// </summary>
  [DataContract]
  public class ElementsDecodeConfigurationStringResponse200Parameters {
    /// <summary>
    /// The parameter value
    /// </summary>
    /// <value>The parameter value</value>
    [DataMember(Name="parameterValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterValue")]
    public string ParameterValue { get; set; }

    /// <summary>
    /// The id of the parameter
    /// </summary>
    /// <value>The id of the parameter</value>
    [DataMember(Name="parameterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterId")]
    public string ParameterId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementsDecodeConfigurationStringResponse200Parameters {\n");
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
