using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Element metadata
  /// </summary>
  [DataContract]
  public class MetadataGetMetadataResponse200ElementsItems {
    /// <summary>
    /// Element mime type
    /// </summary>
    /// <value>Element mime type</value>
    [DataMember(Name="mimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mimeType")]
    public string MimeType { get; set; }

    /// <summary>
    /// Part list if element is a PartStudio
    /// </summary>
    /// <value>Part list if element is a PartStudio</value>
    [DataMember(Name="parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parts")]
    public List<MetadataGetMetadataResponse200ElementsParts> Parts { get; set; }

    /// <summary>
    /// Element's thumbnail
    /// </summary>
    /// <value>Element's thumbnail</value>
    [DataMember(Name="thumbnail", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnail")]
    public Object Thumbnail { get; set; }

    /// <summary>
    /// URI of Element metadata
    /// </summary>
    /// <value>URI of Element metadata</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Element type
    /// </summary>
    /// <value>Element type</value>
    [DataMember(Name="elementType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementType")]
    public decimal? ElementType { get; set; }

    /// <summary>
    /// Element properties
    /// </summary>
    /// <value>Element properties</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<Object> Properties { get; set; }

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
      sb.Append("class MetadataGetMetadataResponse200ElementsItems {\n");
      sb.Append("  MimeType: ").Append(MimeType).Append("\n");
      sb.Append("  Parts: ").Append(Parts).Append("\n");
      sb.Append("  Thumbnail: ").Append(Thumbnail).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  ElementType: ").Append(ElementType).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
