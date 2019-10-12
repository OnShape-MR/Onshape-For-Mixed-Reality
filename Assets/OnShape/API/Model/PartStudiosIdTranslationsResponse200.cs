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
  public class PartStudiosIdTranslationsResponse200 {
    /// <summary>
    /// Configuration of part studio in which ids were acquired
    /// </summary>
    /// <value>Configuration of part studio in which ids were acquired</value>
    [DataMember(Name="sourceConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceConfiguration")]
    public string SourceConfiguration { get; set; }

    /// <summary>
    /// Source document microversion
    /// </summary>
    /// <value>Source document microversion</value>
    [DataMember(Name="sourceDocumentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceDocumentMicroversion")]
    public string SourceDocumentMicroversion { get; set; }

    /// <summary>
    /// Array of id translation results
    /// </summary>
    /// <value>Array of id translation results</value>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public List<PartStudiosIdTranslationsResponse200Ids> Ids { get; set; }

    /// <summary>
    /// Configuration of part studio into which ids are to be             translated
    /// </summary>
    /// <value>Configuration of part studio into which ids are to be             translated</value>
    [DataMember(Name="targetConfiguration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetConfiguration")]
    public string TargetConfiguration { get; set; }

    /// <summary>
    /// Document id
    /// </summary>
    /// <value>Document id</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Target document microversion
    /// </summary>
    /// <value>Target document microversion</value>
    [DataMember(Name="targetDocumentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetDocumentMicroversion")]
    public string TargetDocumentMicroversion { get; set; }

    /// <summary>
    /// Element id
    /// </summary>
    /// <value>Element id</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosIdTranslationsResponse200 {\n");
      sb.Append("  SourceConfiguration: ").Append(SourceConfiguration).Append("\n");
      sb.Append("  SourceDocumentMicroversion: ").Append(SourceDocumentMicroversion).Append("\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      sb.Append("  TargetConfiguration: ").Append(TargetConfiguration).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  TargetDocumentMicroversion: ").Append(TargetDocumentMicroversion).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
