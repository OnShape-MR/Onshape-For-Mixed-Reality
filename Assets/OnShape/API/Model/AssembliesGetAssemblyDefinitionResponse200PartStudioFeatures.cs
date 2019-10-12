using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual referenced Part Studio feature information
  /// </summary>
  [DataContract]
  public class AssembliesGetAssemblyDefinitionResponse200PartStudioFeatures {
    /// <summary>
    /// The type of the feature (e.g. sketch)
    /// </summary>
    /// <value>The type of the feature (e.g. sketch)</value>
    [DataMember(Name="featureType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureType")]
    public string FeatureType { get; set; }

    /// <summary>
    /// Document microversion ID of the             document containing the referenced feature
    /// </summary>
    /// <value>Document microversion ID of the             document containing the referenced feature</value>
    [DataMember(Name="documentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentMicroversion")]
    public string DocumentMicroversion { get; set; }

    /// <summary>
    /// The ID of the feature
    /// </summary>
    /// <value>The ID of the feature</value>
    [DataMember(Name="featureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureId")]
    public string FeatureId { get; set; }

    /// <summary>
    /// Version ID of document containing the             referenced feature, if reached through one or more version references
    /// </summary>
    /// <value>Version ID of document containing the             referenced feature, if reached through one or more version references</value>
    [DataMember(Name="documentVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentVersion")]
    public string DocumentVersion { get; set; }

    /// <summary>
    /// Document ID of the document containing the             referenced feature
    /// </summary>
    /// <value>Document ID of the document containing the             referenced feature</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Element ID of part studio containing the feature
    /// </summary>
    /// <value>Element ID of part studio containing the feature</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetAssemblyDefinitionResponse200PartStudioFeatures {\n");
      sb.Append("  FeatureType: ").Append(FeatureType).Append("\n");
      sb.Append("  DocumentMicroversion: ").Append(DocumentMicroversion).Append("\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  DocumentVersion: ").Append(DocumentVersion).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
