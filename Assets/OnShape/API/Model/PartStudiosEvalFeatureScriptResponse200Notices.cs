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
  public class PartStudiosEvalFeatureScriptResponse200Notices {
    /// <summary>
    /// A stack trace indicating the execution location for the notice
    /// </summary>
    /// <value>A stack trace indicating the execution location for the notice</value>
    [DataMember(Name="stackTrace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "stackTrace")]
    public List<Object> StackTrace { get; set; }

    /// <summary>
    /// The severity level of a notice entry
    /// </summary>
    /// <value>The severity level of a notice entry</value>
    [DataMember(Name="level", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "level")]
    public string Level { get; set; }

    /// <summary>
    /// Undocumented
    /// </summary>
    /// <value>Undocumented</value>
    [DataMember(Name="tryNode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tryNode")]
    public Object TryNode { get; set; }

    /// <summary>
    /// The id of the parameter to which the notice applies,    where applicable
    /// </summary>
    /// <value>The id of the parameter to which the notice applies,    where applicable</value>
    [DataMember(Name="parameterId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parameterId")]
    public List<Object> ParameterId { get; set; }

    /// <summary>
    /// A readable message
    /// </summary>
    /// <value>A readable message</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The type of notice indicating the phase of analysis where found
    /// </summary>
    /// <value>The type of notice indicating the phase of analysis where found</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosEvalFeatureScriptResponse200Notices {\n");
      sb.Append("  StackTrace: ").Append(StackTrace).Append("\n");
      sb.Append("  Level: ").Append(Level).Append("\n");
      sb.Append("  TryNode: ").Append(TryNode).Append("\n");
      sb.Append("  ParameterId: ").Append(ParameterId).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
