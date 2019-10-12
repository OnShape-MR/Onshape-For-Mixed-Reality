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
  public class PartStudiosComparePartStudioResponse200 {
    /// <summary>
    /// Source document microversion id
    /// </summary>
    /// <value>Source document microversion id</value>
    [DataMember(Name="sourceMicroversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceMicroversionId")]
    public string SourceMicroversionId { get; set; }

    /// <summary>
    /// Target version id, can be null
    /// </summary>
    /// <value>Target version id, can be null</value>
    [DataMember(Name="targetVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetVersionId")]
    public string TargetVersionId { get; set; }

    /// <summary>
    /// Part Studio change type (see API description)
    /// </summary>
    /// <value>Part Studio change type (see API description)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Target document microversion id
    /// </summary>
    /// <value>Target document microversion id</value>
    [DataMember(Name="targetMicroversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetMicroversionId")]
    public string TargetMicroversionId { get; set; }

    /// <summary>
    /// Source version id, can be null
    /// </summary>
    /// <value>Source version id, can be null</value>
    [DataMember(Name="sourceVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceVersionId")]
    public string SourceVersionId { get; set; }

    /// <summary>
    /// Gets or Sets Changes
    /// </summary>
    [DataMember(Name="changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changes")]
    public PartStudiosComparePartStudioResponse200Changes Changes { get; set; }

    /// <summary>
    /// Source workspace id, can be null
    /// </summary>
    /// <value>Source workspace id, can be null</value>
    [DataMember(Name="sourceWorkspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceWorkspaceId")]
    public string SourceWorkspaceId { get; set; }

    /// <summary>
    /// Target workspace id, can be null
    /// </summary>
    /// <value>Target workspace id, can be null</value>
    [DataMember(Name="targetWorkspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetWorkspaceId")]
    public string TargetWorkspaceId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosComparePartStudioResponse200 {\n");
      sb.Append("  SourceMicroversionId: ").Append(SourceMicroversionId).Append("\n");
      sb.Append("  TargetVersionId: ").Append(TargetVersionId).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  TargetMicroversionId: ").Append(TargetMicroversionId).Append("\n");
      sb.Append("  SourceVersionId: ").Append(SourceVersionId).Append("\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
      sb.Append("  SourceWorkspaceId: ").Append(SourceWorkspaceId).Append("\n");
      sb.Append("  TargetWorkspaceId: ").Append(TargetWorkspaceId).Append("\n");
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
