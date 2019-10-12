using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual part
  /// </summary>
  [DataContract]
  public class PartStudiosGetFacesResponse200Parts {
    /// <summary>
    /// ID of a part
    /// </summary>
    /// <value>ID of a part</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Faces of a part
    /// </summary>
    /// <value>Faces of a part</value>
    [DataMember(Name="faces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "faces")]
    public List<PartStudiosGetFacesResponse200Faces> Faces { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFacesResponse200Parts {\n");
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
