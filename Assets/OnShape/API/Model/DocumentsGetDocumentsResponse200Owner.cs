using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about document owner
  /// </summary>
  [DataContract]
  public class DocumentsGetDocumentsResponse200Owner {
    /// <summary>
    /// URL of user page for document owner
    /// </summary>
    /// <value>URL of user page for document owner</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Owner's user type, which can be: 0: user, 1: company, 2: team
    /// </summary>
    /// <value>Owner's user type, which can be: 0: user, 1: company, 2: team</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// Name of document owner
    /// </summary>
    /// <value>Name of document owner</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// ID of document owner
    /// </summary>
    /// <value>ID of document owner</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetDocumentsResponse200Owner {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
