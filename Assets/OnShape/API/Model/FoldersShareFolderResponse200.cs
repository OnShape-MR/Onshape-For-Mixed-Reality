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
  public class FoldersShareFolderResponse200 {
    /// <summary>
    /// Not used
    /// </summary>
    /// <value>Not used</value>
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
    /// True if the object is public
    /// </summary>
    /// <value>True if the object is public</value>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// True if the object is shared with support
    /// </summary>
    /// <value>True if the object is shared with support</value>
    [DataMember(Name="sharedWithSupport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sharedWithSupport")]
    public bool? SharedWithSupport { get; set; }

    /// <summary>
    /// A description string indicating whether the object is public or private
    /// </summary>
    /// <value>A description string indicating whether the object is public or private</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// A list of parent objects from which this object inherits access       rights. Parent objects are currently always folders
    /// </summary>
    /// <value>A list of parent objects from which this object inherits access       rights. Parent objects are currently always folders</value>
    [DataMember(Name="inheritedAcls", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inheritedAcls")]
    public List<DocumentsShareDocumentResponse200InheritedAcls> InheritedAcls { get; set; }

    /// <summary>
    /// True if the requesting user has RESHARE privileges on the object.      If set to false, entries that do not relate to the caller are removed from the output.
    /// </summary>
    /// <value>True if the requesting user has RESHARE privileges on the object.      If set to false, entries that do not relate to the caller are removed from the output.</value>
    [DataMember(Name="isAdmin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAdmin")]
    public bool? IsAdmin { get; set; }

    /// <summary>
    /// A URL referencing the API to get this structure
    /// </summary>
    /// <value>A URL referencing the API to get this structure</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// The current share entries for the object. Each share entry indicates      an entity that the object is shared with and the permissions granted to the entity
    /// </summary>
    /// <value>The current share entries for the object. Each share entry indicates      an entity that the object is shared with and the permissions granted to the entity</value>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<DocumentsShareDocumentResponse200Entries1> Entries { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public DocumentsShareDocumentResponse200Owner1 Owner { get; set; }

    /// <summary>
    /// Not used
    /// </summary>
    /// <value>Not used</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Set to the value 1, indicating the the objectId indicates a document,       or 4, indicating that the objectId indicates a folder
    /// </summary>
    /// <value>Set to the value 1, indicating the the objectId indicates a document,       or 4, indicating that the objectId indicates a folder</value>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public decimal? ObjectType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class FoldersShareFolderResponse200 {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  SharedWithSupport: ").Append(SharedWithSupport).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  InheritedAcls: ").Append(InheritedAcls).Append("\n");
      sb.Append("  IsAdmin: ").Append(IsAdmin).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Entries: ").Append(Entries).Append("\n");
      sb.Append("  Owner: ").Append(Owner).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
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
