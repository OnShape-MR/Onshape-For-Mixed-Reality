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
  public class PartStudiosGetFeaturesResponse200 {
    /// <summary>
    /// List of features
    /// </summary>
    /// <value>List of features</value>
    [DataMember(Name="features", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "features")]
    public List<PartStudiosGetFeaturesResponse200Features> Features { get; set; }

    /// <summary>
    /// Array of imports into the feature list
    /// </summary>
    /// <value>Array of imports into the feature list</value>
    [DataMember(Name="imports", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "imports")]
    public List<PartStudiosGetFeaturesResponse200Imports> Imports { get; set; }

    /// <summary>
    /// List of feature state information
    /// </summary>
    /// <value>List of feature state information</value>
    [DataMember(Name="featureStates", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureStates")]
    public List<PartStudiosGetFeaturesResponse200FeatureStates> FeatureStates { get; set; }

    /// <summary>
    /// True if the full feature list is present, or false if it is filtered
    /// </summary>
    /// <value>True if the full feature list is present, or false if it is filtered</value>
    [DataMember(Name="isComplete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isComplete")]
    public bool? IsComplete { get; set; }

    /// <summary>
    /// The version of the serialization protocol for the response
    /// </summary>
    /// <value>The version of the serialization protocol for the response</value>
    [DataMember(Name="serializationVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "serializationVersion")]
    public string SerializationVersion { get; set; }

    /// <summary>
    /// The document microversion from which the feature was extracted
    /// </summary>
    /// <value>The document microversion from which the feature was extracted</value>
    [DataMember(Name="sourceMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversion")]
    public string SourceMicroversion { get; set; }

    /// <summary>
    /// The index of the first feature that is rolled back
    /// </summary>
    /// <value>The index of the first feature that is rolled back</value>
    [DataMember(Name="rollbackIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rollbackIndex")]
    public decimal? RollbackIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFeaturesResponse200 {\n");
      sb.Append("  Features: ").Append(Features).Append("\n");
      sb.Append("  Imports: ").Append(Imports).Append("\n");
      sb.Append("  FeatureStates: ").Append(FeatureStates).Append("\n");
      sb.Append("  IsComplete: ").Append(IsComplete).Append("\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  RollbackIndex: ").Append(RollbackIndex).Append("\n");
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
