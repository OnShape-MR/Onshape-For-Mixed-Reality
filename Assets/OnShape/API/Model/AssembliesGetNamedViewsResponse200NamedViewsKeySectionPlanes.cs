using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class AssembliesGetNamedViewsResponse200NamedViewsKeySectionPlanes {
    /// <summary>
    /// A 3-element array storing the tangent vector of a section plane
    /// </summary>
    /// <value>A 3-element array storing the tangent vector of a section plane</value>
    [DataMember(Name="tangent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tangent")]
    public decimal? Tangent { get; set; }

    /// <summary>
    /// A 3-element array storing the center vector of a section plane
    /// </summary>
    /// <value>A 3-element array storing the center vector of a section plane</value>
    [DataMember(Name="center", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "center")]
    public decimal? Center { get; set; }

    /// <summary>
    /// A 3-element array storing the normal vector of a section plane
    /// </summary>
    /// <value>A 3-element array storing the normal vector of a section plane</value>
    [DataMember(Name="normal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normal")]
    public decimal? Normal { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetNamedViewsResponse200NamedViewsKeySectionPlanes {\n");
      sb.Append("  Tangent: ").Append(Tangent).Append("\n");
      sb.Append("  Center: ").Append(Center).Append("\n");
      sb.Append("  Normal: ").Append(Normal).Append("\n");
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
