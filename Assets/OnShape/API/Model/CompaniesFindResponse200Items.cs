using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Company information
  /// </summary>
  [DataContract]
  public class CompaniesFindResponse200Items {
    /// <summary>
    /// Company description
    /// </summary>
    /// <value>Company description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Whether current user is administrator of company
    /// </summary>
    /// <value>Whether current user is administrator of company</value>
    [DataMember(Name="admin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "admin")]
    public bool? Admin { get; set; }

    /// <summary>
    /// URL for company image
    /// </summary>
    /// <value>URL for company image</value>
    [DataMember(Name="image", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "image")]
    public string Image { get; set; }

    /// <summary>
    /// URL of this company information
    /// </summary>
    /// <value>URL of this company information</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Gets or Sets Address
    /// </summary>
    [DataMember(Name="address", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "address")]
    public CompaniesGetResponse200Address Address { get; set; }

    /// <summary>
    /// Company ID
    /// </summary>
    /// <value>Company ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Company name
    /// </summary>
    /// <value>Company name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class CompaniesFindResponse200Items {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Admin: ").Append(Admin).Append("\n");
      sb.Append("  Image: ").Append(Image).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Address: ").Append(Address).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
