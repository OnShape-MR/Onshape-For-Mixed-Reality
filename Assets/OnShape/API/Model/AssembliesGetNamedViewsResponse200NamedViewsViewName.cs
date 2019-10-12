using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// a named view entry. the viewName key is the name of the view
  /// </summary>
  [DataContract]
  public class AssembliesGetNamedViewsResponse200NamedViewsViewName {
    /// <summary>
    /// the viewport used by the camera for this view
    /// </summary>
    /// <value>the viewport used by the camera for this view</value>
    [DataMember(Name="cameraViewport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cameraViewport")]
    public List<decimal?> CameraViewport { get; set; }

    /// <summary>
    /// the view matrix
    /// </summary>
    /// <value>the view matrix</value>
    [DataMember(Name="viewMatrix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewMatrix")]
    public List<decimal?> ViewMatrix { get; set; }

    /// <summary>
    /// true if this is a perspective projection
    /// </summary>
    /// <value>true if this is a perspective projection</value>
    [DataMember(Name="isPerspective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isPerspective")]
    public bool? IsPerspective { get; set; }

    /// <summary>
    /// the angle used for the perspective projection if applicable
    /// </summary>
    /// <value>the angle used for the perspective projection if applicable</value>
    [DataMember(Name="angle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "angle")]
    public decimal? Angle { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetNamedViewsResponse200NamedViewsViewName {\n");
      sb.Append("  CameraViewport: ").Append(CameraViewport).Append("\n");
      sb.Append("  ViewMatrix: ").Append(ViewMatrix).Append("\n");
      sb.Append("  IsPerspective: ").Append(IsPerspective).Append("\n");
      sb.Append("  Angle: ").Append(Angle).Append("\n");
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
