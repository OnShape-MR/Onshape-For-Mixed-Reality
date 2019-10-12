using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Set of button and key presses             that zooms in 2D
  /// </summary>
  [DataContract]
  public class UsersGetUserSettingsCurrentLoggedInUserResponse200ViewManipulationMouseKeyMappingZoom2DMapping {
    /// <summary>
    /// Array of modifier keys for             set of button and key presses
    /// </summary>
    /// <value>Array of modifier keys for             set of button and key presses</value>
    [DataMember(Name="keys", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "keys")]
    public List<string> Keys { get; set; }

    /// <summary>
    /// Array of mouse             buttons for set of button and key presses
    /// </summary>
    /// <value>Array of mouse             buttons for set of button and key presses</value>
    [DataMember(Name="mouseButtons", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mouseButtons")]
    public List<string> MouseButtons { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetUserSettingsCurrentLoggedInUserResponse200ViewManipulationMouseKeyMappingZoom2DMapping {\n");
      sb.Append("  Keys: ").Append(Keys).Append("\n");
      sb.Append("  MouseButtons: ").Append(MouseButtons).Append("\n");
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
