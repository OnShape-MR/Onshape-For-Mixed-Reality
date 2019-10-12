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
  public class AssembliesTransformOccurrencesBody {
    /// <summary>
    /// Whether the transform is relative or absolute. Each occurrence in an    assembly has a transform that positions it relative to the top-most assembly. An absolute transform operation    sets the transform of the occurrence and each child occurrence to the specified transform. A relative    transform operation combines the specified transform with the existing transform of the occurrence and with    each child occurrence transform.
    /// </summary>
    /// <value>Whether the transform is relative or absolute. Each occurrence in an    assembly has a transform that positions it relative to the top-most assembly. An absolute transform operation    sets the transform of the occurrence and each child occurrence to the specified transform. A relative    transform operation combines the specified transform with the existing transform of the occurrence and with    each child occurrence transform.</value>
    [DataMember(Name="isRelative", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isRelative")]
    public bool? IsRelative { get; set; }

    /// <summary>
    /// A list of occurrences to transform.
    /// </summary>
    /// <value>A list of occurrences to transform.</value>
    [DataMember(Name="occurrences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occurrences")]
    public List<AssembliesTransformOccurrencesBodyOccurrences> Occurrences { get; set; }

    /// <summary>
    /// The transform to apply to the occurrences.  Must be 9, 12, or 16    elements in length, representing a 3x3, 4x3 or 4x4 matrix, respectively.  All translation matrix components are in meters.
    /// </summary>
    /// <value>The transform to apply to the occurrences.  Must be 9, 12, or 16    elements in length, representing a 3x3, 4x3 or 4x4 matrix, respectively.  All translation matrix components are in meters.</value>
    [DataMember(Name="transform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transform")]
    public List<decimal?> Transform { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesTransformOccurrencesBody {\n");
      sb.Append("  IsRelative: ").Append(IsRelative).Append("\n");
      sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
      sb.Append("  Transform: ").Append(Transform).Append("\n");
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
