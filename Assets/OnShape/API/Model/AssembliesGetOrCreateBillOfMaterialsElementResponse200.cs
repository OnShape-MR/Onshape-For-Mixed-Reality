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
  public class AssembliesGetOrCreateBillOfMaterialsElementResponse200 {
    /// <summary>
    /// Element name
    /// </summary>
    /// <value>Element name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// object containing information about the retrieved Bill Of Materials element
    /// </summary>
    /// <value>object containing information about the retrieved Bill Of Materials element</value>
    [DataMember(Name="An", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "An")]
    public Object An { get; set; }

    /// <summary>
    /// The current element microversion id
    /// </summary>
    /// <value>The current element microversion id</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Element type (will always be \"BILLOFMATERIALS\")
    /// </summary>
    /// <value>Element type (will always be \"BILLOFMATERIALS\")</value>
    [DataMember(Name="elementType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementType")]
    public string ElementType { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetOrCreateBillOfMaterialsElementResponse200 {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  An: ").Append(An).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  ElementType: ").Append(ElementType).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
