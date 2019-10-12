using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An instance to insert.
  /// </summary>
  [DataContract]
  public class AssembliesInsertTransformedInstancesBodyInstances {
    /// <summary>
    /// Part ID of instance, if it's a part or surface.           Must be left blank if featureId is set.
    /// </summary>
    /// <value>Part ID of instance, if it's a part or surface.           Must be left blank if featureId is set.</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Feature ID of instance, if it's a feature.           Currently, only sketch features are valid. Must be left blank if partId is set.
    /// </summary>
    /// <value>Feature ID of instance, if it's a feature.           Currently, only sketch features are valid. Must be left blank if partId is set.</value>
    [DataMember(Name="featureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureId")]
    public string FeatureId { get; set; }

    /// <summary>
    /// Whether the instance is the assembly           specified by the element ID.
    /// </summary>
    /// <value>Whether the instance is the assembly           specified by the element ID.</value>
    [DataMember(Name="isAssembly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAssembly")]
    public bool? IsAssembly { get; set; }

    /// <summary>
    /// Source document microversion ID in which           to resolve elementId and partId. This must be left empty if a versionId is specified.
    /// </summary>
    /// <value>Source document microversion ID in which           to resolve elementId and partId. This must be left empty if a versionId is specified.</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Document version ID in which to resolve           elementId and partId.
    /// </summary>
    /// <value>Document version ID in which to resolve           elementId and partId.</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Source document ID for the           instance. If this differs from the same document as in the path, you must specify a versionId for the           instance in the source document.
    /// </summary>
    /// <value>Source document ID for the           instance. If this differs from the same document as in the path, you must specify a versionId for the           instance in the source document.</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Configuration of the source element,           valid only if the referenced element is a Part Studio.
    /// </summary>
    /// <value>Configuration of the source element,           valid only if the referenced element is a Part Studio.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// Source element ID for the instance.
    /// </summary>
    /// <value>Source element ID for the instance.</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Whether the instance is the           entire part studio specified by the element ID.
    /// </summary>
    /// <value>Whether the instance is the           entire part studio specified by the element ID.</value>
    [DataMember(Name="isWholePartStudio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isWholePartStudio")]
    public bool? IsWholePartStudio { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesInsertTransformedInstancesBodyInstances {\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  IsAssembly: ").Append(IsAssembly).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  IsWholePartStudio: ").Append(IsWholePartStudio).Append("\n");
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
