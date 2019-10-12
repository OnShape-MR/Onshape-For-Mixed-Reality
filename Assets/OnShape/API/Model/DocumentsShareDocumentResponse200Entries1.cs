using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A share entry for the object specific to an entity
  /// </summary>
  [DataContract]
  public class DocumentsShareDocumentResponse200Entries1 {
    /// <summary>
    /// For internal use
    /// </summary>
    /// <value>For internal use</value>
    [DataMember(Name="pendingOwnerTransfer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pendingOwnerTransfer")]
    public bool? PendingOwnerTransfer { get; set; }

    /// <summary>
    /// The name of the entity that the object is shared with
    /// </summary>
    /// <value>The name of the entity that the object is shared with</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The ID of the object
    /// </summary>
    /// <value>The ID of the object</value>
    [DataMember(Name="objectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectId")]
    public string ObjectId { get; set; }

    /// <summary>
    /// Obsolete
    /// </summary>
    /// <value>Obsolete</value>
    [DataMember(Name="permission", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permission")]
    public decimal? Permission { get; set; }

    /// <summary>
    /// For internal use
    /// </summary>
    /// <value>For internal use</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// The email of the user, if the entryType is USER.
    /// </summary>
    /// <value>The email of the user, if the entryType is USER.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// The permissions for the object that have been granted      to the entity.
    /// </summary>
    /// <value>The permissions for the object that have been granted      to the entity.</value>
    [DataMember(Name="permissionSet", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "permissionSet")]
    public List<string> PermissionSet { get; set; }

    /// <summary>
    /// The ID of the entity to which this entry corresponds
    /// </summary>
    /// <value>The ID of the entity to which this entry corresponds</value>
    [DataMember(Name="entryId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryId")]
    public string EntryId { get; set; }

    /// <summary>
    /// The state of user to which the share entry applies, if a user.      Possible states include ACTIVE, INACTIVE, REQUESTED, APPROVED, DELETED, REQUEST_EXPIRED.
    /// </summary>
    /// <value>The state of user to which the share entry applies, if a user.      Possible states include ACTIVE, INACTIVE, REQUESTED, APPROVED, DELETED, REQUEST_EXPIRED.</value>
    [DataMember(Name="entryState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryState")]
    public string EntryState { get; set; }

    /// <summary>
    /// The type of entity to which the share entry applies. Possible      values include  0=User, 1=Company, 2=Team, 3=<Reserved>, 4=Application
    /// </summary>
    /// <value>The type of entity to which the share entry applies. Possible      values include  0=User, 1=Company, 2=Team, 3=<Reserved>, 4=Application</value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public decimal? EntryType { get; set; }

    /// <summary>
    /// For internal use
    /// </summary>
    /// <value>For internal use</value>
    [DataMember(Name="acceptOwnerTransfer", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "acceptOwnerTransfer")]
    public bool? AcceptOwnerTransfer { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsShareDocumentResponse200Entries1 {\n");
      sb.Append("  PendingOwnerTransfer: ").Append(PendingOwnerTransfer).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  Permission: ").Append(Permission).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  PermissionSet: ").Append(PermissionSet).Append("\n");
      sb.Append("  EntryId: ").Append(EntryId).Append("\n");
      sb.Append("  EntryState: ").Append(EntryState).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  AcceptOwnerTransfer: ").Append(AcceptOwnerTransfer).Append("\n");
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
