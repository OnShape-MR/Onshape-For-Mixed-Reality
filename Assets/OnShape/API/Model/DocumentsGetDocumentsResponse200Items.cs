using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Document information
  /// </summary>
  [DataContract]
  public class DocumentsGetDocumentsResponse200Items {
    /// <summary>
    /// Size of document in bytes
    /// </summary>
    /// <value>Size of document in bytes</value>
    [DataMember(Name="sizeBytes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sizeBytes")]
    public decimal? SizeBytes { get; set; }

    /// <summary>
    /// When document has been trashed
    /// </summary>
    /// <value>When document has been trashed</value>
    [DataMember(Name="trashedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trashedAt")]
    public DateTime? TrashedAt { get; set; }

    /// <summary>
    /// Number of workspaces that are scheduled             for updating
    /// </summary>
    /// <value>Number of workspaces that are scheduled             for updating</value>
    [DataMember(Name="totalWorkspacesScheduledForUpdate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalWorkspacesScheduledForUpdate")]
    public decimal? TotalWorkspacesScheduledForUpdate { get; set; }

    /// <summary>
    /// Name of document
    /// </summary>
    /// <value>Name of document</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Whether document can be unshared
    /// </summary>
    /// <value>Whether document can be unshared</value>
    [DataMember(Name="canUnshare", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canUnshare")]
    public bool? CanUnshare { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission")]
    public string Permission { get; set; }

    /// <summary>
    /// Document URL
    /// </summary>
    /// <value>Document URL</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    /// <value>Document ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets DefaultWorkspace
    /// </summary>
    [DataMember(Name="defaultWorkspace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultWorkspace")]
    public DocumentsGetDocumentsResponse200DefaultWorkspace DefaultWorkspace { get; set; }

    /// <summary>
    /// Gets or Sets Thumbnail
    /// </summary>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public DocumentsGetDocumentsResponse200Thumbnail Thumbnail { get; set; }

    /// <summary>
    /// Whether a shared document is active
    /// </summary>
    /// <value>Whether a shared document is active</value>
    [DataMember(Name="active", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "active")]
    public bool? Active { get; set; }

    /// <summary>
    /// Reserved for future use
    /// </summary>
    /// <value>Reserved for future use</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Date of last modification
    /// </summary>
    /// <value>Date of last modification</value>
    [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public DocumentsGetDocumentsResponse200CreatedBy CreatedBy { get; set; }

    /// <summary>
    /// Number of workspaces that are updating
    /// </summary>
    /// <value>Number of workspaces that are updating</value>
    [DataMember(Name="totalWorkspacesUpdating", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "totalWorkspacesUpdating")]
    public decimal? TotalWorkspacesUpdating { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public DocumentsGetDocumentsResponse200Owner Owner { get; set; }

    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name="modifiedBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedBy")]
    public DocumentsGetDocumentsResponse200ModifiedBy ModifiedBy { get; set; }

    /// <summary>
    /// Whether document has been starred
    /// </summary>
    /// <value>Whether document has been starred</value>
    [DataMember(Name="starred", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "starred")]
    public string Starred { get; set; }

    /// <summary>
    /// Whether document has been trashed
    /// </summary>
    /// <value>Whether document has been trashed</value>
    [DataMember(Name="trash", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trash")]
    public bool? Trash { get; set; }

    /// <summary>
    /// Whether document is public
    /// </summary>
    /// <value>Whether document is public</value>
    [DataMember(Name="public", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "public")]
    public bool? Public { get; set; }

    /// <summary>
    /// Creation date
    /// </summary>
    /// <value>Creation date</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public DateTime? CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetDocumentsResponse200Items {\n");
      sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
      sb.Append("  TrashedAt: ").Append(TrashedAt).Append("\n");
      sb.Append("  TotalWorkspacesScheduledForUpdate: ").Append(TotalWorkspacesScheduledForUpdate).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  CanUnshare: ").Append(CanUnshare).Append("\n");
      sb.Append("  Permission: ").Append(Permission).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DefaultWorkspace: ").Append(DefaultWorkspace).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Active: ").Append(Active).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  TotalWorkspacesUpdating: ").Append(TotalWorkspacesUpdating).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
      sb.Append("  Starred: ").Append(Starred).Append("\n");
      sb.Append("  Trash: ").Append(Trash).Append("\n");
      sb.Append("  Public: ").Append(Public).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
