using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single property
  /// </summary>
  [DataContract]
  public class ReleaseManagementCreateReleasePackageResponse200Properties {
    /// <summary>
    /// User friendly name of the property
    /// </summary>
    /// <value>User friendly name of the property</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The value type of the property STRING BOOLEAN etc
    /// </summary>
    /// <value>The value type of the property STRING BOOLEAN etc</value>
    [DataMember(Name="valueType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueType")]
    public string ValueType { get; set; }

    /// <summary>
    /// Whether the property is required.
    /// </summary>
    /// <value>Whether the property is required.</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Whether the property is editable
    /// </summary>
    /// <value>Whether the property is editable</value>
    [DataMember(Name="editable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editable")]
    public bool? Editable { get; set; }

    /// <summary>
    /// The current value of the property
    /// </summary>
    /// <value>The current value of the property</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public string Value { get; set; }

    /// <summary>
    /// ID of the property to be used when updating
    /// </summary>
    /// <value>ID of the property to be used when updating</value>
    [DataMember(Name="propertyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyId")]
    public string PropertyId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementCreateReleasePackageResponse200Properties {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  Editable: ").Append(Editable).Append("\n");
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
