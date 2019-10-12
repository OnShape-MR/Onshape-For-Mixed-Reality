using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// discount created by
  /// </summary>
  [DataContract]
  public class BillingGetClientPlansResponse200DiscountCreatedBy {
    /// <summary>
    /// discount creator user first name
    /// </summary>
    /// <value>discount creator user first name</value>
    [DataMember(Name="firstName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// discount creator user last name
    /// </summary>
    /// <value>discount creator user last name</value>
    [DataMember(Name="lastName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// discount creator user image url
    /// </summary>
    /// <value>discount creator user image url</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// discount creator e-mail
    /// </summary>
    /// <value>discount creator e-mail</value>
    [DataMember(Name="email", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "email")]
    public string Email { get; set; }

    /// <summary>
    /// discount creator user state
    /// </summary>
    /// <value>discount creator user state</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public decimal? State { get; set; }

    /// <summary>
    /// discount creator user href
    /// </summary>
    /// <value>discount creator user href</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// discount creator user id
    /// </summary>
    /// <value>discount creator user id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetClientPlansResponse200DiscountCreatedBy {\n");
      sb.Append("  FirstName: ").Append(FirstName).Append("\n");
      sb.Append("  LastName: ").Append(LastName).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Email: ").Append(Email).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
