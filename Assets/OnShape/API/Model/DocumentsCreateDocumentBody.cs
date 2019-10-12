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
  public class DocumentsCreateDocumentBody {
    /// <summary>
    /// Document name
    /// </summary>
    /// <value>Document name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="tags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tags")]
    public List<string> Tags { get; set; }

    /// <summary>
    /// Whether document is public
    /// </summary>
    /// <value>Whether document is public</value>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Owner's user type, which can be 0: user, 1: company
    /// </summary>
    /// <value>Owner's user type, which can be 0: user, 1: company</value>
    [DataMember(Name="ownerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerType")]
    public decimal? OwnerType { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="isGenerateUnknownMessages", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isGenerateUnknownMessages")]
    public bool? IsGenerateUnknownMessages { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="betaCapabilityIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betaCapabilityIds")]
    public List<string> BetaCapabilityIds { get; set; }

    /// <summary>
    /// Owner's user ID (default: current user)
    /// </summary>
    /// <value>Owner's user ID (default: current user)</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsCreateDocumentBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Tags: ").Append(Tags).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
      sb.Append("  IsGenerateUnknownMessages: ").Append(IsGenerateUnknownMessages).Append("\n");
      sb.Append("  BetaCapabilityIds: ").Append(BetaCapabilityIds).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
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
