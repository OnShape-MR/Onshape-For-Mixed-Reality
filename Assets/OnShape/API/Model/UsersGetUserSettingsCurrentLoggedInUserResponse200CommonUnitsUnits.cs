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
  public class UsersGetUserSettingsCurrentLoggedInUserResponse200CommonUnitsUnits {
    /// <summary>
    /// Unit abbreviation
    /// </summary>
    /// <value>Unit abbreviation</value>
    [DataMember(Name="abbreviation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "abbreviation")]
    public Object Abbreviation { get; set; }

    /// <summary>
    /// Type of unit, currently LENGTH, ANGLE or MASS
    /// </summary>
    /// <value>Type of unit, currently LENGTH, ANGLE or MASS</value>
    [DataMember(Name="unitType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitType")]
    public string UnitType { get; set; }

    /// <summary>
    /// Conversion factor
    /// </summary>
    /// <value>Conversion factor</value>
    [DataMember(Name="valueInBaseUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueInBaseUnits")]
    public decimal? ValueInBaseUnits { get; set; }

    /// <summary>
    /// Unit identifier
    /// </summary>
    /// <value>Unit identifier</value>
    [DataMember(Name="unit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unit")]
    public string Unit { get; set; }

    /// <summary>
    /// Unit name
    /// </summary>
    /// <value>Unit name</value>
    [DataMember(Name="unitName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "unitName")]
    public string UnitName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetUserSettingsCurrentLoggedInUserResponse200CommonUnitsUnits {\n");
      sb.Append("  Abbreviation: ").Append(Abbreviation).Append("\n");
      sb.Append("  UnitType: ").Append(UnitType).Append("\n");
      sb.Append("  ValueInBaseUnits: ").Append(ValueInBaseUnits).Append("\n");
      sb.Append("  Unit: ").Append(Unit).Append("\n");
      sb.Append("  UnitName: ").Append(UnitName).Append("\n");
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
