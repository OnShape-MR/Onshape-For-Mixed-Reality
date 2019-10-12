using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Individual part
  /// </summary>
  [DataContract]
  public class PartStudiosGetMetadataResponse200Parts {
    /// <summary>
    /// Part name
    /// </summary>
    /// <value>Part name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Deterministic part ID
    /// </summary>
    /// <value>Deterministic part ID</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Part description (user-specified)
    /// </summary>
    /// <value>Part description (user-specified)</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Gets or Sets Appearance
    /// </summary>
    [DataMember(Name="appearance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "appearance")]
    public PartStudiosGetMetadataResponse200Appearance Appearance { get; set; }

    /// <summary>
    /// Document microversion ID
    /// </summary>
    /// <value>Document microversion ID</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Gets or Sets CustomProperties
    /// </summary>
    [DataMember(Name="customProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "customProperties")]
    public PartStudiosGetMetadataResponse200CustomProperties CustomProperties { get; set; }

    /// <summary>
    /// Part number (user-specified)
    /// </summary>
    /// <value>Part number (user-specified)</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Part revision (user-specified)
    /// </summary>
    /// <value>Part revision (user-specified)</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetMetadataResponse200Parts {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  Appearance: ").Append(Appearance).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
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
