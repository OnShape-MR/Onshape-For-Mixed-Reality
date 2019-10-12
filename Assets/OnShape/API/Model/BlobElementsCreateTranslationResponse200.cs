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
  public class BlobElementsCreateTranslationResponse200 {
    /// <summary>
    /// The URI for accessing this translation
    /// </summary>
    /// <value>The URI for accessing this translation</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// The id of the element being translated
    /// </summary>
    /// <value>The id of the element being translated</value>
    [DataMember(Name="requestElementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestElementId")]
    public string RequestElementId { get; set; }

    /// <summary>
    /// The state of this translation request. (ACTIVE|DONE|FAILED)
    /// </summary>
    /// <value>The state of this translation request. (ACTIVE|DONE|FAILED)</value>
    [DataMember(Name="requestState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "requestState")]
    public string RequestState { get; set; }

    /// <summary>
    /// The id of the document version that contains the translation source
    /// </summary>
    /// <value>The id of the document version that contains the translation source</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// The id of the document workspace that contains the translation source
    /// </summary>
    /// <value>The id of the document workspace that contains the translation source</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// The id of this translation
    /// </summary>
    /// <value>The id of this translation</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// The id of the document that contains the translation source
    /// </summary>
    /// <value>The id of the document that contains the translation source</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class BlobElementsCreateTranslationResponse200 {\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  RequestElementId: ").Append(RequestElementId).Append("\n");
      sb.Append("  RequestState: ").Append(RequestState).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
