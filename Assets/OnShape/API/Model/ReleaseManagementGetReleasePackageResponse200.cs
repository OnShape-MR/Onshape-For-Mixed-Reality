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
  public class ReleaseManagementGetReleasePackageResponse200 {
    /// <summary>
    /// Company ID to which the release package belongs.
    /// </summary>
    /// <value>Company ID to which the release package belongs.</value>
    [DataMember(Name="companyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyId")]
    public string CompanyId { get; set; }

    /// <summary>
    /// Full item list in the package determined by the input items
    /// </summary>
    /// <value>Full item list in the package determined by the input items</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<ReleaseManagementCreateReleasePackageResponse200Items> Items { get; set; }

    /// <summary>
    /// Gets or Sets Workflow
    /// </summary>
    [DataMember(Name="workflow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflow")]
    public ReleaseManagementGetReleasePackageResponse200Workflow Workflow { get; set; }

    /// <summary>
    /// Whether the release package has reached its terminal tranistion. Frozen             packages cannot be modified.
    /// </summary>
    /// <value>Whether the release package has reached its terminal tranistion. Frozen             packages cannot be modified.</value>
    [DataMember(Name="isFrozen", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isFrozen")]
    public bool? IsFrozen { get; set; }

    /// <summary>
    /// Array of properties for the package
    /// </summary>
    /// <value>Array of properties for the package</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ReleaseManagementCreateReleasePackageResponse200Properties1> Properties { get; set; }

    /// <summary>
    /// Primary Version ID of items in the release package
    /// </summary>
    /// <value>Primary Version ID of items in the release package</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Primary Workspace ID of items in the release package
    /// </summary>
    /// <value>Primary Workspace ID of items in the release package</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// ID of the release package.
    /// </summary>
    /// <value>ID of the release package.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Primary Document ID of items in the release package
    /// </summary>
    /// <value>Primary Document ID of items in the release package</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementGetReleasePackageResponse200 {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Workflow: ").Append(Workflow).Append("\n");
      sb.Append("  IsFrozen: ").Append(IsFrozen).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
