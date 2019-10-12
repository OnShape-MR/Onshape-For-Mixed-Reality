using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single row of the BOM table. The object contains a key and a             value for every propertyName defined by the headers above.
  /// </summary>
  [DataContract]
  public class AssembliesGetBillOfMaterialsResponse200BomTableItems {
    /// <summary>
    /// Gets or Sets ItemSource
    /// </summary>
    [DataMember(Name="itemSource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "itemSource")]
    public AssembliesGetBillOfMaterialsResponse200BomTableItemSource ItemSource { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200BomTableItems {\n");
      sb.Append("  ItemSource: ").Append(ItemSource).Append("\n");
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
