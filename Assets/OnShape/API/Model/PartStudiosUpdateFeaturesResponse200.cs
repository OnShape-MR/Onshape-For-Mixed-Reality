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
  public class PartStudiosUpdateFeaturesResponse200 {
    /// <summary>
    /// The document microversion from which the feature was extracted
    /// </summary>
    /// <value>The document microversion from which the feature was extracted</value>
    [DataMember(Name="sourceMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversion")]
    public string SourceMicroversion { get; set; }

    /// <summary>
    /// The version of the serialization protocol for the response
    /// </summary>
    /// <value>The version of the serialization protocol for the response</value>
    [DataMember(Name="serializationVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serializationVersion")]
    public string SerializationVersion { get; set; }

    /// <summary>
    /// The modified features after updates have been applied
    /// </summary>
    /// <value>The modified features after updates have been applied</value>
    [DataMember(Name="features", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "features")]
    public List<Object> Features { get; set; }

    /// <summary>
    /// Set to true if the part studio element had changed since the     sourceMicroversion specified on input.  Applicable only if rejectMicroversionSkew was not set to true
    /// </summary>
    /// <value>Set to true if the part studio element had changed since the     sourceMicroversion specified on input.  Applicable only if rejectMicroversionSkew was not set to true</value>
    [DataMember(Name="microversionSkew", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionSkew")]
    public bool? MicroversionSkew { get; set; }

    /// <summary>
    /// The states of the modified features
    /// </summary>
    /// <value>The states of the modified features</value>
    [DataMember(Name="featureStates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureStates")]
    public List<PartStudiosUpdateFeaturesResponse200FeatureStates> FeatureStates { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosUpdateFeaturesResponse200 {\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  Features: ").Append(Features).Append("\n");
      sb.Append("  MicroversionSkew: ").Append(MicroversionSkew).Append("\n");
      sb.Append("  FeatureStates: ").Append(FeatureStates).Append("\n");
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
