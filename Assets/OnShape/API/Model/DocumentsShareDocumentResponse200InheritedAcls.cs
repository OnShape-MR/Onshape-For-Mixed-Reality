using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single parent object from which access rights are inherited
  /// </summary>
  [DataContract]
  public class DocumentsShareDocumentResponse200InheritedAcls {
    /// <summary>
    /// The ID of the parent folder that contributes access rights
    /// </summary>
    /// <value>The ID of the parent folder that contributes access rights</value>
    [DataMember(Name="objectId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectId")]
    public string ObjectId { get; set; }

    /// <summary>
    /// The name of the parent object
    /// </summary>
    /// <value>The name of the parent object</value>
    [DataMember(Name="objectName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectName")]
    public decimal? ObjectName { get; set; }

    /// <summary>
    /// A description string indicating whether the folder is       public or private. Currently always private
    /// </summary>
    /// <value>A description string indicating whether the folder is       public or private. Currently always private</value>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public string Visibility { get; set; }

    /// <summary>
    /// Not used
    /// </summary>
    /// <value>Not used</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// A URL referencing the API to get this structure
    /// </summary>
    /// <value>A URL referencing the API to get this structure</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// The current share entries for the parent folder. Each share      entry indicates an entity that the folder and contained objects are shared with and the permissions granted      to the entity
    /// </summary>
    /// <value>The current share entries for the parent folder. Each share      entry indicates an entity that the folder and contained objects are shared with and the permissions granted      to the entity</value>
    [DataMember(Name="entries", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entries")]
    public List<DocumentsShareDocumentResponse200Entries> Entries { get; set; }

    /// <summary>
    /// Gets or Sets Owner
    /// </summary>
    [DataMember(Name="owner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "owner")]
    public DocumentsShareDocumentResponse200Owner Owner { get; set; }

    /// <summary>
    /// Not used
    /// </summary>
    /// <value>Not used</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Set to the value 4, indicating the the objectId       identifies a folder
    /// </summary>
    /// <value>Set to the value 4, indicating the the objectId       identifies a folder</value>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public decimal? ObjectType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsShareDocumentResponse200InheritedAcls {\n");
      sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
      sb.Append("  ObjectName: ").Append(ObjectName).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
