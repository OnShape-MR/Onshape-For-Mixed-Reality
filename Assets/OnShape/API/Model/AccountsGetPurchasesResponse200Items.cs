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
  public class AccountsGetPurchasesResponse200Items {
    /// <summary>
    /// Plan name
    /// </summary>
    /// <value>Plan name</value>
    [DataMember(Name="planName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planName")]
    public string PlanName { get; set; }

    /// <summary>
    /// Purchase canceled at
    /// </summary>
    /// <value>Purchase canceled at</value>
    [DataMember(Name="canceledAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "canceledAt")]
    public string CanceledAt { get; set; }

    /// <summary>
    /// Consumed Ids
    /// </summary>
    /// <value>Consumed Ids</value>
    [DataMember(Name="consumedIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "consumedIds")]
    public List<string> ConsumedIds { get; set; }

    /// <summary>
    /// Group
    /// </summary>
    /// <value>Group</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// User Ids
    /// </summary>
    /// <value>User Ids</value>
    [DataMember(Name="userIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "userIds")]
    public List<string> UserIds { get; set; }

    /// <summary>
    /// Plan id
    /// </summary>
    /// <value>Plan id</value>
    [DataMember(Name="planId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planId")]
    public string PlanId { get; set; }

    /// <summary>
    /// Amount cents
    /// </summary>
    /// <value>Amount cents</value>
    [DataMember(Name="amountCents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountCents")]
    public decimal? AmountCents { get; set; }

    /// <summary>
    /// Plan type (0-RECURRING, 1-CONSUMABLE, 2-ONE_TIME)
    /// </summary>
    /// <value>Plan type (0-RECURRING, 1-CONSUMABLE, 2-ONE_TIME)</value>
    [DataMember(Name="planType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planType")]
    public decimal? PlanType { get; set; }

    /// <summary>
    /// Purchase state (1-DELETED, 2-CANCELED, 3-UNPAID, 4-PAST_DUE,             5-TRIALING, 6-ACTIVE, 7-CONSUMED)
    /// </summary>
    /// <value>Purchase state (1-DELETED, 2-CANCELED, 3-UNPAID, 4-PAST_DUE,             5-TRIALING, 6-ACTIVE, 7-CONSUMED)</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public decimal? State { get; set; }

    /// <summary>
    /// Number of seats
    /// </summary>
    /// <value>Number of seats</value>
    [DataMember(Name="seats", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "seats")]
    public decimal? Seats { get; set; }

    /// <summary>
    /// Subscription end at
    /// </summary>
    /// <value>Subscription end at</value>
    [DataMember(Name="subscriptionEndAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subscriptionEndAt")]
    public string SubscriptionEndAt { get; set; }

    /// <summary>
    /// Application Id
    /// </summary>
    /// <value>Application Id</value>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

    /// <summary>
    /// Purchase Id
    /// </summary>
    /// <value>Purchase Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Card
    /// </summary>
    [DataMember(Name="card", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "card")]
    public AccountsConsumePurchaseResponse200Card Card { get; set; }

    /// <summary>
    /// Account id
    /// </summary>
    /// <value>Account id</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public string AccountId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountsGetPurchasesResponse200Items {\n");
      sb.Append("  PlanName: ").Append(PlanName).Append("\n");
      sb.Append("  CanceledAt: ").Append(CanceledAt).Append("\n");
      sb.Append("  ConsumedIds: ").Append(ConsumedIds).Append("\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  UserIds: ").Append(UserIds).Append("\n");
      sb.Append("  PlanId: ").Append(PlanId).Append("\n");
      sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
      sb.Append("  PlanType: ").Append(PlanType).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Seats: ").Append(Seats).Append("\n");
      sb.Append("  SubscriptionEndAt: ").Append(SubscriptionEndAt).Append("\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Card: ").Append(Card).Append("\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
