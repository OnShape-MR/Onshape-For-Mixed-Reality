using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual part in a studio
  /// </summary>
  [DataContract]
  public class PartStudiosGetEdgesResponse200Parts {
    /// <summary>
    /// Edges of a part
    /// </summary>
    /// <value>Edges of a part</value>
    [DataMember(Name="edges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "edges")]
    public List<PartStudiosGetEdgesResponse200Edges> Edges { get; set; }

    /// <summary>
    /// ID of a part
    /// </summary>
    /// <value>ID of a part</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetEdgesResponse200Parts {\n");
      sb.Append("  Edges: ").Append(Edges).Append("\n");
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
