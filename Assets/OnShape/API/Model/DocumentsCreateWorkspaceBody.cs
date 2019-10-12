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
  public class DocumentsCreateWorkspaceBody {
    /// <summary>
    /// Workspace name (not required if readOnly=true)
    /// </summary>
    /// <value>Workspace name (not required if readOnly=true)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Reserved for internal use
    /// </summary>
    /// <value>Reserved for internal use</value>
    [DataMember(Name="readOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "readOnly")]
    public bool? ReadOnly { get; set; }

    /// <summary>
    /// Microversion ID of parent document microversion
    /// </summary>
    /// <value>Microversion ID of parent document microversion</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Version ID of parent version
    /// </summary>
    /// <value>Version ID of parent version</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Workspace ID of parent workspace
    /// </summary>
    /// <value>Workspace ID of parent workspace</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// Reserved for internal use
    /// </summary>
    /// <value>Reserved for internal use</value>
    [DataMember(Name="clientInteractionMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientInteractionMode")]
    public decimal? ClientInteractionMode { get; set; }

    /// <summary>
    /// Workspace description
    /// </summary>
    /// <value>Workspace description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsCreateWorkspaceBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  ClientInteractionMode: ").Append(ClientInteractionMode).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
