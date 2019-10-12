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
  public class PartStudiosGetBodyDetailsResponse200Bodies {
    /// <summary>
    /// Vertices of part
    /// </summary>
    /// <value>Vertices of part</value>
    [DataMember(Name="vertices", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vertices")]
    public List<PartsGetBodyDetailsResponse200Vertices> Vertices { get; set; }

    /// <summary>
    /// Edges of a part
    /// </summary>
    /// <value>Edges of a part</value>
    [DataMember(Name="edges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "edges")]
    public List<PartStudiosGetBodyDetailsResponse200Edges> Edges { get; set; }

    /// <summary>
    /// Type of a part
    /// </summary>
    /// <value>Type of a part</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// ID of a part
    /// </summary>
    /// <value>ID of a part</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Array of info for each face of a part
    /// </summary>
    /// <value>Array of info for each face of a part</value>
    [DataMember(Name="faces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faces")]
    public List<PartStudiosGetBodyDetailsResponse200Faces> Faces { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetBodyDetailsResponse200Bodies {\n");
      sb.Append("  Vertices: ").Append(Vertices).Append("\n");
      sb.Append("  Edges: ").Append(Edges).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Faces: ").Append(Faces).Append("\n");
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
