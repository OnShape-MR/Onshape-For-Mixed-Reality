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
  public class ReleaseManagementCreateReleasePackageBodyItems {
    /// <summary>
    /// Part deterministic ID if item is a revisionable part
    /// </summary>
    /// <value>Part deterministic ID if item is a revisionable part</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Version ID in which the item exists. All items must be from the same           version or workspace
    /// </summary>
    /// <value>Version ID in which the item exists. All items must be from the same           version or workspace</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Workspace ID in which the item exists. All items must be from           either the same workspace or version
    /// </summary>
    /// <value>Workspace ID in which the item exists. All items must be from           either the same workspace or version</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// Document ID in which the item exists. All items must be from the           same document.
    /// </summary>
    /// <value>Document ID in which the item exists. All items must be from the           same document.</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Configuration of the element if item is configured.
    /// </summary>
    /// <value>Configuration of the element if item is configured.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// Element ID of the item
    /// </summary>
    /// <value>Element ID of the item</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementCreateReleasePackageBodyItems {\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
