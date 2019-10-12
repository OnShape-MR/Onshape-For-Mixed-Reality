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
  public class FeatureStudiosUpdateFeatureStudioContentsBody {
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
    /// The new contents of the feature studio
    /// </summary>
    /// <value>The new contents of the feature studio</value>
    [DataMember(Name="contents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "contents")]
    public Object Contents { get; set; }

    /// <summary>
    /// If set to true and the element has changed since     sourceMicroversion, return an HTTP Conflict status.
    /// </summary>
    /// <value>If set to true and the element has changed since     sourceMicroversion, return an HTTP Conflict status.</value>
    [DataMember(Name="rejectMicroversionSkew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rejectMicroversionSkew")]
    public bool? RejectMicroversionSkew { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FeatureStudiosUpdateFeatureStudioContentsBody {\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  Contents: ").Append(Contents).Append("\n");
      sb.Append("  RejectMicroversionSkew: ").Append(RejectMicroversionSkew).Append("\n");
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
