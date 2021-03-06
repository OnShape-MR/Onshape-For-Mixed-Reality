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
  public class DocumentsShareDocumentBody {
    /// <summary>
    /// If true, indicates that the request is intended to be an update of existing      share permissions for the entities in the entries list.
    /// </summary>
    /// <value>If true, indicates that the request is intended to be an update of existing      share permissions for the entities in the entries list.</value>
    [DataMember(Name="update", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "update")]
    public bool? Update { get; set; }

    /// <summary>
    /// The permissions to grant to the entities. Must not be empty. The      valid permissions are READ, WRITE, DELETE, RESHARE, COMMENT, LINK, COPY, OWNER. It is an error for a      permission set to be specified that is identical to the current permissions for an entity in the entries      list.
    /// </summary>
    /// <value>The permissions to grant to the entities. Must not be empty. The      valid permissions are READ, WRITE, DELETE, RESHARE, COMMENT, LINK, COPY, OWNER. It is an error for a      permission set to be specified that is identical to the current permissions for an entity in the entries      list.</value>
    [DataMember(Name="permissionSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissionSet")]
    public List<string> PermissionSet { get; set; }

    /// <summary>
    /// The ID of a workspace for use as the scope of           sharing. Used only to form URLs in a share email to the share recipient.
    /// </summary>
    /// <value>The ID of a workspace for use as the scope of           sharing. Used only to form URLs in a share email to the share recipient.</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// The ID of the document to be shared. Must match the document ID specified in           the URL.
    /// </summary>
    /// <value>The ID of the document to be shared. Must match the document ID specified in           the URL.</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// List of target entities to share with. Must not be empty.
    /// </summary>
    /// <value>List of target entities to share with. Must not be empty.</value>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<DocumentsShareDocumentBodyEntries> Entries { get; set; }

    /// <summary>
    /// An optional message to include in the share email.      This message has a maximum allowed size.
    /// </summary>
    /// <value>An optional message to include in the share email.      This message has a maximum allowed size.</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public string Message { get; set; }

    /// <summary>
    /// The ID of an element within the document to share. Used only to form URLs           in a share email to the share recipient.
    /// </summary>
    /// <value>The ID of an element within the document to share. Used only to form URLs           in a share email to the share recipient.</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsShareDocumentBody {\n");
      sb.Append("  Update: ").Append(Update).Append("\n");
      sb.Append("  PermissionSet: ").Append(PermissionSet).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
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
