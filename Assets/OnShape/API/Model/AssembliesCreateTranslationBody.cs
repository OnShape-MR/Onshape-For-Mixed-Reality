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
  public class AssembliesCreateTranslationBody {
    /// <summary>
    /// Name of format into which this element should be translated. ONSHAPE        indicates that the model file should be translated into a Part Studio or Assembly.
    /// </summary>
    /// <value>Name of format into which this element should be translated. ONSHAPE        indicates that the model file should be translated into a Part Studio or Assembly.</value>
    [DataMember(Name="formatName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatName")]
    public string FormatName { get; set; }

    /// <summary>
    /// Whether to include topology id strings in parasolid output format.
    /// </summary>
    /// <value>Whether to include topology id strings in parasolid output format.</value>
    [DataMember(Name="includeExportIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "includeExportIds")]
    public bool? IncludeExportIds { get; set; }

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
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesCreateTranslationBody {\n");
      sb.Append("  FormatName: ").Append(FormatName).Append("\n");
      sb.Append("  IncludeExportIds: ").Append(IncludeExportIds).Append("\n");
      sb.Append("  StoreInDocument: ").Append(StoreInDocument).Append("\n");
      sb.Append("  LinkDocumentWorkspaceId: ").Append(LinkDocumentWorkspaceId).Append("\n");
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
