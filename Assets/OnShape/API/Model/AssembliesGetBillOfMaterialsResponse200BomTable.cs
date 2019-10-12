using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// BOM information
  /// </summary>
  [DataContract]
  public class AssembliesGetBillOfMaterialsResponse200BomTable {
    /// <summary>
    /// The description of the BOM. Currently empty.
    /// </summary>
    /// <value>The description of the BOM. Currently empty.</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The non-header rows of the BOM table.
    /// </summary>
    /// <value>The non-header rows of the BOM table.</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<AssembliesGetBillOfMaterialsResponse200BomTableItems> Items { get; set; }

    /// <summary>
    /// BOM table column headers
    /// </summary>
    /// <value>BOM table column headers</value>
    [DataMember(Name="headers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "headers")]
    public List<AssembliesGetBillOfMaterialsResponse200BomTableHeaders> Headers { get; set; }

    /// <summary>
    /// The version of the Onshape BOM JSON Standard that this             response complies with
    /// </summary>
    /// <value>The version of the Onshape BOM JSON Standard that this             response complies with</value>
    [DataMember(Name="formatVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatVersion")]
    public string FormatVersion { get; set; }

    /// <summary>
    /// The partNumber of the BOM. Currently empty.
    /// </summary>
    /// <value>The partNumber of the BOM. Currently empty.</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Gets or Sets BomSource
    /// </summary>
    [DataMember(Name="bomSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bomSource")]
    public AssembliesGetBillOfMaterialsResponse200BomTableBomSource BomSource { get; set; }

    /// <summary>
    /// The id of the BOM
    /// </summary>
    /// <value>The id of the BOM</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The UTC date and time the BOM data was exported.
    /// </summary>
    /// <value>The UTC date and time the BOM data was exported.</value>
    [DataMember(Name="createdAt", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "createdAt")]
    public string CreatedAt { get; set; }

    /// <summary>
    /// The name of the BOM
    /// </summary>
    /// <value>The name of the BOM</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200BomTable {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Headers: ").Append(Headers).Append("\n");
      sb.Append("  FormatVersion: ").Append(FormatVersion).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  BomSource: ").Append(BomSource).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
