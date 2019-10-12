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
  public class PartStudiosEvalFeatureScriptResponse200 {
    /// <summary>
    /// A list of notices regarding the execution
    /// </summary>
    /// <value>A list of notices regarding the execution</value>
    [DataMember(Name="notices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notices")]
    public List<PartStudiosEvalFeatureScriptResponse200Notices> Notices { get; set; }

    /// <summary>
    /// The version of the serialization protocol for the response
    /// </summary>
    /// <value>The version of the serialization protocol for the response</value>
    [DataMember(Name="serializationVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serializationVersion")]
    public string SerializationVersion { get; set; }

    /// <summary>
    /// An informational message
    /// </summary>
    /// <value>An informational message</value>
    [DataMember(Name="console", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "console")]
    public string Console { get; set; }

    /// <summary>
    /// the result of the function execution
    /// </summary>
    /// <value>the result of the function execution</value>
    [DataMember(Name="result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "result")]
    public Object Result { get; set; }

    /// <summary>
    /// The document microversion from which the feature was extracted
    /// </summary>
    /// <value>The document microversion from which the feature was extracted</value>
    [DataMember(Name="sourceMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversion")]
    public string SourceMicroversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosEvalFeatureScriptResponse200 {\n");
      sb.Append("  Notices: ").Append(Notices).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  Console: ").Append(Console).Append("\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
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
