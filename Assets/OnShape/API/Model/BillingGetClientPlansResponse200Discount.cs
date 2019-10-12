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
  public class BillingGetClientPlansResponse200Discount {
    /// <summary>
    /// coupon type
    /// </summary>
    /// <value>coupon type</value>
    [DataMember(Name="couponType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "couponType")]
    public decimal? CouponType { get; set; }

    /// <summary>
    /// percent off
    /// </summary>
    /// <value>percent off</value>
    [DataMember(Name="percentOff", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "percentOff")]
    public decimal? PercentOff { get; set; }

    /// <summary>
    /// plan Id
    /// </summary>
    /// <value>plan Id</value>
    [DataMember(Name="planId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "planId")]
    public string PlanId { get; set; }

    /// <summary>
    /// discount expires at date
    /// </summary>
    /// <value>discount expires at date</value>
    [DataMember(Name="expiresAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "expiresAt")]
    public string ExpiresAt { get; set; }

    /// <summary>
    /// discount used at date
    /// </summary>
    /// <value>discount used at date</value>
    [DataMember(Name="usedAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usedAt")]
    public string UsedAt { get; set; }

    /// <summary>
    /// coupon valid months
    /// </summary>
    /// <value>coupon valid months</value>
    [DataMember(Name="couponValidMonths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "couponValidMonths")]
    public decimal? CouponValidMonths { get; set; }

    /// <summary>
    /// account balance
    /// </summary>
    /// <value>account balance</value>
    [DataMember(Name="accountBalance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountBalance")]
    public decimal? AccountBalance { get; set; }

    /// <summary>
    /// amount off
    /// </summary>
    /// <value>amount off</value>
    [DataMember(Name="amountOff", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "amountOff")]
    public decimal? AmountOff { get; set; }

    /// <summary>
    /// end date of trial period
    /// </summary>
    /// <value>end date of trial period</value>
    [DataMember(Name="trialEndDate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "trialEndDate")]
    public string TrialEndDate { get; set; }

    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name="createdBy", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdBy")]
    public BillingGetClientPlansResponse200DiscountCreatedBy CreatedBy { get; set; }

    /// <summary>
    /// owner Id
    /// </summary>
    /// <value>owner Id</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// discount created at date
    /// </summary>
    /// <value>discount created at date</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public string CreatedAt { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BillingGetClientPlansResponse200Discount {\n");
      sb.Append("  CouponType: ").Append(CouponType).Append("\n");
      sb.Append("  PercentOff: ").Append(PercentOff).Append("\n");
      sb.Append("  PlanId: ").Append(PlanId).Append("\n");
      sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
      sb.Append("  UsedAt: ").Append(UsedAt).Append("\n");
      sb.Append("  CouponValidMonths: ").Append(CouponValidMonths).Append("\n");
      sb.Append("  AccountBalance: ").Append(AccountBalance).Append("\n");
      sb.Append("  AmountOff: ").Append(AmountOff).Append("\n");
      sb.Append("  TrialEndDate: ").Append(TrialEndDate).Append("\n");
      sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
