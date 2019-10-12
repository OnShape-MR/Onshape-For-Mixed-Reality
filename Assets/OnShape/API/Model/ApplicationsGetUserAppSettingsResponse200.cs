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
  public class ApplicationsGetUserAppSettingsResponse200 {
    /// <summary>
    /// User-specific settings for given client/user/key
    /// </summary>
    /// <value>User-specific settings for given client/user/key</value>
    [DataMember(Name="settings", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "settings")]
    public List<ApplicationsGetUserAppSettingsResponse200Settings> Settings { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ApplicationsGetUserAppSettingsResponse200 {\n");
      sb.Append("  Settings: ").Append(Settings).Append("\n");
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
