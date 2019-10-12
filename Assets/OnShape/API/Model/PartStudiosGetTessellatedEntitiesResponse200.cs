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
  public class PartStudiosGetTessellatedEntitiesResponse200 {
    /// <summary>
    /// Error message, if any
    /// </summary>
    /// <value>Error message, if any</value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Sketch in a studio
    /// </summary>
    /// <value>Sketch in a studio</value>
    [DataMember(Name="sketch", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sketch")]
    public Object Sketch { get; set; }

    /// <summary>
    /// Sketch ID
    /// </summary>
    /// <value>Sketch ID</value>
    [DataMember(Name="sketchId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sketchId")]
    public string SketchId { get; set; }

    /// <summary>
    /// Array of sketch entities
    /// </summary>
    /// <value>Array of sketch entities</value>
    [DataMember(Name="sketchEntities", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sketchEntities")]
    public List<PartStudiosGetTessellatedEntitiesResponse200SketchEntities> SketchEntities { get; set; }

    /// <summary>
    /// Sketch name
    /// </summary>
    /// <value>Sketch name</value>
    [DataMember(Name="sketchName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sketchName")]
    public string SketchName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetTessellatedEntitiesResponse200 {\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  Sketch: ").Append(Sketch).Append("\n");
      sb.Append("  SketchId: ").Append(SketchId).Append("\n");
      sb.Append("  SketchEntities: ").Append(SketchEntities).Append("\n");
      sb.Append("  SketchName: ").Append(SketchName).Append("\n");
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
