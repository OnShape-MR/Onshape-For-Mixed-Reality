using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An object containing information about the source             element of the bom
  /// </summary>
  [DataContract]
  public class AssembliesGetBillOfMaterialsResponse200BomTableBomSourceElement {
    /// <summary>
    /// The description of the element the bom is             created from
    /// </summary>
    /// <value>The description of the element the bom is             created from</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// The name of the element the bom is created from
    /// </summary>
    /// <value>The name of the element the bom is created from</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// The state of the element the bom is created             from. Current possible values are: In progress, Pending, Released, or Obsolete.
    /// </summary>
    /// <value>The state of the element the bom is created             from. Current possible values are: In progress, Pending, Released, or Obsolete.</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// The part number of the element the bom is             created from
    /// </summary>
    /// <value>The part number of the element the bom is             created from</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// The type of the source element. Currently always             'Assembly'
    /// </summary>
    /// <value>The type of the source element. Currently always             'Assembly'</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// The id of the element the bom is created from
    /// </summary>
    /// <value>The id of the element the bom is created from</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The revision of the element the bom is             created from
    /// </summary>
    /// <value>The revision of the element the bom is             created from</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetBillOfMaterialsResponse200BomTableBomSourceElement {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
