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
  public class UsersGetUserSettingsCurrentLoggedInUserResponse200 {
    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="viewMappingId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewMappingId")]
    public decimal? ViewMappingId { get; set; }

    /// <summary>
    /// Gets or Sets ViewManipulationMouseKeyMapping
    /// </summary>
    [DataMember(Name="viewManipulationMouseKeyMapping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewManipulationMouseKeyMapping")]
    public UsersGetUserSettingsCurrentLoggedInUserResponse200ViewManipulationMouseKeyMapping ViewManipulationMouseKeyMapping { get; set; }

    /// <summary>
    /// Locale and language in which user uses Onshape
    /// </summary>
    /// <value>Locale and language in which user uses Onshape</value>
    [DataMember(Name="locale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "locale")]
    public string Locale { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="drawingBackgroundId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "drawingBackgroundId")]
    public decimal? DrawingBackgroundId { get; set; }

    /// <summary>
    /// Gets or Sets CommonUnits
    /// </summary>
    [DataMember(Name="commonUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "commonUnits")]
    public UsersGetUserSettingsCurrentLoggedInUserResponse200CommonUnits CommonUnits { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="enforceApplicationAcl", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enforceApplicationAcl")]
    public bool? EnforceApplicationAcl { get; set; }

    /// <summary>
    /// Gets or Sets DefaultUnits
    /// </summary>
    [DataMember(Name="defaultUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultUnits")]
    public UsersGetUserSettingsCurrentLoggedInUserResponse200DefaultUnits DefaultUnits { get; set; }

    /// <summary>
    /// Onshape internal use (deprecated)
    /// </summary>
    /// <value>Onshape internal use (deprecated)</value>
    [DataMember(Name="mouseActions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mouseActions")]
    public string MouseActions { get; set; }

    /// <summary>
    /// Whether scroll wheel zoom direction is reversed             (default: scroll forward to zoom in)
    /// </summary>
    /// <value>Whether scroll wheel zoom direction is reversed             (default: scroll forward to zoom in)</value>
    [DataMember(Name="reverseScrollWheelZoomDirection", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "reverseScrollWheelZoomDirection")]
    public bool? ReverseScrollWheelZoomDirection { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UsersGetUserSettingsCurrentLoggedInUserResponse200 {\n");
      sb.Append("  ViewMappingId: ").Append(ViewMappingId).Append("\n");
      sb.Append("  ViewManipulationMouseKeyMapping: ").Append(ViewManipulationMouseKeyMapping).Append("\n");
      sb.Append("  Locale: ").Append(Locale).Append("\n");
      sb.Append("  DrawingBackgroundId: ").Append(DrawingBackgroundId).Append("\n");
      sb.Append("  CommonUnits: ").Append(CommonUnits).Append("\n");
      sb.Append("  EnforceApplicationAcl: ").Append(EnforceApplicationAcl).Append("\n");
      sb.Append("  DefaultUnits: ").Append(DefaultUnits).Append("\n");
      sb.Append("  MouseActions: ").Append(MouseActions).Append("\n");
      sb.Append("  ReverseScrollWheelZoomDirection: ").Append(ReverseScrollWheelZoomDirection).Append("\n");
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
