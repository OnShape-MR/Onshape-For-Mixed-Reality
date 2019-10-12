using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// List of elements
  /// </summary>
  [DataContract]
  public class MetadataGetMetadataResponse200Elements {
    /// <summary>
    /// URL of current page of the response
    /// </summary>
    /// <value>URL of current page of the response</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Collection of element metadata objects
    /// </summary>
    /// <value>Collection of element metadata objects</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<MetadataGetMetadataResponse200ElementsItems> Items { get; set; }

    /// <summary>
    /// URL of the previous page of the collection, can be null
    /// </summary>
    /// <value>URL of the previous page of the collection, can be null</value>
    [DataMember(Name="prev", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "prev")]
    public string Prev { get; set; }

    /// <summary>
    /// URL of the next page of the collection, can be null
    /// </summary>
    /// <value>URL of the next page of the collection, can be null</value>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public string Next { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataGetMetadataResponse200Elements {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Prev: ").Append(Prev).Append("\n");
      sb.Append("  Next: ").Append(Next).Append("\n");
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
