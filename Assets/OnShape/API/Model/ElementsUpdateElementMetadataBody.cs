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
  public class ElementsUpdateElementMetadataBody {
    /// <summary>
    /// Element vendor (Assembly only)
    /// </summary>
    /// <value>Element vendor (Assembly only)</value>
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
    /// Element description
    /// </summary>
    /// <value>Element description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Element state, which can be: IN_PROGRESS, PENDING, RELEASED, OBSOLETE, UNKNOWN
    /// </summary>
    /// <value>Element state, which can be: IN_PROGRESS, PENDING, RELEASED, OBSOLETE, UNKNOWN</value>
    [DataMember(Name="state", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "state")]
    public string State { get; set; }

    /// <summary>
    /// Element project (Assembly only)
    /// </summary>
    /// <value>Element project (Assembly only)</value>
    [DataMember(Name="project", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "project")]
    public string Project { get; set; }

    /// <summary>
    /// Element title 1
    /// </summary>
    /// <value>Element title 1</value>
    [DataMember(Name="title1", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title1")]
    public string Title1 { get; set; }

    /// <summary>
    /// Element title 2
    /// </summary>
    /// <value>Element title 2</value>
    [DataMember(Name="title2", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title2")]
    public string Title2 { get; set; }

    /// <summary>
    /// Element title 3
    /// </summary>
    /// <value>Element title 3</value>
    [DataMember(Name="title3", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "title3")]
    public string Title3 { get; set; }

    /// <summary>
    /// Custom properties
    /// </summary>
    /// <value>Custom properties</value>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public List<ElementsUpdateElementMetadataBodyCustomProperties> CustomProperties { get; set; }

    /// <summary>
    /// Element product line (Assembly only)
    /// </summary>
    /// <value>Element product line (Assembly only)</value>
    [DataMember(Name="productLine", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productLine")]
    public string ProductLine { get; set; }

    /// <summary>
    /// Element part number (arbitrary string)
    /// </summary>
    /// <value>Element part number (arbitrary string)</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Element revision (arbitrary string)
    /// </summary>
    /// <value>Element revision (arbitrary string)</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementsUpdateElementMetadataBody {\n");
      sb.Append("  Vendor: ").Append(Vendor).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  State: ").Append(State).Append("\n");
      sb.Append("  Project: ").Append(Project).Append("\n");
      sb.Append("  Title1: ").Append(Title1).Append("\n");
      sb.Append("  Title2: ").Append(Title2).Append("\n");
      sb.Append("  Title3: ").Append(Title3).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
      sb.Append("  ProductLine: ").Append(ProductLine).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
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
