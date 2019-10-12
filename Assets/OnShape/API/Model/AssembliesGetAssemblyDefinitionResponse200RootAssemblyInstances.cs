using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An instance of an individual part, feature or             sub-assembly directly inserted in the assembly. If a part, feature or assembly is directly inserted             multiple times, there will be an instance for each time it is included.
  /// </summary>
  [DataContract]
  public class AssembliesGetAssemblyDefinitionResponse200RootAssemblyInstances {
    /// <summary>
    /// Part/feature/assembly name
    /// </summary>
    /// <value>Part/feature/assembly name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Deterministic part ID if type is Part. If the             part cannot be resolved, the value will be the empty string. This can happen if a change in the             source part studio causes the part that was originally referenced to be missing.
    /// </summary>
    /// <value>Deterministic part ID if type is Part. If the             part cannot be resolved, the value will be the empty string. This can happen if a change in the             source part studio causes the part that was originally referenced to be missing.</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Microversion ID of document             containing the included instance
    /// </summary>
    /// <value>Microversion ID of document             containing the included instance</value>
    [DataMember(Name="documentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentMicroversion")]
    public string DocumentMicroversion { get; set; }

    /// <summary>
    /// Instance type. Current valid values are Part,             Assembly, Feature. Other values may be added in the future. Note that \"Part\" may mean a reference to             a surface or a solid and that \"Feature\" currently means a reference to a Sketch, but support for             other feature types may be added in the future. For Part, a specific bodyType is included in the             parts information and for Feature, a specific featureType is included in the partStudioFeatures             information.
    /// </summary>
    /// <value>Instance type. Current valid values are Part,             Assembly, Feature. Other values may be added in the future. Note that \"Part\" may mean a reference to             a surface or a solid and that \"Feature\" currently means a reference to a Sketch, but support for             other feature types may be added in the future. For Part, a specific bodyType is included in the             parts information and for Feature, a specific featureType is included in the partStudioFeatures             information.</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Version ID of document containing the             included instance, if reached through one or more version references
    /// </summary>
    /// <value>Version ID of document containing the             included instance, if reached through one or more version references</value>
    [DataMember(Name="documentVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentVersion")]
    public string DocumentVersion { get; set; }

    /// <summary>
    /// Element ID of the part/assembly instance
    /// </summary>
    /// <value>Element ID of the part/assembly instance</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Configuration of the Part studio element                    if the instance references a Part studio.
    /// </summary>
    /// <value>Configuration of the Part studio element                    if the instance references a Part studio.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// Instance suppressed or not
    /// </summary>
    /// <value>Instance suppressed or not</value>
    [DataMember(Name="suppressed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "suppressed")]
    public bool? Suppressed { get; set; }

    /// <summary>
    /// Instance ID
    /// </summary>
    /// <value>Instance ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Document ID for the document containing the             included instance
    /// </summary>
    /// <value>Document ID for the document containing the             included instance</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// If type is Part this field             indicates whether the part is Standard Content.
    /// </summary>
    /// <value>If type is Part this field             indicates whether the part is Standard Content.</value>
    [DataMember(Name="isStandardContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isStandardContent")]
    public bool? IsStandardContent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200RootAssemblyInstances {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  DocumentMicroversion: ").Append(DocumentMicroversion).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  Suppressed: ").Append(Suppressed).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
