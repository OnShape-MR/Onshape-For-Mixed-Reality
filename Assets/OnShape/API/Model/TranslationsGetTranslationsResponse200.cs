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
  public class TranslationsGetTranslationsResponse200 {
    /// <summary>
    /// List of items
    /// </summary>
    /// <value>List of items</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<TranslationsGetTranslationsResponse200Items> Items { get; set; }

    /// <summary>
    /// URI to retrieve previous batch
    /// </summary>
    /// <value>URI to retrieve previous batch</value>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public string Previous { get; set; }

    /// <summary>
    /// Whether there are more entries to retrieve
    /// </summary>
    /// <value>Whether there are more entries to retrieve</value>
    [DataMember(Name="hasNext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasNext")]
    public bool? HasNext { get; set; }

    /// <summary>
    /// URI to retrieve next batch
    /// </summary>
    /// <value>URI to retrieve next batch</value>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public string Next { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TranslationsGetTranslationsResponse200 {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Previous: ").Append(Previous).Append("\n");
      sb.Append("  HasNext: ").Append(HasNext).Append("\n");
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
