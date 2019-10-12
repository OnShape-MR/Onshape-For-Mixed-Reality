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
  public class DrawingsCreateTranslationBody {
    /// <summary>
    /// (PDF only) The color transformation that should be applied to the drawing on export. Supported options are: color, blackandwhite and grayscale
    /// </summary>
    /// <value>(PDF only) The color transformation that should be applied to the drawing on export. Supported options are: color, blackandwhite and grayscale</value>
    [DataMember(Name="colorMethod", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "colorMethod")]
    public string ColorMethod { get; set; }

    /// <summary>
    /// Whether text should be exploded into polylines
    /// </summary>
    /// <value>Whether text should be exploded into polylines</value>
    [DataMember(Name="textAsGeometry", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "textAsGeometry")]
    public bool? TextAsGeometry { get; set; }

    /// <summary>
    /// Whether splines should be converted to polylines on the export
    /// </summary>
    /// <value>Whether splines should be converted to polylines on the export</value>
    [DataMember(Name="splinesAsPolylines", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "splinesAsPolylines")]
    public bool? SplinesAsPolylines { get; set; }

    /// <summary>
    /// (DWG only) Version of output format to use (format-dependent). Currently supported formats are: 2013, 2010, 2007, 2004, 2000, R14, R13, R12
    /// </summary>
    /// <value>(DWG only) Version of output format to use (format-dependent). Currently supported formats are: 2013, 2010, 2007, 2004, 2000, R14, R13, R12</value>
    [DataMember(Name="versionString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionString")]
    public string VersionString { get; set; }

    /// <summary>
    /// Name of the output file or new element. If the name does not include a file extension the extension will be derived from the formatName parameter
    /// </summary>
    /// <value>Name of the output file or new element. If the name does not include a file extension the extension will be derived from the formatName parameter</value>
    [DataMember(Name="destinationName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "destinationName")]
    public string DestinationName { get; set; }

    /// <summary>
    /// Name of format into which this element should be translated.
    /// </summary>
    /// <value>Name of format into which this element should be translated.</value>
    [DataMember(Name="formatName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatName")]
    public string FormatName { get; set; }

    /// <summary>
    /// (DWG only) Whether to only export the last active sheet or all sheets
    /// </summary>
    /// <value>(DWG only) Whether to only export the last active sheet or all sheets</value>
    [DataMember(Name="currentSheetOnly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "currentSheetOnly")]
    public bool? CurrentSheetOnly { get; set; }

    /// <summary>
    /// (DWG only) Whether overridden dimensions should be underlined
    /// </summary>
    /// <value>(DWG only) Whether overridden dimensions should be underlined</value>
    [DataMember(Name="showOveriddenDimensions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "showOveriddenDimensions")]
    public bool? ShowOveriddenDimensions { get; set; }

    /// <summary>
    /// Whether a user notification should be generated on completion
    /// </summary>
    /// <value>Whether a user notification should be generated on completion</value>
    [DataMember(Name="notifyUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifyUser")]
    public bool? NotifyUser { get; set; }

    /// <summary>
    /// controls whether the translation is stored as a new element or        whether the data is stored as external data (storeInDocument=false).
    /// </summary>
    /// <value>controls whether the translation is stored as a new element or        whether the data is stored as external data (storeInDocument=false).</value>
    [DataMember(Name="storeInDocument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeInDocument")]
    public bool? StoreInDocument { get; set; }

    /// <summary>
    /// If storeInDocument is true and linkDocumentId is specified, this        specifies a workspace to be used for result storage within the linkDocument.
    /// </summary>
    /// <value>If storeInDocument is true and linkDocumentId is specified, this        specifies a workspace to be used for result storage within the linkDocument.</value>
    [DataMember(Name="linkDocumentWorkspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkDocumentWorkspaceId")]
    public string LinkDocumentWorkspaceId { get; set; }

    /// <summary>
    /// (PDF only) Controls if text on the drawing should be selectable on the output PDF.
    /// </summary>
    /// <value>(PDF only) Controls if text on the drawing should be selectable on the output PDF.</value>
    [DataMember(Name="selectablePdfText", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "selectablePdfText")]
    public bool? SelectablePdfText { get; set; }

    /// <summary>
    /// Whether to set z-height to zero and normals to positive
    /// </summary>
    /// <value>Whether to set z-height to zero and normals to positive</value>
    [DataMember(Name="flatten", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flatten")]
    public bool? Flatten { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DrawingsCreateTranslationBody {\n");
      sb.Append("  ColorMethod: ").Append(ColorMethod).Append("\n");
      sb.Append("  TextAsGeometry: ").Append(TextAsGeometry).Append("\n");
      sb.Append("  SplinesAsPolylines: ").Append(SplinesAsPolylines).Append("\n");
      sb.Append("  VersionString: ").Append(VersionString).Append("\n");
      sb.Append("  DestinationName: ").Append(DestinationName).Append("\n");
      sb.Append("  FormatName: ").Append(FormatName).Append("\n");
      sb.Append("  CurrentSheetOnly: ").Append(CurrentSheetOnly).Append("\n");
      sb.Append("  ShowOveriddenDimensions: ").Append(ShowOveriddenDimensions).Append("\n");
      sb.Append("  NotifyUser: ").Append(NotifyUser).Append("\n");
      sb.Append("  StoreInDocument: ").Append(StoreInDocument).Append("\n");
      sb.Append("  LinkDocumentWorkspaceId: ").Append(LinkDocumentWorkspaceId).Append("\n");
      sb.Append("  SelectablePdfText: ").Append(SelectablePdfText).Append("\n");
      sb.Append("  Flatten: ").Append(Flatten).Append("\n");
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
