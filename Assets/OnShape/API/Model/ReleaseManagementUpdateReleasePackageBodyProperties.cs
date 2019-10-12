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
  public class ReleaseManagementUpdateReleasePackageBodyProperties {
    /// <summary>
    /// The desired property value for the item
    /// </summary>
    /// <value>The desired property value for the item</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// The ID of the property of the item
    /// </summary>
    /// <value>The ID of the property of the item</value>
    [DataMember(Name="propertyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyId")]
    public string PropertyId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementUpdateReleasePackageBodyProperties {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
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
