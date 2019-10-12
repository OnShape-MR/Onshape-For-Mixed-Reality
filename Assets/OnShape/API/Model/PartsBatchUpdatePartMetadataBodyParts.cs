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
  public class PartsBatchUpdatePartMetadataBodyParts {
    /// <summary>
    /// Part vendor
    /// </summary>
    /// <value>Part vendor</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public string Vendor { get; set; }

    /// <summary>
    /// Part description
    /// </summary>
    /// <value>Part description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Deterministic part ID of the part to update
    /// </summary>
    /// <value>Deterministic part ID of the part to update</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Gets or Sets Material
    /// </summary>
    [DataMember(Name="material", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "material")]
    public PartsBatchUpdatePartMetadataBodyMaterial Material { get; set; }

    /// <summary>
    /// Gets or Sets Appearance
    /// </summary>
    [DataMember(Name="appearance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appearance")]
    public PartsBatchUpdatePartMetadataBodyAppearance Appearance { get; set; }

    /// <summary>
    /// Part project
    /// </summary>
    /// <value>Part project</value>
    [DataMember(Name="project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project")]
    public string Project { get; set; }

    /// <summary>
    /// Part title 1
    /// </summary>
    /// <value>Part title 1</value>
    [DataMember(Name="title1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title1")]
    public string Title1 { get; set; }

    /// <summary>
    /// Part title 2
    /// </summary>
    /// <value>Part title 2</value>
    [DataMember(Name="title2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title2")]
    public string Title2 { get; set; }

    /// <summary>
    /// Part title 3
    /// </summary>
    /// <value>Part title 3</value>
    [DataMember(Name="title3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title3")]
    public string Title3 { get; set; }

    /// <summary>
    /// Custom properties
    /// </summary>
    /// <value>Custom properties</value>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public List<PartsUpdatePartMetadataBodyCustomProperties> CustomProperties { get; set; }

    /// <summary>
    /// Part product line
    /// </summary>
    /// <value>Part product line</value>
    [DataMember(Name="productLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productLine")]
    public string ProductLine { get; set; }

    /// <summary>
    /// Part number
    /// </summary>
    /// <value>Part number</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Configuration in which to apply updates
    /// </summary>
    /// <value>Configuration in which to apply updates</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// Part revision
    /// </summary>
    /// <value>Part revision</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }

    /// <summary>
    /// The element ID of the Part Studio containing the part to update
    /// </summary>
    /// <value>The element ID of the Part Studio containing the part to update</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Part name (Name can only be modified in workspace)
    /// </summary>
    /// <value>Part name (Name can only be modified in workspace)</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsBatchUpdatePartMetadataBodyParts {\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  Material: ").Append(Material).Append("\n");
      sb.Append("  Appearance: ").Append(Appearance).Append("\n");
      sb.Append("  Project: ").Append(Project).Append("\n");
      sb.Append("  Title1: ").Append(Title1).Append("\n");
      sb.Append("  Title2: ").Append(Title2).Append("\n");
      sb.Append("  Title3: ").Append(Title3).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
      sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
