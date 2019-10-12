using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual face of a part
  /// </summary>
  [DataContract]
  public class PartsGetBodyDetailsResponse200Faces {
    /// <summary>
    /// Gets or Sets Box
    /// </summary>
    [DataMember(Name="box", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "box")]
    public PartsGetBodyDetailsResponse200Box Box { get; set; }

    /// <summary>
    /// Orientation of a face
    /// </summary>
    /// <value>Orientation of a face</value>
    [DataMember(Name="orientation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "orientation")]
    public bool? Orientation { get; set; }

    /// <summary>
    /// Area of a face
    /// </summary>
    /// <value>Area of a face</value>
    [DataMember(Name="area", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "area")]
    public decimal? Area { get; set; }

    /// <summary>
    /// Gets or Sets Surface
    /// </summary>
    [DataMember(Name="surface", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "surface")]
    public PartsGetBodyDetailsResponse200Surface Surface { get; set; }

    /// <summary>
    /// Loops of a face
    /// </summary>
    /// <value>Loops of a face</value>
    [DataMember(Name="loops", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "loops")]
    public List<PartsGetBodyDetailsResponse200Loops> Loops { get; set; }

    /// <summary>
    /// Face ID
    /// </summary>
    /// <value>Face ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetBodyDetailsResponse200Faces {\n");
      sb.Append("  Box: ").Append(Box).Append("\n");
      sb.Append("  Orientation: ").Append(Orientation).Append("\n");
      sb.Append("  Area: ").Append(Area).Append("\n");
      sb.Append("  Surface: ").Append(Surface).Append("\n");
      sb.Append("  Loops: ").Append(Loops).Append("\n");
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
