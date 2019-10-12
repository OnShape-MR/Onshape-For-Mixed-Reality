using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Subscriber information
  /// </summary>
  [DataContract]
  public class AccountsGetPlanPurchasesResponse200Subscribers {
    /// <summary>
    /// User's last name (requires OAuth2ReadPII scope)
    /// </summary>
    /// <value>User's last name (requires OAuth2ReadPII scope)</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public Object LastName { get; set; }

    /// <summary>
    /// User's email (requires OAuth2ReadPII scope)
    /// </summary>
    /// <value>User's email (requires OAuth2ReadPII scope)</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public Object Email { get; set; }

    /// <summary>
    /// User id
    /// </summary>
    /// <value>User id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public Object Id { get; set; }

    /// <summary>
    /// User's first name (requires OAuth2ReadPII scope)
    /// </summary>
    /// <value>User's first name (requires OAuth2ReadPII scope)</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public Object FirstName { get; set; }

    /// <summary>
    /// User's name (requires OAuth2ReadPII scope)
    /// </summary>
    /// <value>User's name (requires OAuth2ReadPII scope)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public Object Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountsGetPlanPurchasesResponse200Subscribers {\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
