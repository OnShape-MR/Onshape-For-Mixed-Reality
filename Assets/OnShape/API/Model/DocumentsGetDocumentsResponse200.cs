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
  public class DocumentsGetDocumentsResponse200 {
    /// <summary>
    /// Array of documents
    /// </summary>
    /// <value>Array of documents</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<DocumentsGetDocumentsResponse200Items> Items { get; set; }

    /// <summary>
    /// URL of next page of results
    /// </summary>
    /// <value>URL of next page of results</value>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public string Next { get; set; }

    /// <summary>
    /// URL of current page of results
    /// </summary>
    /// <value>URL of current page of results</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// URL of previous page of results
    /// </summary>
    /// <value>URL of previous page of results</value>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public string Previous { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetDocumentsResponse200 {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Next: ").Append(Next).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Previous: ").Append(Previous).Append("\n");
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
