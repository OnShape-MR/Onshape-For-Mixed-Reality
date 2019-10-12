using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Description of the curve along the edge. The fields    provided in the description are curve type-dependent.
  /// </summary>
  [DataContract]
  public class PartStudiosGetBodyDetailsResponse200Curve {
    /// <summary>
    /// (circle, ellipse) The center of the circle or    ellipse
    /// </summary>
    /// <value>(circle, ellipse) The center of the circle or    ellipse</value>
    [DataMember(Name="origin", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "origin")]
    public List<decimal?> Origin { get; set; }

    /// <summary>
    /// (circle, ellipse) A normal to the plane of the circle or ellipse
    /// </summary>
    /// <value>(circle, ellipse) A normal to the plane of the circle or ellipse</value>
    [DataMember(Name="normal", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "normal")]
    public List<decimal?> Normal { get; set; }

    /// <summary>
    /// (circle) The circle radius
    /// </summary>
    /// <value>(circle) The circle radius</value>
    [DataMember(Name="radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "radius")]
    public decimal? Radius { get; set; }

    /// <summary>
    /// (ellipse) The direction of the major radius
    /// </summary>
    /// <value>(ellipse) The direction of the major radius</value>
    [DataMember(Name="majorAxis", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "majorAxis")]
    public List<decimal?> MajorAxis { get; set; }

    /// <summary>
    /// (ellipse) The ellipse major radius
    /// </summary>
    /// <value>(ellipse) The ellipse major radius</value>
    [DataMember(Name="majorRadius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "majorRadius")]
    public decimal? MajorRadius { get; set; }

    /// <summary>
    /// Curve type - this can be one of \"bcurve\" (b-spline),    \"circle\", \"ellipse\", \"icurve\" (surface intersection), \"line\", \"other\".
    /// </summary>
    /// <value>Curve type - this can be one of \"bcurve\" (b-spline),    \"circle\", \"ellipse\", \"icurve\" (surface intersection), \"line\", \"other\".</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// (ellipse) The ellipse minor radius
    /// </summary>
    /// <value>(ellipse) The ellipse minor radius</value>
    [DataMember(Name="minorRadius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minorRadius")]
    public decimal? MinorRadius { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetBodyDetailsResponse200Curve {\n");
      sb.Append("  Origin: ").Append(Origin).Append("\n");
      sb.Append("  Normal: ").Append(Normal).Append("\n");
      sb.Append("  Radius: ").Append(Radius).Append("\n");
      sb.Append("  MajorAxis: ").Append(MajorAxis).Append("\n");
      sb.Append("  MajorRadius: ").Append(MajorRadius).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  MinorRadius: ").Append(MinorRadius).Append("\n");
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
