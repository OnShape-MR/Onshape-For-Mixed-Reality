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
  public class AppElementsCreateReferenceResponse200 {
    /// <summary>
    /// The changeId of the element state prior to the reference creation
    /// </summary>
    /// <value>The changeId of the element state prior to the reference creation</value>
    [DataMember(Name="parentChangeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentChangeId")]
    public string ParentChangeId { get; set; }

    /// <summary>
    /// The id of the transaction in which the reference was created
    /// </summary>
    /// <value>The id of the transaction in which the reference was created</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }

    /// <summary>
    /// The id of the reference that was created
    /// </summary>
    /// <value>The id of the reference that was created</value>
    [DataMember(Name="referenceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "referenceId")]
    public string ReferenceId { get; set; }

    /// <summary>
    /// The changeId representing the element state after the reference creation
    /// </summary>
    /// <value>The changeId representing the element state after the reference creation</value>
    [DataMember(Name="changeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeId")]
    public string ChangeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsCreateReferenceResponse200 {\n");
      sb.Append("  ParentChangeId: ").Append(ParentChangeId).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  ReferenceId: ").Append(ReferenceId).Append("\n");
      sb.Append("  ChangeId: ").Append(ChangeId).Append("\n");
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
