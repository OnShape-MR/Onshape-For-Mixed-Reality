using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual part information
  /// </summary>
  [DataContract]
  public class AssembliesGetAssemblyDefinitionResponse200Parts {
    /// <summary>
    /// Type of part body. Current values that are possible are solid,             sheet. Others may be added in the future.
    /// </summary>
    /// <value>Type of part body. Current values that are possible are solid,             sheet. Others may be added in the future.</value>
    [DataMember(Name="bodyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bodyType")]
    public string BodyType { get; set; }

    /// <summary>
    /// Deterministic part ID. If the part cannot be resolved, the value             will be the empty string. This can happen if a change in the source part studio causes the part that             was originally referenced to be missing.
    /// </summary>
    /// <value>Deterministic part ID. If the part cannot be resolved, the value             will be the empty string. This can happen if a change in the source part studio causes the part that             was originally referenced to be missing.</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Document microversion ID of the document containing             the part
    /// </summary>
    /// <value>Document microversion ID of the document containing             the part</value>
    [DataMember(Name="documentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentMicroversion")]
    public string DocumentMicroversion { get; set; }

    /// <summary>
    /// Version ID of document containing the part, if reached             through one or more version references
    /// </summary>
    /// <value>Version ID of document containing the part, if reached             through one or more version references</value>
    [DataMember(Name="documentVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentVersion")]
    public string DocumentVersion { get; set; }

    /// <summary>
    /// Document ID of the document containing the part
    /// </summary>
    /// <value>Document ID of the document containing the part</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Configuration of the Part studio element.
    /// </summary>
    /// <value>Configuration of the Part studio element.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Indicates whether the part is Standard Content.
    /// </summary>
    /// <value>Indicates whether the part is Standard Content.</value>
    [DataMember(Name="isStandardContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isStandardContent")]
    public bool? IsStandardContent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200Parts {\n");
      sb.Append("  BodyType: ").Append(BodyType).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  DocumentMicroversion: ").Append(DocumentMicroversion).Append("\n");
      sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  IsStandardContent: ").Append(IsStandardContent).Append("\n");
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
