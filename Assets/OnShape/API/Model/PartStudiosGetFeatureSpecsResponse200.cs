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
  public class PartStudiosGetFeatureSpecsResponse200 {
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
    /// Array of feature specs
    /// </summary>
    /// <value>Array of feature specs</value>
    [DataMember(Name="featureSpecs", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureSpecs")]
    public List<Object> FeatureSpecs { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFeatureSpecsResponse200 {\n");
      sb.Append("  SerializationVersion: ").Append(SerializationVersion).Append("\n");
      sb.Append("  SourceMicroversion: ").Append(SourceMicroversion).Append("\n");
      sb.Append("  FeatureSpecs: ").Append(FeatureSpecs).Append("\n");
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
