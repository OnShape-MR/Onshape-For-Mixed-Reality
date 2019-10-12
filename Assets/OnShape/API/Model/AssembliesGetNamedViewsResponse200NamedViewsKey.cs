using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An object representing a view
  /// </summary>
  [DataContract]
  public class AssembliesGetNamedViewsResponse200NamedViewsKey {
    /// <summary>
    /// The viewport of the camera of the view
    /// </summary>
    /// <value>The viewport of the camera of the view</value>
    [DataMember(Name="cameraViewport", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "cameraViewport")]
    public List<decimal?> CameraViewport { get; set; }

    /// <summary>
    /// A 16-element array storing the view matrix of the view
    /// </summary>
    /// <value>A 16-element array storing the view matrix of the view</value>
    [DataMember(Name="viewMatrix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewMatrix")]
    public List<decimal?> ViewMatrix { get; set; }

    /// <summary>
    /// The angle of the view
    /// </summary>
    /// <value>The angle of the view</value>
    [DataMember(Name="angle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "angle")]
    public decimal? Angle { get; set; }

    /// <summary>
    /// Whether or not the view is in perspective mode
    /// </summary>
    /// <value>Whether or not the view is in perspective mode</value>
    [DataMember(Name="perspective", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "perspective")]
    public bool? Perspective { get; set; }

    /// <summary>
    /// An array of objects that represent the section planes in the view
    /// </summary>
    /// <value>An array of objects that represent the section planes in the view</value>
    [DataMember(Name="sectionPlanes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sectionPlanes")]
    public List<AssembliesGetNamedViewsResponse200NamedViewsKeySectionPlanes> SectionPlanes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetNamedViewsResponse200NamedViewsKey {\n");
      sb.Append("  CameraViewport: ").Append(CameraViewport).Append("\n");
      sb.Append("  ViewMatrix: ").Append(ViewMatrix).Append("\n");
      sb.Append("  Angle: ").Append(Angle).Append("\n");
      sb.Append("  Perspective: ").Append(Perspective).Append("\n");
      sb.Append("  SectionPlanes: ").Append(SectionPlanes).Append("\n");
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
