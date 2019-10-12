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
  public class AppElementsUpdateReferenceBody {
    /// <summary>
    /// The Id of the version the document that contains the target of the           reference
    /// </summary>
    /// <value>The Id of the version the document that contains the target of the           reference</value>
    [DataMember(Name="targetVersionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetVersionId")]
    public string TargetVersionId { get; set; }

    /// <summary>
    /// Id of the prior change to the application element
    /// </summary>
    /// <value>Id of the prior change to the application element</value>
    [DataMember(Name="parentChangeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentChangeId")]
    public string ParentChangeId { get; set; }

    /// <summary>
    /// An optional deterministic id within the target element that should be tracked
    /// </summary>
    /// <value>An optional deterministic id within the target element that should be tracked</value>
    [DataMember(Name="idTag", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idTag")]
    public string IdTag { get; set; }

    /// <summary>
    /// The element Id of the element that is or contains the target of the           reference
    /// </summary>
    /// <value>The element Id of the element that is or contains the target of the           reference</value>
    [DataMember(Name="targetElementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetElementId")]
    public string TargetElementId { get; set; }

    /// <summary>
    /// An optional document microversionId that should be tracked, in           case a specific point in history should be tracked by the reference
    /// </summary>
    /// <value>An optional document microversionId that should be tracked, in           case a specific point in history should be tracked by the reference</value>
    [DataMember(Name="targetMicroversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetMicroversionId")]
    public string TargetMicroversionId { get; set; }

    /// <summary>
    /// If not blank, specifies a new configuration of the element
    /// </summary>
    /// <value>If not blank, specifies a new configuration of the element</value>
    [DataMember(Name="targetConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetConfiguration")]
    public string TargetConfiguration { get; set; }

    /// <summary>
    /// If idTag is specified, the document microversion associated with           the idTag
    /// </summary>
    /// <value>If idTag is specified, the document microversion associated with           the idTag</value>
    [DataMember(Name="idTagMicroversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "idTagMicroversionId")]
    public string IdTagMicroversionId { get; set; }

    /// <summary>
    /// Id of the transaction in which the reference update should occur
    /// </summary>
    /// <value>Id of the transaction in which the reference update should occur</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsUpdateReferenceBody {\n");
      sb.Append("  TargetVersionId: ").Append(TargetVersionId).Append("\n");
      sb.Append("  ParentChangeId: ").Append(ParentChangeId).Append("\n");
      sb.Append("  IdTag: ").Append(IdTag).Append("\n");
      sb.Append("  TargetElementId: ").Append(TargetElementId).Append("\n");
      sb.Append("  TargetMicroversionId: ").Append(TargetMicroversionId).Append("\n");
      sb.Append("  TargetConfiguration: ").Append(TargetConfiguration).Append("\n");
      sb.Append("  IdTagMicroversionId: ").Append(IdTagMicroversionId).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
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
