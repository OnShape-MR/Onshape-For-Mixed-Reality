using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Bounding box of a face
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Box {
    /// <summary>
    /// Min corner of bounding box
    /// </summary>
    /// <value>Min corner of bounding box</value>
    [DataMember(Name="minCorner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minCorner")]
    public List<decimal?> MinCorner { get; set; }

    /// <summary>
    /// Max corner of bounding box
    /// </summary>
    /// <value>Max corner of bounding box</value>
    [DataMember(Name="maxCorner", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxCorner")]
    public List<decimal?> MaxCorner { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Box {\n");
      sb.Append("  MinCorner: ").Append(MinCorner).Append("\n");
      sb.Append("  MaxCorner: ").Append(MaxCorner).Append("\n");
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
