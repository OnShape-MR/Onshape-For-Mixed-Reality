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
  public class AssembliesGetBillOfMaterialsResponse200 {
    /// <summary>
    /// Gets or Sets BomTable
    /// </summary>
    [DataMember(Name="bomTable", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bomTable")]
    public AssembliesGetBillOfMaterialsResponse200BomTable BomTable { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200 {\n");
      sb.Append("  BomTable: ").Append(BomTable).Append("\n");
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
