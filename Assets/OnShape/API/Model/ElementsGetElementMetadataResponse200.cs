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
  public class ElementsGetElementMetadataResponse200 {
    /// <summary>
    /// Element vendor (user-specified)
    /// </summary>
    /// <value>Element vendor (user-specified)</value>
    [DataMember(Name="vendor", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "vendor")]
    public string Vendor { get; set; }

    /// <summary>
    /// Element name
    /// </summary>
    /// <value>Element name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Element title 3 (user-specified)
    /// </summary>
    /// <value>Element title 3 (user-specified)</value>
    [DataMember(Name="title3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title3")]
    public string Title3 { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="dataType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataType")]
    public string DataType { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="safeToShow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "safeToShow")]
    public bool? SafeToShow { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="supportsCollaboration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportsCollaboration")]
    public bool? SupportsCollaboration { get; set; }

    /// <summary>
    /// Element project (user-specified)
    /// </summary>
    /// <value>Element project (user-specified)</value>
    [DataMember(Name="project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project")]
    public string Project { get; set; }

    /// <summary>
    /// Element title 1 (user-specified)
    /// </summary>
    /// <value>Element title 1 (user-specified)</value>
    [DataMember(Name="title1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title1")]
    public string Title1 { get; set; }

    /// <summary>
    /// Element state, which can be: IN_PROGRESS, PENDING, RELEASED, OBSOLETE, UNKNOWN
    /// </summary>
    /// <value>Element state, which can be: IN_PROGRESS, PENDING, RELEASED, OBSOLETE, UNKNOWN</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Gets or Sets CustomProperties
    /// </summary>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public ElementsGetElementMetadataResponse200CustomProperties CustomProperties { get; set; }

    /// <summary>
    /// Element product line (user-specified)
    /// </summary>
    /// <value>Element product line (user-specified)</value>
    [DataMember(Name="productLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productLine")]
    public string ProductLine { get; set; }

    /// <summary>
    /// Element part number (user-specified)
    /// </summary>
    /// <value>Element part number (user-specified)</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Element revision (user-specified)
    /// </summary>
    /// <value>Element revision (user-specified)</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }

    /// <summary>
    /// Element type (PARTSTUDIO, ASSEMBLY, BLOB, etc.)
    /// </summary>
    /// <value>Element type (PARTSTUDIO, ASSEMBLY, BLOB, etc.)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// Onshape internal use
    /// </summary>
    /// <value>Onshape internal use</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Element title 2 (user-specified)
    /// </summary>
    /// <value>Element title 2 (user-specified)</value>
    [DataMember(Name="title2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title2")]
    public string Title2 { get; set; }

    /// <summary>
    /// Element description (user-specified)
    /// </summary>
    /// <value>Element description (user-specified)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementsGetElementMetadataResponse200 {\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Title3: ").Append(Title3).Append("\n");
      sb.Append("  DataType: ").Append(DataType).Append("\n");
      sb.Append("  SafeToShow: ").Append(SafeToShow).Append("\n");
      sb.Append("  SupportsCollaboration: ").Append(SupportsCollaboration).Append("\n");
      sb.Append("  Project: ").Append(Project).Append("\n");
      sb.Append("  Title1: ").Append(Title1).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
      sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  Revision: ").Append(Revision).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Title2: ").Append(Title2).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
