using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// User default units
  /// </summary>
  [DataContract]
  public class UsersGetUserSettingsCurrentLoggedInUserResponse200DefaultUnits {
    /// <summary>
    /// Gets or Sets Units
    /// </summary>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public UsersGetUserSettingsCurrentLoggedInUserResponse200DefaultUnitsUnits Units { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetUserSettingsCurrentLoggedInUserResponse200DefaultUnits {\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
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
