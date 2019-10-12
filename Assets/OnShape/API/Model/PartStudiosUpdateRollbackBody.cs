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
  public class PartStudiosUpdateRollbackBody {
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
    /// The index at which the rollback index should be placed. Features   with entry index (0-based) higher than or equal to this value are rolled back.  The value -1 is treated   as an alias for \"end of feature list\".  Otherwise the value must be in the range 0 to the number of   entries in the feature list
    /// </summary>
    /// <value>The index at which the rollback index should be placed. Features   with entry index (0-based) higher than or equal to this value are rolled back.  The value -1 is treated   as an alias for \"end of feature list\".  Otherwise the value must be in the range 0 to the number of   entries in the feature list</value>
    [DataMember(Name="rollbackIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollbackIndex")]
    public decimal? RollbackIndex { get; set; }

    /// <summary>
    /// The document microversion from which the features were extracted
    /// </summary>
    /// <value>The document microversion from which the features were extracted</value>
    [DataMember(Name="sourceMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversion")]
    public string SourceMicroversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosUpdateRollbackBody {\n");
      sb.Append("  RejectMicroversionSkew: ").Append(RejectMicroversionSkew).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  RollbackIndex: ").Append(RollbackIndex).Append("\n");
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
