using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Tessellated entity
  /// </summary>
  [DataContract]
  public class PartStudiosGetTessellatedEntitiesResponse200SketchEntities {
    /// <summary>
    /// ID of a sketch entity
    /// </summary>
    /// <value>ID of a sketch entity</value>
    [DataMember(Name="entityId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityId")]
    public string EntityId { get; set; }

    /// <summary>
    /// Vertices of a sketch entity
    /// </summary>
    /// <value>Vertices of a sketch entity</value>
    [DataMember(Name="tessellationPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "tessellationPoints")]
    public List<List<decimal?>> TessellationPoints { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetTessellatedEntitiesResponse200SketchEntities {\n");
      sb.Append("  EntityId: ").Append(EntityId).Append("\n");
      sb.Append("  TessellationPoints: ").Append(TessellationPoints).Append("\n");
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
