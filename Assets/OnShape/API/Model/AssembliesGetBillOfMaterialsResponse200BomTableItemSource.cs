using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An additional object that every item has, containing             information about the source of the item
  /// </summary>
  [DataContract]
  public class AssembliesGetBillOfMaterialsResponse200BomTableItemSource {
    /// <summary>
    /// The id of the element in the workspace or             version of the document containing the item
    /// </summary>
    /// <value>The id of the element in the workspace or             version of the document containing the item</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// The id of the part for this item. Will be             blank if the item is not a part
    /// </summary>
    /// <value>The id of the part for this item. Will be             blank if the item is not a part</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// \"v\" if the item is from a version or \"w\" if             it is from a workspace
    /// </summary>
    /// <value>\"v\" if the item is from a version or \"w\" if             it is from a workspace</value>
    [DataMember(Name="wvmType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wvmType")]
    public string WvmType { get; set; }

    /// <summary>
    /// The id of the version or workspace containing             the item
    /// </summary>
    /// <value>The id of the version or workspace containing             the item</value>
    [DataMember(Name="wvmId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "wvmId")]
    public string WvmId { get; set; }

    /// <summary>
    /// The id of the onshape document containing             this item
    /// </summary>
    /// <value>The id of the onshape document containing             this item</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200BomTableItemSource {\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  WvmType: ").Append(WvmType).Append("\n");
      sb.Append("  WvmId: ").Append(WvmId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
