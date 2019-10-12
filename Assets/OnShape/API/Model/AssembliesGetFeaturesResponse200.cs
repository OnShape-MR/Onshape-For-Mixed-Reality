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
  public class AssembliesGetFeaturesResponse200 {
    /// <summary>
    /// The document microversion from which the feature was extracted
    /// </summary>
    /// <value>The document microversion from which the feature was extracted</value>
    [DataMember(Name="sourceMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversion")]
    public string SourceMicroversion { get; set; }

    /// <summary>
    /// List of feature state information
    /// </summary>
    /// <value>List of feature state information</value>
    [DataMember(Name="featureStates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureStates")]
    public List<PartStudiosGetFeaturesResponse200FeatureStates> FeatureStates { get; set; }

    /// <summary>
    /// The version of the serialization protocol for the response
    /// </summary>
    /// <value>The version of the serialization protocol for the response</value>
    [DataMember(Name="serializationVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serializationVersion")]
    public string SerializationVersion { get; set; }

    /// <summary>
    /// List of features
    /// </summary>
    /// <value>List of features</value>
    [DataMember(Name="features", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "features")]
    public List<PartStudiosGetFeaturesResponse200Features> Features { get; set; }

    /// <summary>
    /// True if the full feature list is present, or false if it is filtered
    /// </summary>
    /// <value>True if the full feature list is present, or false if it is filtered</value>
    [DataMember(Name="isComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isComplete")]
    public bool? IsComplete { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetFeaturesResponse200 {\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  FeatureStates: ").Append(FeatureStates).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  Features: ").Append(Features).Append("\n");
      sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
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
