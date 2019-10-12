using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An individual occurrence, which may be a part or             sub-assembly, and may be either a directly included instance or a child of a sub-assembly. An             occurrence has a transform that positions a part or sub-assembly within this assembly. Whether an             occurrence is fixed or hidden is also specified in an occurrence.
  /// </summary>
  [DataContract]
  public class AssembliesGetAssemblyDefinitionResponse200RootAssemblyOccurrences {
    /// <summary>
    /// A list of occurrence IDs, representing the             hierachical inclusion structure of the occurrence within the assembly. Each element in the list is an             id value for an entry in rootAssembly.instances or rootAssembly.subAssemblies.N.instances
    /// </summary>
    /// <value>A list of occurrence IDs, representing the             hierachical inclusion structure of the occurrence within the assembly. Each element in the list is an             id value for an entry in rootAssembly.instances or rootAssembly.subAssemblies.N.instances</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public List<string> Path { get; set; }

    /// <summary>
    /// Occurrence hidden or displayed
    /// </summary>
    /// <value>Occurrence hidden or displayed</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// Occurrence fixed or not
    /// </summary>
    /// <value>Occurrence fixed or not</value>
    [DataMember(Name="fixed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fixed")]
    public bool? Fixed { get; set; }

    /// <summary>
    /// A 16-element transform matrix that             transforms the occurrence into the world space of the top-level assembly.
    /// </summary>
    /// <value>A 16-element transform matrix that             transforms the occurrence into the world space of the top-level assembly.</value>
    [DataMember(Name="transform", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transform")]
    public List<decimal?> Transform { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200RootAssemblyOccurrences {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  Fixed: ").Append(Fixed).Append("\n");
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
