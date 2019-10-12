using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual edge of a part
  /// </summary>
  [DataContract]
  public class PartsGetEdgesResponse200Edges {
    /// <summary>
    /// ID of an edge
    /// </summary>
    /// <value>ID of an edge</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Vertices
    /// </summary>
    [DataMember(Name="vertices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vertices")]
    public PartsGetEdgesResponse200Vertices Vertices { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetEdgesResponse200Edges {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Vertices: ").Append(Vertices).Append("\n");
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
