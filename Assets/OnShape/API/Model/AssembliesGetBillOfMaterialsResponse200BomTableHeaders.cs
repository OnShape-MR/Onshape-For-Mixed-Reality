using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single column header in the BOM table. This will almost             always represent a metadata property.
  /// </summary>
  [DataContract]
  public class AssembliesGetBillOfMaterialsResponse200BomTableHeaders {
    /// <summary>
    /// Whether or not the header is visible in the Assembly             BOM at this time
    /// </summary>
    /// <value>Whether or not the header is visible in the Assembly             BOM at this time</value>
    [DataMember(Name="visible", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "visible")]
    public string Visible { get; set; }

    /// <summary>
    /// The field that this column will contain. The item             objects below will contain the appropriate values for this field.
    /// </summary>
    /// <value>The field that this column will contain. The item             objects below will contain the appropriate values for this field.</value>
    [DataMember(Name="propertyName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyName")]
    public string PropertyName { get; set; }

    /// <summary>
    /// The name to be displayed for this column
    /// </summary>
    /// <value>The name to be displayed for this column</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The id of the metadata property that this column             represents. Note that Item No. and Quantity are not true metadata properties.
    /// </summary>
    /// <value>The id of the metadata property that this column             represents. Note that Item No. and Quantity are not true metadata properties.</value>
    [DataMember(Name="propertyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyId")]
    public string PropertyId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200BomTableHeaders {\n");
      sb.Append("  Visible: ").Append(Visible).Append("\n");
      sb.Append("  PropertyName: ").Append(PropertyName).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
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
