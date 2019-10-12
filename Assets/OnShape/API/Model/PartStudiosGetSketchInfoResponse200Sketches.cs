using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual sketch in a part studio
  /// </summary>
  [DataContract]
  public class PartStudiosGetSketchInfoResponse200Sketches {
    /// <summary>
    /// ID of a sketch
    /// </summary>
    /// <value>ID of a sketch</value>
    [DataMember(Name="featureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureId")]
    public string FeatureId { get; set; }

    /// <summary>
    /// A transformation matrix to of the sketch plane,    if output3D is false.
    /// </summary>
    /// <value>A transformation matrix to of the sketch plane,    if output3D is false.</value>
    [DataMember(Name="transformMatrix", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "transformMatrix")]
    public List<decimal?> TransformMatrix { get; set; }

    /// <summary>
    /// Name of a sketch
    /// </summary>
    /// <value>Name of a sketch</value>
    [DataMember(Name="sketch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sketch")]
    public string Sketch { get; set; }

    /// <summary>
    /// Geometries of sketch entities.
    /// </summary>
    /// <value>Geometries of sketch entities.</value>
    [DataMember(Name="geomEntities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geomEntities")]
    public List<PartStudiosGetSketchInfoResponse200GeomEntities> GeomEntities { get; set; }

    /// <summary>
    /// Names of the features using the sketch
    /// </summary>
    /// <value>Names of the features using the sketch</value>
    [DataMember(Name="featuresUsed", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featuresUsed")]
    public List<Object> FeaturesUsed { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetSketchInfoResponse200Sketches {\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  TransformMatrix: ").Append(TransformMatrix).Append("\n");
      sb.Append("  Sketch: ").Append(Sketch).Append("\n");
      sb.Append("  GeomEntities: ").Append(GeomEntities).Append("\n");
      sb.Append("  FeaturesUsed: ").Append(FeaturesUsed).Append("\n");
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
