using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual edge
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Edges {
    /// <summary>
    /// Gets or Sets Geometry
    /// </summary>
    [DataMember(Name="geometry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geometry")]
    public PartsGetBodyDetailsResponse200Geometry Geometry { get; set; }

    /// <summary>
    /// Gets or Sets Curve
    /// </summary>
    [DataMember(Name="curve", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "curve")]
    public PartsGetBodyDetailsResponse200Curve Curve { get; set; }

    /// <summary>
    /// Edge ID
    /// </summary>
    /// <value>Edge ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Array of vertex IDs
    /// </summary>
    /// <value>Array of vertex IDs</value>
    [DataMember(Name="vertices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vertices")]
    public List<string> Vertices { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Edges {\n");
      sb.Append("  Geometry: ").Append(Geometry).Append("\n");
      sb.Append("  Curve: ").Append(Curve).Append("\n");
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
