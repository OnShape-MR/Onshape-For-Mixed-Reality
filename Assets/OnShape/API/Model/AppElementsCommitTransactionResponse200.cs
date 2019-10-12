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
  public class AppElementsCommitTransactionResponse200 {
    /// <summary>
    /// The changeId of the operation on which the transaction was based
    /// </summary>
    /// <value>The changeId of the operation on which the transaction was based</value>
    [DataMember(Name="parentChangeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentChangeId")]
    public string ParentChangeId { get; set; }

    /// <summary>
    /// The id of the transaction that was committed
    /// </summary>
    /// <value>The id of the transaction that was committed</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }

    /// <summary>
    /// The elementId of the element
    /// </summary>
    /// <value>The elementId of the element</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// The changeId representing the element state after the commit
    /// </summary>
    /// <value>The changeId representing the element state after the commit</value>
    [DataMember(Name="changeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeId")]
    public string ChangeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsCommitTransactionResponse200 {\n");
      sb.Append("  ParentChangeId: ").Append(ParentChangeId).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
