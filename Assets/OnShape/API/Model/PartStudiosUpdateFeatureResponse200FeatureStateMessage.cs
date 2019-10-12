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
  public class PartStudiosUpdateFeatureResponse200FeatureStateMessage {
    /// <summary>
    /// The overall state of the feature.  One of      \"OK\", \"INFO\", \"WARNING\" or \"ERROR\"
    /// </summary>
    /// <value>The overall state of the feature.  One of      \"OK\", \"INFO\", \"WARNING\" or \"ERROR\"</value>
    [DataMember(Name="featureStatus", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureStatus")]
    public string FeatureStatus { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosUpdateFeatureResponse200FeatureStateMessage {\n");
      sb.Append("  FeatureStatus: ").Append(FeatureStatus).Append("\n");
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
