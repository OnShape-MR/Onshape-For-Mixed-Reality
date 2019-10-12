using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Common units
  /// </summary>
  [DataContract]
  public class UsersGetUserSettingsCurrentLoggedInUserResponse200CommonUnits {
    /// <summary>
    /// List of recognized units
    /// </summary>
    /// <value>List of recognized units</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public List<UsersGetUserSettingsCurrentLoggedInUserResponse200CommonUnitsUnits> Units { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetUserSettingsCurrentLoggedInUserResponse200CommonUnits {\n");
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
