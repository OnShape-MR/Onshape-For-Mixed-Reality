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
  public class TeamsFindResponse200 {
    /// <summary>
    /// URL for current page of 20 teams
    /// </summary>
    /// <value>URL for current page of 20 teams</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Paginated list of 20 teams
    /// </summary>
    /// <value>Paginated list of 20 teams</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<TeamsFindResponse200Items> Items { get; set; }

    /// <summary>
    /// URL for next page of 20 teams
    /// </summary>
    /// <value>URL for next page of 20 teams</value>
    [DataMember(Name="next", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "next")]
    public string Next { get; set; }

    /// <summary>
    /// URL for previous page of 20 teams
    /// </summary>
    /// <value>URL for previous page of 20 teams</value>
    [DataMember(Name="previous", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previous")]
    public string Previous { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TeamsFindResponse200 {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Next: ").Append(Next).Append("\n");
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
