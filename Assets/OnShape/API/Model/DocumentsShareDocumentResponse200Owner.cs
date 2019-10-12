using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Information about the document owner
  /// </summary>
  [DataContract]
  public class DocumentsShareDocumentResponse200Owner {
    /// <summary>
    /// Type of the document owner. Possible values include 0=User, 1=Company,       2=Team, 3=<Reserved>, 4=Application
    /// </summary>
    /// <value>Type of the document owner. Possible values include 0=User, 1=Company,       2=Team, 3=<Reserved>, 4=Application</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public decimal? Type { get; set; }

    /// <summary>
    /// ID of the document owner
    /// </summary>
    /// <value>ID of the document owner</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsShareDocumentResponse200Owner {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
