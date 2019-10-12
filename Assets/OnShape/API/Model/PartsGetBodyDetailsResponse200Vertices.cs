using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual vertex
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Vertices {
    /// <summary>
    /// Vertex ID
    /// </summary>
    /// <value>Vertex ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Location of vertex
    /// </summary>
    /// <value>Location of vertex</value>
    [DataMember(Name="point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "point")]
    public List<decimal?> Point { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Vertices {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Point: ").Append(Point).Append("\n");
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
