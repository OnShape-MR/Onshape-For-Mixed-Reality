using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single item to update
  /// </summary>
  [DataContract]
  public class ReleaseManagementUpdateReleasePackageBodyItems {
    /// <summary>
    /// href href of the item
    /// </summary>
    /// <value>href href of the item</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Array of item properties to update before doing the transition.           All properties with required=true which do not have a value must be specified. No properties with           editable=false should be specified.
    /// </summary>
    /// <value>Array of item properties to update before doing the transition.           All properties with required=true which do not have a value must be specified. No properties with           editable=false should be specified.</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ReleaseManagementUpdateReleasePackageBodyProperties> Properties { get; set; }

    /// <summary>
    /// Version ID of the item
    /// </summary>
    /// <value>Version ID of the item</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Workspace ID of the item
    /// </summary>
    /// <value>Workspace ID of the item</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// Element ID of the item
    /// </summary>
    /// <value>Element ID of the item</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Id of the item as returned by createObsoletionPackage, createReleasePackage           or getReleasePackage
    /// </summary>
    /// <value>Id of the item as returned by createObsoletionPackage, createReleasePackage           or getReleasePackage</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Document ID of the item
    /// </summary>
    /// <value>Document ID of the item</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementUpdateReleasePackageBodyItems {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
