using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Map of changes in a specific MODIFIED             part
  /// </summary>
  [DataContract]
  public class PartStudiosComparePartStudioResponse200ChangesPartsChanges {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesName Name { get; set; }

    /// <summary>
    /// Gets or Sets Geometry
    /// </summary>
    [DataMember(Name="geometry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "geometry")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesGeometry Geometry { get; set; }

    /// <summary>
    /// Gets or Sets Material
    /// </summary>
    [DataMember(Name="material", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "material")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesMaterial Material { get; set; }

    /// <summary>
    /// Gets or Sets Appearance
    /// </summary>
    [DataMember(Name="appearance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appearance")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesAppearance Appearance { get; set; }

    /// <summary>
    /// Gets or Sets Visibility
    /// </summary>
    [DataMember(Name="visibility", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visibility")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesVisibility Visibility { get; set; }

    /// <summary>
    /// Gets or Sets Other
    /// </summary>
    [DataMember(Name="other", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "other")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesOther Other { get; set; }

    /// <summary>
    /// Gets or Sets Metadata
    /// </summary>
    [DataMember(Name="metadata", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "metadata")]
    public PartStudiosComparePartStudioResponse200ChangesPartsChangesMetadata Metadata { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosComparePartStudioResponse200ChangesPartsChanges {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Geometry: ").Append(Geometry).Append("\n");
      sb.Append("  Material: ").Append(Material).Append("\n");
      sb.Append("  Appearance: ").Append(Appearance).Append("\n");
      sb.Append("  Visibility: ").Append(Visibility).Append("\n");
      sb.Append("  Other: ").Append(Other).Append("\n");
      sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
