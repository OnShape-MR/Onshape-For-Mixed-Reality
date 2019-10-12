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
  public class PartsGetPartMetadataResponse200 {
    /// <summary>
    /// Part vendor (user-specified)
    /// </summary>
    /// <value>Part vendor (user-specified)</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public string Vendor { get; set; }

    /// <summary>
    /// Part name
    /// </summary>
    /// <value>Part name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Deterministic part ID
    /// </summary>
    /// <value>Deterministic part ID</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Document microversion ID
    /// </summary>
    /// <value>Document microversion ID</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Part description (user-specified)
    /// </summary>
    /// <value>Part description (user-specified)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

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
    public PartsUpdatePartMetadataResponse200Appearance Appearance { get; set; }

    /// <summary>
    /// Part project (user-specified)
    /// </summary>
    /// <value>Part project (user-specified)</value>
    [DataMember(Name="project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project")]
    public string Project { get; set; }

    /// <summary>
    /// Part title 1 (user-specified)
    /// </summary>
    /// <value>Part title 1 (user-specified)</value>
    [DataMember(Name="title1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title1")]
    public string Title1 { get; set; }

    /// <summary>
    /// Part title 2 (user-specified)
    /// </summary>
    /// <value>Part title 2 (user-specified)</value>
    [DataMember(Name="title2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title2")]
    public string Title2 { get; set; }

    /// <summary>
    /// Part title 3 (user-specified)
    /// </summary>
    /// <value>Part title 3 (user-specified)</value>
    [DataMember(Name="title3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title3")]
    public string Title3 { get; set; }

    /// <summary>
    /// Gets or Sets CustomProperties
    /// </summary>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public PartStudiosGetMetadataResponse200CustomProperties CustomProperties { get; set; }

    /// <summary>
    /// Part product line (user-specified)
    /// </summary>
    /// <value>Part product line (user-specified)</value>
    [DataMember(Name="productLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productLine")]
    public string ProductLine { get; set; }

    /// <summary>
    /// Part number (user-specified)
    /// </summary>
    /// <value>Part number (user-specified)</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Part visibility
    /// </summary>
    /// <value>Part visibility</value>
    [DataMember(Name="isHidden", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isHidden")]
    public bool? IsHidden { get; set; }

    /// <summary>
    /// Part revision (user-specified)
    /// </summary>
    /// <value>Part revision (user-specified)</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsGetPartMetadataResponse200 {\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Material: ").Append(Material).Append("\n");
      sb.Append("  Appearance: ").Append(Appearance).Append("\n");
      sb.Append("  Project: ").Append(Project).Append("\n");
      sb.Append("  Title1: ").Append(Title1).Append("\n");
      sb.Append("  Title2: ").Append(Title2).Append("\n");
      sb.Append("  Title3: ").Append(Title3).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
      sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  IsHidden: ").Append(IsHidden).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
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
