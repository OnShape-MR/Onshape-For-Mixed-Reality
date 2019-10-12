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
  public class DocumentsCopyWorkspaceBody {
    /// <summary>
    /// New document name
    /// </summary>
    /// <value>New document name</value>
    [DataMember(Name="newName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newName")]
    public string NewName { get; set; }

    /// <summary>
    /// Owner's user ID (default: current user)
    /// </summary>
    /// <value>Owner's user ID (default: current user)</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="betaCapabilityIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "betaCapabilityIds")]
    public List<string> BetaCapabilityIds { get; set; }

    /// <summary>
    /// Whether new document is public (default: false)
    /// </summary>
    /// <value>Whether new document is public (default: false)</value>
    [DataMember(Name="isPublic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPublic")]
    public bool? IsPublic { get; set; }

    /// <summary>
    /// Owner's user type, which can be: 0: user 1: company 2: Team (default:           0)
    /// </summary>
    /// <value>Owner's user type, which can be: 0: user 1: company 2: Team (default:           0)</value>
    [DataMember(Name="ownerTypeIndex", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerTypeIndex")]
    public decimal? OwnerTypeIndex { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsCopyWorkspaceBody {\n");
      sb.Append("  NewName: ").Append(NewName).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  BetaCapabilityIds: ").Append(BetaCapabilityIds).Append("\n");
      sb.Append("  IsPublic: ").Append(IsPublic).Append("\n");
      sb.Append("  OwnerTypeIndex: ").Append(OwnerTypeIndex).Append("\n");
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
