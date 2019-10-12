using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information for the requested version
  /// </summary>
  [DataContract]
  public class DocumentsGetVersionResponse200Version {
    /// <summary>
    /// User-provided description of version
    /// </summary>
    /// <value>User-provided description of version</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// ID of parent version, or empty string for root version
    /// </summary>
    /// <value>ID of parent version, or empty string for root version</value>
    [DataMember(Name="parent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parent")]
    public string Parent { get; set; }

    /// <summary>
    /// Gets or Sets Creator
    /// </summary>
    [DataMember(Name="creator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "creator")]
    public DocumentsGetVersionResponse200VersionCreator Creator { get; set; }

    /// <summary>
    /// Document microversion ID for version
    /// </summary>
    /// <value>Document microversion ID for version</value>
    [DataMember(Name="microversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversion")]
    public string Microversion { get; set; }

    /// <summary>
    /// Last modification date
    /// </summary>
    /// <value>Last modification date</value>
    [DataMember(Name="modifiedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "modifiedAt")]
    public DateTime? ModifiedAt { get; set; }

    /// <summary>
    /// ID of version
    /// </summary>
    /// <value>ID of version</value>
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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetVersionResponse200Version {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Parent: ").Append(Parent).Append("\n");
      sb.Append("  Creator: ").Append(Creator).Append("\n");
      sb.Append("  Microversion: ").Append(Microversion).Append("\n");
      sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
