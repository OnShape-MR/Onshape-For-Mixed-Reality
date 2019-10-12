using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An individual sub-assembly
  /// </summary>
  [DataContract]
  public class AssembliesGetAssemblyDefinitionResponse200SubAssemblies {
    /// <summary>
    /// Instances within the sub-assembly
    /// </summary>
    /// <value>Instances within the sub-assembly</value>
    [DataMember(Name="instances", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "instances")]
    public List<Object> Instances { get; set; }

    /// <summary>
    /// Element ID of the sub-assembly
    /// </summary>
    /// <value>Element ID of the sub-assembly</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Version ID of document containing the             subAssembly, if reached through one or more version references
    /// </summary>
    /// <value>Version ID of document containing the             subAssembly, if reached through one or more version references</value>
    [DataMember(Name="documentVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentVersion")]
    public string DocumentVersion { get; set; }

    /// <summary>
    /// Document ID for the document containing the             sub-assembly
    /// </summary>
    /// <value>Document ID for the document containing the             sub-assembly</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Document microversion ID for the document             containing the sub-assembly
    /// </summary>
    /// <value>Document microversion ID for the document             containing the sub-assembly</value>
    [DataMember(Name="documentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentMicroversion")]
    public string DocumentMicroversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200SubAssemblies {\n");
      sb.Append("  Instances: ").Append(Instances).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
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
