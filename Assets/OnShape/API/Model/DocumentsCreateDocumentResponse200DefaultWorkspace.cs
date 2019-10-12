using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about the default workspace
  /// </summary>
  [DataContract]
  public class DocumentsCreateDocumentResponse200DefaultWorkspace {
    /// <summary>
    /// User-provided description of workspace
    /// </summary>
    /// <value>User-provided description of workspace</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// ID of workspace's parent version
    /// </summary>
    /// <value>ID of workspace's parent version</value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public string Parent { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public DocumentsCreateDocumentResponse200DefaultWorkspaceCreator Creator { get; set; }

    /// <summary>
    /// Whether workspace is read-only
    /// </summary>
    /// <value>Whether workspace is read-only</value>
    [DataMember(Name="isReadOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isReadOnly")]
    public bool? IsReadOnly { get; set; }

    /// <summary>
    /// Whether workspace can be deleted
    /// </summary>
    /// <value>Whether workspace can be deleted</value>
    [DataMember(Name="canDelete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canDelete")]
    public bool? CanDelete { get; set; }

    /// <summary>
    /// Current document microversion ID of workspace
    /// </summary>
    /// <value>Current document microversion ID of workspace</value>
    [DataMember(Name="microversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversion")]
    public string Microversion { get; set; }

    /// <summary>
    /// name of workspace
    /// </summary>
    /// <value>name of workspace</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Last modification date
    /// </summary>
    /// <value>Last modification date</value>
    [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// Type of record
    /// </summary>
    /// <value>Type of record</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// ID of workspace
    /// </summary>
    /// <value>ID of workspace</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    /// <value>Creation date</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }

    /// <summary>
    /// Gets or Sets LastModifier
    /// </summary>
    [DataMember(Name="lastModifier", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastModifier")]
    public DocumentsCreateDocumentResponse200DefaultWorkspaceLastModifier LastModifier { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsCreateDocumentResponse200DefaultWorkspace {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  IsReadOnly: ").Append(IsReadOnly).Append("\n");
      sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
      sb.Append("  Microversion: ").Append(Microversion).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
      sb.Append("  LastModifier: ").Append(LastModifier).Append("\n");
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
