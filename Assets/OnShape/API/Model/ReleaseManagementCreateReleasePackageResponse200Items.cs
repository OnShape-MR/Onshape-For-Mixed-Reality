using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single item
  /// </summary>
  [DataContract]
  public class ReleaseManagementCreateReleasePackageResponse200Items {
    /// <summary>
    /// Properties of the item
    /// </summary>
    /// <value>Properties of the item</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ReleaseManagementCreateReleasePackageResponse200Properties> Properties { get; set; }

    /// <summary>
    /// Errors or warnings if any associated with items.
    /// </summary>
    /// <value>Errors or warnings if any associated with items.</value>
    [DataMember(Name="errors", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errors")]
    public List<ReleaseManagementCreateReleasePackageResponse200Errors> Errors { get; set; }

    /// <summary>
    /// Name of the revisionable object
    /// </summary>
    /// <value>Name of the revisionable object</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Deterministic part ID if item is a part
    /// </summary>
    /// <value>Deterministic part ID if item is a part</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// An URI to get complete metadata for the item
    /// </summary>
    /// <value>An URI to get complete metadata for the item</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Type of element, which can be 0: Part Studio, 1: Assembly, 2:             Drawing. 4: Blob
    /// </summary>
    /// <value>Type of element, which can be 0: Part Studio, 1: Assembly, 2:             Drawing. 4: Blob</value>
    [DataMember(Name="elmentType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elmentType")]
    public decimal? ElmentType { get; set; }

    /// <summary>
    /// Dependent child items as determined by Onshape. Assemblies             and Drawings will contain all their references recursively unless they have been explicitly marked as             non revision managed.
    /// </summary>
    /// <value>Dependent child items as determined by Onshape. Assemblies             and Drawings will contain all their references recursively unless they have been explicitly marked as             non revision managed.</value>
    [DataMember(Name="children", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "children")]
    public List<Object> Children { get; set; }

    /// <summary>
    /// Version ID of the revisionable object
    /// </summary>
    /// <value>Version ID of the revisionable object</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Workspace ID of the revisionable object
    /// </summary>
    /// <value>Workspace ID of the revisionable object</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// Document ID of the revisionable object
    /// </summary>
    /// <value>Document ID of the revisionable object</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Configuration of the Part studio or Assembly element
    /// </summary>
    /// <value>Configuration of the Part studio or Assembly element</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// ID of the item
    /// </summary>
    /// <value>ID of the item</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Element ID of the revisionable object
    /// </summary>
    /// <value>Element ID of the revisionable object</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// An URI that can be opened in the browser to view the item
    /// </summary>
    /// <value>An URI that can be opened in the browser to view the item</value>
    [DataMember(Name="viewRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewRef")]
    public string ViewRef { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementCreateReleasePackageResponse200Items {\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  Errors: ").Append(Errors).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  ElmentType: ").Append(ElmentType).Append("\n");
      sb.Append("  Children: ").Append(Children).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  ViewRef: ").Append(ViewRef).Append("\n");
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
