using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Mass properties of the part named in the key
  /// </summary>
  [DataContract]
  public class Body {
    /// <summary>
    /// Number of parts without mass
    /// </summary>
    /// <value>Number of parts without mass</value>
    [DataMember(Name="massMissingCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "massMissingCount")]
    public decimal? MassMissingCount { get; set; }

    /// <summary>
    /// Volume in cubic meters, along with minimum and maximum
    /// </summary>
    /// <value>Volume in cubic meters, along with minimum and maximum</value>
    [DataMember(Name="volume", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "volume")]
    public List<decimal?> Volume { get; set; }

    /// <summary>
    /// Coordinates of the centroid (center of mass) in metric             units (3 numbers), along with minimum (3 numbers) and maximum (3 numbers)
    /// </summary>
    /// <value>Coordinates of the centroid (center of mass) in metric             units (3 numbers), along with minimum (3 numbers) and maximum (3 numbers)</value>
    [DataMember(Name="centroid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "centroid")]
    public List<decimal?> Centroid { get; set; }

    /// <summary>
    /// Periphery in metric units which depend on context, along             with minimum and maximum; for a solid part, the periphery is the surface area in square meters; for a             surface, the periphery is the perimeter in meters
    /// </summary>
    /// <value>Periphery in metric units which depend on context, along             with minimum and maximum; for a solid part, the periphery is the surface area in square meters; for a             surface, the periphery is the perimeter in meters</value>
    [DataMember(Name="periphery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periphery")]
    public List<decimal?> Periphery { get; set; }

    /// <summary>
    /// Moment of inertia around the principal axes in             metric units (3 numbers)
    /// </summary>
    /// <value>Moment of inertia around the principal axes in             metric units (3 numbers)</value>
    [DataMember(Name="principalInertia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principalInertia")]
    public List<decimal?> PrincipalInertia { get; set; }

    /// <summary>
    /// Mass in kilograms, along with minimum and maximum
    /// </summary>
    /// <value>Mass in kilograms, along with minimum and maximum</value>
    [DataMember(Name="mass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mass")]
    public List<decimal?> Mass { get; set; }

    /// <summary>
    /// Principal axes as unit vectors
    /// </summary>
    /// <value>Principal axes as unit vectors</value>
    [DataMember(Name="principalAxes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "principalAxes")]
    public List<BodyPrincipalAxes> PrincipalAxes { get; set; }

    /// <summary>
    /// Moment of inertia tensor about the centroid in metric units             with respect to the coordinate axes (9 numbers), along with minimum (9 numbers) and maximum (9             numbers)
    /// </summary>
    /// <value>Moment of inertia tensor about the centroid in metric units             with respect to the coordinate axes (9 numbers), along with minimum (9 numbers) and maximum (9             numbers)</value>
    [DataMember(Name="inertia", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "inertia")]
    public List<decimal?> Inertia { get; set; }

    /// <summary>
    /// Whether part has mass
    /// </summary>
    /// <value>Whether part has mass</value>
    [DataMember(Name="hasMass", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hasMass")]
    public bool? HasMass { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Body {\n");
      sb.Append("  MassMissingCount: ").Append(MassMissingCount).Append("\n");
      sb.Append("  Volume: ").Append(Volume).Append("\n");
      sb.Append("  Centroid: ").Append(Centroid).Append("\n");
      sb.Append("  Periphery: ").Append(Periphery).Append("\n");
      sb.Append("  PrincipalInertia: ").Append(PrincipalInertia).Append("\n");
      sb.Append("  Mass: ").Append(Mass).Append("\n");
      sb.Append("  PrincipalAxes: ").Append(PrincipalAxes).Append("\n");
      sb.Append("  Inertia: ").Append(Inertia).Append("\n");
      sb.Append("  HasMass: ").Append(HasMass).Append("\n");
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
