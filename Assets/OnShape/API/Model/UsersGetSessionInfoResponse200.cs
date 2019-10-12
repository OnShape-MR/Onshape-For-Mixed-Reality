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
  public class UsersGetSessionInfoResponse200 {
    /// <summary>
    /// User's name (OAuth2ReadPII)
    /// </summary>
    /// <value>User's name (OAuth2ReadPII)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// User's first name (OAuth2ReadPII)
    /// </summary>
    /// <value>User's first name (OAuth2ReadPII)</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// User's last name (OAuth2ReadPII)
    /// </summary>
    /// <value>User's last name (OAuth2ReadPII)</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// User's image (OAuth2ReadPII)
    /// </summary>
    /// <value>User's image (OAuth2ReadPII)</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="oauth2Scopes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "oauth2Scopes")]
    public decimal? Oauth2Scopes { get; set; }

    /// <summary>
    /// application's client ID
    /// </summary>
    /// <value>application's client ID</value>
    [DataMember(Name="clientId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clientId")]
    public string ClientId { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public decimal? State { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="role", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "role")]
    public decimal? Role { get; set; }

    /// <summary>
    /// User's roles (OAuth2ReadPII)
    /// </summary>
    /// <value>User's roles (OAuth2ReadPII)</value>
    [DataMember(Name="roles", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "roles")]
    public List<string> Roles { get; set; }

    /// <summary>
    /// User's email (OAuth2ReadPII)
    /// </summary>
    /// <value>User's email (OAuth2ReadPII)</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetSessionInfoResponse200 {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Oauth2Scopes: ").Append(Oauth2Scopes).Append("\n");
      sb.Append("  ClientId: ").Append(ClientId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Role: ").Append(Role).Append("\n");
      sb.Append("  Roles: ").Append(Roles).Append("\n");
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
