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
  public class AppElementsUpdateElementBody {
    /// <summary>
    /// Id of the last change made by this application to this element
    /// </summary>
    /// <value>Id of the last change made by this application to this element</value>
    [DataMember(Name="parentChangeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentChangeId")]
    public string ParentChangeId { get; set; }

    /// <summary>
    /// Id of transaction in which the update should be performed
    /// </summary>
    /// <value>Id of transaction in which the update should be performed</value>
    [DataMember(Name="transactionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transactionId")]
    public string TransactionId { get; set; }

    /// <summary>
    /// List of changes to make to the application element
    /// </summary>
    /// <value>List of changes to make to the application element</value>
    [DataMember(Name="changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changes")]
    public List<AppElementsUpdateElementBodyChanges> Changes { get; set; }

    /// <summary>
    /// Description of the change being made, for history tracking
    /// </summary>
    /// <value>Description of the change being made, for history tracking</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsUpdateElementBody {\n");
      sb.Append("  ParentChangeId: ").Append(ParentChangeId).Append("\n");
      sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
