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
  public class PartStudiosComparePartStudioResponse200ChangesPartsCollectionChanges {
    /// <summary>
    /// Part Id of the Part in the source             microversion, can be null for new Parts
    /// </summary>
    /// <value>Part Id of the Part in the source             microversion, can be null for new Parts</value>
    [DataMember(Name="sourceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceId")]
    public string SourceId { get; set; }

    /// <summary>
    /// Type of the change (see API description             for values)
    /// </summary>
    /// <value>Type of the change (see API description             for values)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Part Id of the Part in the target             microversion, can be null for deleted Parts
    /// </summary>
    /// <value>Part Id of the Part in the target             microversion, can be null for deleted Parts</value>
    [DataMember(Name="targetId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetId")]
    public string TargetId { get; set; }

    /// <summary>
    /// Gets or Sets Changes
    /// </summary>
    [DataMember(Name="changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changes")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChanges Changes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosComparePartStudioResponse200ChangesPartsCollectionChanges {\n");
      sb.Append("  SourceId: ").Append(SourceId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TargetId: ").Append(TargetId).Append("\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
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
