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
  public class PartStudiosEvalFeatureScriptBody {
    /// <summary>
    /// If set to true and the element has changed since     sourceMicroversion, return an HTTP Conflict status.
    /// </summary>
    /// <value>If set to true and the element has changed since     sourceMicroversion, return an HTTP Conflict status.</value>
    [DataMember(Name="rejectMicroversionSkew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejectMicroversionSkew")]
    public bool? RejectMicroversionSkew { get; set; }

    /// <summary>
    /// Array of Feature Script identifier to geometry id list
    /// </summary>
    /// <value>Array of Feature Script identifier to geometry id list</value>
    [DataMember(Name="queries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "queries")]
    public List<PartStudiosEvalFeatureScriptBodyQueries> Queries { get; set; }

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
    /// A Feature Script function to execute.
    /// </summary>
    /// <value>A Feature Script function to execute.</value>
    [DataMember(Name="script", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "script")]
    public string Script { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosEvalFeatureScriptBody {\n");
      sb.Append("  RejectMicroversionSkew: ").Append(RejectMicroversionSkew).Append("\n");
      sb.Append("  Queries: ").Append(Queries).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  Script: ").Append(Script).Append("\n");
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
