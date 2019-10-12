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
  public class AppElementsResolveReferenceResponse200 {
    /// <summary>
    /// The document microversion contained in the             reference, or the current document microversion if not set in the reference
    /// </summary>
    /// <value>The document microversion contained in the             reference, or the current document microversion if not set in the reference</value>
    [DataMember(Name="resolvedDocumentMicroversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resolvedDocumentMicroversionId")]
    public string ResolvedDocumentMicroversionId { get; set; }

    /// <summary>
    /// The id of the retrieved reference
    /// </summary>
    /// <value>The id of the retrieved reference</value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// The Id of the version of the document contained in the reference
    /// </summary>
    /// <value>The Id of the version of the document contained in the reference</value>
    [DataMember(Name="targetVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetVersionId")]
    public string TargetVersionId { get; set; }

    /// <summary>
    /// for internal use
    /// </summary>
    /// <value>for internal use</value>
    [DataMember(Name="trackNewVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trackNewVersions")]
    public bool? TrackNewVersions { get; set; }

    /// <summary>
    /// The idTag of a target within the target element
    /// </summary>
    /// <value>The idTag of a target within the target element</value>
    [DataMember(Name="idTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idTag")]
    public string IdTag { get; set; }

    /// <summary>
    /// The id of the referenced element
    /// </summary>
    /// <value>The id of the referenced element</value>
    [DataMember(Name="targetElementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetElementId")]
    public string TargetElementId { get; set; }

    /// <summary>
    /// The Id of the document contained in the reference
    /// </summary>
    /// <value>The Id of the document contained in the reference</value>
    [DataMember(Name="targetDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetDocumentId")]
    public string TargetDocumentId { get; set; }

    /// <summary>
    /// The document microversion contained in the             reference, if set
    /// </summary>
    /// <value>The document microversion contained in the             reference, if set</value>
    [DataMember(Name="targetDocumentMicroversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetDocumentMicroversionId")]
    public string TargetDocumentMicroversionId { get; set; }

    /// <summary>
    /// The configuration string for the target element
    /// </summary>
    /// <value>The configuration string for the target element</value>
    [DataMember(Name="targetConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetConfiguration")]
    public string TargetConfiguration { get; set; }

    /// <summary>
    /// Set to true if the idTag value is valid
    /// </summary>
    /// <value>Set to true if the idTag value is valid</value>
    [DataMember(Name="idTagIsValid", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idTagIsValid")]
    public string IdTagIsValid { get; set; }

    /// <summary>
    /// The changeId of the creation operation
    /// </summary>
    /// <value>The changeId of the creation operation</value>
    [DataMember(Name="changeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeId")]
    public string ChangeId { get; set; }

    /// <summary>
    /// True if the element configuration can be changed to a             non-default value
    /// </summary>
    /// <value>True if the element configuration can be changed to a             non-default value</value>
    [DataMember(Name="isConfigurable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isConfigurable")]
    public bool? IsConfigurable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsResolveReferenceResponse200 {\n");
      sb.Append("  ResolvedDocumentMicroversionId: ").Append(ResolvedDocumentMicroversionId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  TargetVersionId: ").Append(TargetVersionId).Append("\n");
      sb.Append("  TrackNewVersions: ").Append(TrackNewVersions).Append("\n");
      sb.Append("  IdTag: ").Append(IdTag).Append("\n");
      sb.Append("  TargetElementId: ").Append(TargetElementId).Append("\n");
      sb.Append("  TargetDocumentId: ").Append(TargetDocumentId).Append("\n");
      sb.Append("  TargetDocumentMicroversionId: ").Append(TargetDocumentMicroversionId).Append("\n");
      sb.Append("  TargetConfiguration: ").Append(TargetConfiguration).Append("\n");
      sb.Append("  IdTagIsValid: ").Append(IdTagIsValid).Append("\n");
      sb.Append("  ChangeId: ").Append(ChangeId).Append("\n");
      sb.Append("  IsConfigurable: ").Append(IsConfigurable).Append("\n");
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
