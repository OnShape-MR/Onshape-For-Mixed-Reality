using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Describes the document, version/workspace, and element that             the BOM was created from
  /// </summary>
  [DataContract]
  public class AssembliesGetBillOfMaterialsResponse200BomTableBomSource {
    /// <summary>
    /// Gets or Sets Document
    /// </summary>
    [DataMember(Name="document", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "document")]
    public AssembliesGetBillOfMaterialsResponse200BomTableBomSourceDocument Document { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public AssembliesGetBillOfMaterialsResponse200BomTableBomSourceVersion Version { get; set; }

    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    [DataMember(Name="workspace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspace")]
    public AssembliesGetBillOfMaterialsResponse200BomTableBomSourceWorkspace Workspace { get; set; }

    /// <summary>
    /// Gets or Sets Element
    /// </summary>
    [DataMember(Name="element", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "element")]
    public AssembliesGetBillOfMaterialsResponse200BomTableBomSourceElement Element { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200BomTableBomSource {\n");
      sb.Append("  Document: ").Append(Document).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Workspace: ").Append(Workspace).Append("\n");
      sb.Append("  Element: ").Append(Element).Append("\n");
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
