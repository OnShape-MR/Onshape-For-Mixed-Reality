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
  public class BillingGetClientPlansResponse200Items {
    /// <summary>
    /// Plan group
    /// </summary>
    /// <value>Plan group</value>
    [DataMember(Name="group", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "group")]
    public string Group { get; set; }

    /// <summary>
    /// Plan description
    /// </summary>
    /// <value>Plan description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// plan type (0-RECURRING, 1-CONSUMABLE, 2-ONE_TIME)
    /// </summary>
    /// <value>plan type (0-RECURRING, 1-CONSUMABLE, 2-ONE_TIME)</value>
    [DataMember(Name="planType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planType")]
    public decimal? PlanType { get; set; }

    /// <summary>
    /// trial period days
    /// </summary>
    /// <value>trial period days</value>
    [DataMember(Name="trialPeriodDays", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trialPeriodDays")]
    public decimal? TrialPeriodDays { get; set; }

    /// <summary>
    /// Amount in cents
    /// </summary>
    /// <value>Amount in cents</value>
    [DataMember(Name="amountCents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountCents")]
    public decimal? AmountCents { get; set; }

    /// <summary>
    /// charge interval month or year
    /// </summary>
    /// <value>charge interval month or year</value>
    [DataMember(Name="interval", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interval")]
    public string Interval { get; set; }

    /// <summary>
    /// Gets or Sets Discount
    /// </summary>
    [DataMember(Name="discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discount")]
    public BillingGetClientPlansResponse200Discount Discount { get; set; }

    /// <summary>
    /// Information about discount
    /// </summary>
    /// <value>Information about discount</value>
    [DataMember(Name="discountInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "discountInfo")]
    public Object DiscountInfo { get; set; }

    /// <summary>
    /// is hidden
    /// </summary>
    /// <value>is hidden</value>
    [DataMember(Name="hidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "hidden")]
    public bool? Hidden { get; set; }

    /// <summary>
    /// application id
    /// </summary>
    /// <value>application id</value>
    [DataMember(Name="applicationId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "applicationId")]
    public string ApplicationId { get; set; }

    /// <summary>
    /// plan Id
    /// </summary>
    /// <value>plan Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetClientPlansResponse200Items {\n");
      sb.Append("  Group: ").Append(Group).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  PlanType: ").Append(PlanType).Append("\n");
      sb.Append("  TrialPeriodDays: ").Append(TrialPeriodDays).Append("\n");
      sb.Append("  AmountCents: ").Append(AmountCents).Append("\n");
      sb.Append("  Interval: ").Append(Interval).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  DiscountInfo: ").Append(DiscountInfo).Append("\n");
      sb.Append("  Hidden: ").Append(Hidden).Append("\n");
      sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
