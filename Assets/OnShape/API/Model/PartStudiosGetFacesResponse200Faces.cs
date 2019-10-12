using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual face
  /// </summary>
  [DataContract]
  public class PartStudiosGetFacesResponse200Faces {
    /// <summary>
    /// Facets of a face
    /// </summary>
    /// <value>Facets of a face</value>
    [DataMember(Name="facets", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "facets")]
    public List<PartStudiosGetFacesResponse200Facets> Facets { get; set; }

    /// <summary>
    /// ID of a face
    /// </summary>
    /// <value>ID of a face</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFacesResponse200Faces {\n");
      sb.Append("  Facets: ").Append(Facets).Append("\n");
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
