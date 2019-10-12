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
  public class AssembliesGetAssemblyDefinitionResponse200 {
    /// <summary>
    /// Gets or Sets RootAssembly
    /// </summary>
    [DataMember(Name="rootAssembly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rootAssembly")]
    public AssembliesGetAssemblyDefinitionResponse200RootAssembly RootAssembly { get; set; }

    /// <summary>
    /// Array of sub-assemblies
    /// </summary>
    /// <value>Array of sub-assemblies</value>
    [DataMember(Name="subAssemblies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subAssemblies")]
    public List<AssembliesGetAssemblyDefinitionResponse200SubAssemblies> SubAssemblies { get; set; }

    /// <summary>
    /// Parts in the assembly
    /// </summary>
    /// <value>Parts in the assembly</value>
    [DataMember(Name="parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parts")]
    public List<AssembliesGetAssemblyDefinitionResponse200Parts> Parts { get; set; }

    /// <summary>
    /// Features defined in Part Studios that are referenced by the             assembly, including sketches.
    /// </summary>
    /// <value>Features defined in Part Studios that are referenced by the             assembly, including sketches.</value>
    [DataMember(Name="partStudioFeatures", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partStudioFeatures")]
    public List<AssembliesGetAssemblyDefinitionResponse200PartStudioFeatures> PartStudioFeatures { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200 {\n");
      sb.Append("  RootAssembly: ").Append(RootAssembly).Append("\n");
      sb.Append("  SubAssemblies: ").Append(SubAssemblies).Append("\n");
      sb.Append("  Parts: ").Append(Parts).Append("\n");
      sb.Append("  PartStudioFeatures: ").Append(PartStudioFeatures).Append("\n");
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
