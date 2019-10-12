using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Set of mouse buttons and modifier keys to manipulate view
  /// </summary>
  [DataContract]
  public class UsersGetUserSettingsResponse200ViewManipulationMouseKeyMapping {
    /// <summary>
    /// Array of sets of button and key presses that zoom in 2D
    /// </summary>
    /// <value>Array of sets of button and key presses that zoom in 2D</value>
    [DataMember(Name="zoom2DMapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zoom2DMapping")]
    public List<UsersGetUserSettingsResponse200ViewManipulationMouseKeyMappingZoom2DMapping> Zoom2DMapping { get; set; }

    /// <summary>
    /// Array of sets of button and key presses that zoom in 3D
    /// </summary>
    /// <value>Array of sets of button and key presses that zoom in 3D</value>
    [DataMember(Name="zoom3DMapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zoom3DMapping")]
    public List<UsersGetUserSettingsResponse200ViewManipulationMouseKeyMappingZoom3DMapping> Zoom3DMapping { get; set; }

    /// <summary>
    /// Array of sets of button and key presses that rotate in 3D
    /// </summary>
    /// <value>Array of sets of button and key presses that rotate in 3D</value>
    [DataMember(Name="rotate3DMapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rotate3DMapping")]
    public List<UsersGetUserSettingsResponse200ViewManipulationMouseKeyMappingRotate3DMapping> Rotate3DMapping { get; set; }

    /// <summary>
    /// Array of sets of button and key presses that pan in 3D
    /// </summary>
    /// <value>Array of sets of button and key presses that pan in 3D</value>
    [DataMember(Name="pan3DMapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pan3DMapping")]
    public List<UsersGetUserSettingsResponse200ViewManipulationMouseKeyMappingPan3DMapping> Pan3DMapping { get; set; }

    /// <summary>
    /// Array of sets of button and key presses that pan in 2D
    /// </summary>
    /// <value>Array of sets of button and key presses that pan in 2D</value>
    [DataMember(Name="pan2DMapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pan2DMapping")]
    public List<UsersGetUserSettingsResponse200ViewManipulationMouseKeyMappingPan2DMapping> Pan2DMapping { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetUserSettingsResponse200ViewManipulationMouseKeyMapping {\n");
      sb.Append("  Zoom2DMapping: ").Append(Zoom2DMapping).Append("\n");
      sb.Append("  Zoom3DMapping: ").Append(Zoom3DMapping).Append("\n");
      sb.Append("  Rotate3DMapping: ").Append(Rotate3DMapping).Append("\n");
      sb.Append("  Pan3DMapping: ").Append(Pan3DMapping).Append("\n");
      sb.Append("  Pan2DMapping: ").Append(Pan2DMapping).Append("\n");
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
