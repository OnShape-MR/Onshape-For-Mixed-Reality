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
  public class PartStudiosUpdateConfigurationBody {
    /// <summary>
    /// List of configuration parameters, which define the           configurability of the Part Studio.
    /// </summary>
    /// <value>List of configuration parameters, which define the           configurability of the Part Studio.</value>
    [DataMember(Name="configurationParameters", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configurationParameters")]
    public List<Object> ConfigurationParameters { get; set; }

    /// <summary>
    /// If set to true and the element has changed since     sourceMicroversion, return an HTTP Conflict status.
    /// </summary>
    /// <value>If set to true and the element has changed since     sourceMicroversion, return an HTTP Conflict status.</value>
    [DataMember(Name="rejectMicroversionSkew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejectMicroversionSkew")]
    public bool? RejectMicroversionSkew { get; set; }

    /// <summary>
    /// The version of the serialization protocol for features
    /// </summary>
    /// <value>The version of the serialization protocol for features</value>
    [DataMember(Name="serializationVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serializationVersion")]
    public string SerializationVersion { get; set; }

    /// <summary>
    /// The document microversion from which the features were extracted
    /// </summary>
    /// <value>The document microversion from which the features were extracted</value>
    [DataMember(Name="sourceMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversion")]
    public string SourceMicroversion { get; set; }

    /// <summary>
    /// List of parameter settings, which define the current           configuration Part Studio.
    /// </summary>
    /// <value>List of parameter settings, which define the current           configuration Part Studio.</value>
    [DataMember(Name="currentConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentConfiguration")]
    public List<Object> CurrentConfiguration { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosUpdateConfigurationBody {\n");
      sb.Append("  ConfigurationParameters: ").Append(ConfigurationParameters).Append("\n");
      sb.Append("  RejectMicroversionSkew: ").Append(RejectMicroversionSkew).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  CurrentConfiguration: ").Append(CurrentConfiguration).Append("\n");
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