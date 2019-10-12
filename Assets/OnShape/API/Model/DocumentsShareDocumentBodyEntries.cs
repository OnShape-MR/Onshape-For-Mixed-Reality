using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A target entity
  /// </summary>
  [DataContract]
  public class DocumentsShareDocumentBodyEntries {
    /// <summary>
    /// The ID of an Onshape Company to share with
    /// </summary>
    /// <value>The ID of an Onshape Company to share with</value>
    [DataMember(Name="companyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyId")]
    public string CompanyId { get; set; }

    /// <summary>
    /// The ID of an Onshape User to share with
    /// </summary>
    /// <value>The ID of an Onshape User to share with</value>
    [DataMember(Name="userId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userId")]
    public string UserId { get; set; }

    /// <summary>
    /// The type of entity that whe are sharing with. Valid values are      0=User (specify userId or email), 1=Company, 2=Team, 4=Application. Must correspond to the id field populated.
    /// </summary>
    /// <value>The type of entity that whe are sharing with. Valid values are      0=User (specify userId or email), 1=Company, 2=Team, 4=Application. Must correspond to the id field populated.</value>
    [DataMember(Name="entryType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entryType")]
    public string EntryType { get; set; }

    /// <summary>
    /// The ID of an Onshape Team to share with
    /// </summary>
    /// <value>The ID of an Onshape Team to share with</value>
    [DataMember(Name="teamId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "teamId")]
    public string TeamId { get; set; }

    /// <summary>
    /// The ID of an Onshape Application to share with.     Note that application sharing only allows READ to be specified as a permission.
    /// </summary>
    /// <value>The ID of an Onshape Application to share with.     Note that application sharing only allows READ to be specified as a permission.</value>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

    /// <summary>
    /// The email of a user to share with. If the email is not     associated with an existing Onshape user, an invite email will be sent to the email address if update=false,     otherwise the response will be a NOT FOUND error.
    /// </summary>
    /// <value>The email of a user to share with. If the email is not     associated with an existing Onshape user, an invite email will be sent to the email address if update=false,     otherwise the response will be a NOT FOUND error.</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsShareDocumentBodyEntries {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  UserId: ").Append(UserId).Append("\n");
      sb.Append("  EntryType: ").Append(EntryType).Append("\n");
      sb.Append("  TeamId: ").Append(TeamId).Append("\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
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
