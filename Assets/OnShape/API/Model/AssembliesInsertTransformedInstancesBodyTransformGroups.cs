using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A transform and a list of instances to insert with the transform.
  /// </summary>
  [DataContract]
  public class AssembliesInsertTransformedInstancesBodyTransformGroups {
    /// <summary>
    /// The instances to insert with the transform.
    /// </summary>
    /// <value>The instances to insert with the transform.</value>
    [DataMember(Name="instances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instances")]
    public List<AssembliesInsertTransformedInstancesBodyInstances> Instances { get; set; }

    /// <summary>
    /// The transform to apply to the instances. Must be 9, 12,           or 16 elements in length, representing a 3x3, 4x3 or 4x4 matrix, respectively. All translation matrix           components are in meters.
    /// </summary>
    /// <value>The transform to apply to the instances. Must be 9, 12,           or 16 elements in length, representing a 3x3, 4x3 or 4x4 matrix, respectively. All translation matrix           components are in meters.</value>
    [DataMember(Name="transform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transform")]
    public List<decimal?> Transform { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesInsertTransformedInstancesBodyTransformGroups {\n");
      sb.Append("  Instances: ").Append(Instances).Append("\n");
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
