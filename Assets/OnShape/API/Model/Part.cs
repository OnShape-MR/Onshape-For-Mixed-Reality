using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual part
  /// </summary>
  [DataContract]
  public class Part {
    /// <summary>
    /// Part body type; can be 'solid', 'surface', or 'wire'
    /// </summary>
    /// <value>Part body type; can be 'solid', 'surface', or 'wire'</value>
    [DataMember(Name="bodyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bodyType")]
    public string BodyType { get; set; }

    /// <summary>
    /// Part name
    /// </summary>
    /// <value>Part name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Part ID
    /// </summary>
    /// <value>Part ID</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="partQuery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partQuery")]
    public string PartQuery { get; set; }

    /// <summary>
    /// Gets or Sets Material
    /// </summary>
    [DataMember(Name="material", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "material")]
    public PartMaterial Material { get; set; }

    /// <summary>
    /// Gets or Sets Appearance
    /// </summary>
    [DataMember(Name="appearance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appearance")]
    public PartAppearance Appearance { get; set; }

    /// <summary>
    /// Document microversion ID
    /// </summary>
    /// <value>Document microversion ID</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Custom properties, if any
    /// </summary>
    /// <value>Custom properties, if any</value>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public Object CustomProperties { get; set; }

    /// <summary>
    /// Whether the part is a mesh
    /// </summary>
    /// <value>Whether the part is a mesh</value>
    [DataMember(Name="isMesh", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isMesh")]
    public bool? IsMesh { get; set; }

    /// <summary>
    /// Part visibility
    /// </summary>
    /// <value>Part visibility</value>
    [DataMember(Name="isHidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class Part {\n");
      sb.Append("  BodyType: ").Append(BodyType).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  PartQuery: ").Append(PartQuery).Append("\n");
      sb.Append("  Material: ").Append(Material).Append("\n");
      sb.Append("  Appearance: ").Append(Appearance).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
      sb.Append("  IsMesh: ").Append(IsMesh).Append("\n");
      sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
