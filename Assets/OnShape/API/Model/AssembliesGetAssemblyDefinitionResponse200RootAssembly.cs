using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Assembly information
  /// </summary>
  [DataContract]
  public class AssembliesGetAssemblyDefinitionResponse200RootAssembly {
    /// <summary>
    /// Direct child parts and sub-assemblies of the assembly.
    /// </summary>
    /// <value>Direct child parts and sub-assemblies of the assembly.</value>
    [DataMember(Name="instances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instances")]
    public List<AssembliesGetAssemblyDefinitionResponse200RootAssemblyInstances> Instances { get; set; }

    /// <summary>
    /// Assembly occurrences
    /// </summary>
    /// <value>Assembly occurrences</value>
    [DataMember(Name="occurrences", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "occurrences")]
    public List<AssembliesGetAssemblyDefinitionResponse200RootAssemblyOccurrences> Occurrences { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    /// <value>Document ID</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Document microversion ID
    /// </summary>
    /// <value>Document microversion ID</value>
    [DataMember(Name="documentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentMicroversion")]
    public string DocumentMicroversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200RootAssembly {\n");
      sb.Append("  Instances: ").Append(Instances).Append("\n");
      sb.Append("  Occurrences: ").Append(Occurrences).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  DocumentMicroversion: ").Append(DocumentMicroversion).Append("\n");
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
