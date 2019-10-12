using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual element
  /// </summary>
  [DataContract]
  public class DocumentsGetElementListResponse200Elements {
    /// <summary>
    /// Angle units, for Part Studio and Assembly elements only
    /// </summary>
    /// <value>Angle units, for Part Studio and Assembly elements only</value>
    [DataMember(Name="angleUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "angleUnits")]
    public string AngleUnits { get; set; }

    /// <summary>
    /// Mass units, for Part Studio and Assembly elements only
    /// </summary>
    /// <value>Mass units, for Part Studio and Assembly elements only</value>
    [DataMember(Name="massUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "massUnits")]
    public string MassUnits { get; set; }

    /// <summary>
    /// Element name
    /// </summary>
    /// <value>Element name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Thumbnail information
    /// </summary>
    /// <value>Thumbnail information</value>
    [DataMember(Name="thumbnailInfo", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnailInfo")]
    public DocumentsGetDocumentsResponse200Items ThumbnailInfo { get; set; }

    /// <summary>
    /// Length units, for Part Studio and Assembly elements only
    /// </summary>
    /// <value>Length units, for Part Studio and Assembly elements only</value>
    [DataMember(Name="lengthUnits", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "lengthUnits")]
    public string LengthUnits { get; set; }

    /// <summary>
    /// Element type (for example, \"PARTSTUDIO\")
    /// </summary>
    /// <value>Element type (for example, \"PARTSTUDIO\")</value>
    [DataMember(Name="elementType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementType")]
    public string ElementType { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="thumbnails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnails")]
    public Object Thumbnails { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetElementListResponse200Elements {\n");
      sb.Append("  AngleUnits: ").Append(AngleUnits).Append("\n");
      sb.Append("  MassUnits: ").Append(MassUnits).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ThumbnailInfo: ").Append(ThumbnailInfo).Append("\n");
      sb.Append("  LengthUnits: ").Append(LengthUnits).Append("\n");
      sb.Append("  ElementType: ").Append(ElementType).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Thumbnails: ").Append(Thumbnails).Append("\n");
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
