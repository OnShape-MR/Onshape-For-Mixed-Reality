using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual coedge
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Coedges {
    /// <summary>
    /// Orientation of an edge
    /// </summary>
    /// <value>Orientation of an edge</value>
    [DataMember(Name="orientation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orientation")]
    public bool? Orientation { get; set; }

    /// <summary>
    /// ID of an edge
    /// </summary>
    /// <value>ID of an edge</value>
    [DataMember(Name="edgeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "edgeId")]
    public string EdgeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Coedges {\n");
      sb.Append("  Orientation: ").Append(Orientation).Append("\n");
      sb.Append("  EdgeId: ").Append(EdgeId).Append("\n");
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
