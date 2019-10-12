using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Card information
  /// </summary>
  [DataContract]
  public class AccountsConsumePurchaseResponse200Card {
    /// <summary>
    /// Card last four digits
    /// </summary>
    /// <value>Card last four digits</value>
    [DataMember(Name="last4", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "last4")]
    public string Last4 { get; set; }

    /// <summary>
    /// Card expiration month
    /// </summary>
    /// <value>Card expiration month</value>
    [DataMember(Name="expMonth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expMonth")]
    public decimal? ExpMonth { get; set; }

    /// <summary>
    /// Card type
    /// </summary>
    /// <value>Card type</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Card expiration year
    /// </summary>
    /// <value>Card expiration year</value>
    [DataMember(Name="expYear", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expYear")]
    public decimal? ExpYear { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountsConsumePurchaseResponse200Card {\n");
      sb.Append("  Last4: ").Append(Last4).Append("\n");
      sb.Append("  ExpMonth: ").Append(ExpMonth).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  ExpYear: ").Append(ExpYear).Append("\n");
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
