using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Revision information
  /// </summary>
  [DataContract]
  public class RevisionsGetRevisionHistoryInCompanyResponse200Items {
    /// <summary>
    /// Type of element
    /// </summary>
    /// <value>Type of element</value>
    [DataMember(Name="elementType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementType")]
    public decimal? ElementType { get; set; }

    /// <summary>
    /// An URI to view the revision
    /// </summary>
    /// <value>An URI to view the revision</value>
    [DataMember(Name="viewRef", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewRef")]
    public string ViewRef { get; set; }

    /// <summary>
    /// Deterministic part ID if revision is of a part
    /// </summary>
    /// <value>Deterministic part ID if revision is of a part</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// Name of the document that contains the revision
    /// </summary>
    /// <value>Name of the document that contains the revision</value>
    [DataMember(Name="documentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentName")]
    public string DocumentName { get; set; }

    /// <summary>
    /// Any error message if not revision is not accessible
    /// </summary>
    /// <value>Any error message if not revision is not accessible</value>
    [DataMember(Name="errorMessage", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "errorMessage")]
    public string ErrorMessage { get; set; }

    /// <summary>
    /// Revision Id of the previous revision if any
    /// </summary>
    /// <value>Revision Id of the previous revision if any</value>
    [DataMember(Name="previousRevisionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "previousRevisionId")]
    public string PreviousRevisionId { get; set; }

    /// <summary>
    /// Revision Id of the next revision if any
    /// </summary>
    /// <value>Revision Id of the next revision if any</value>
    [DataMember(Name="nextRevisionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "nextRevisionId")]
    public string NextRevisionId { get; set; }

    /// <summary>
    /// Release package ID that created this revision
    /// </summary>
    /// <value>Release package ID that created this revision</value>
    [DataMember(Name="releaseId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releaseId")]
    public string ReleaseId { get; set; }

    /// <summary>
    /// Version ID that contains the revision
    /// </summary>
    /// <value>Version ID that contains the revision</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Element ID that contains the revision
    /// </summary>
    /// <value>Element ID that contains the revision</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Name of the Version that contains the revision
    /// </summary>
    /// <value>Name of the Version that contains the revision</value>
    [DataMember(Name="versionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionName")]
    public string VersionName { get; set; }

    /// <summary>
    /// Whether the revision is obsolete
    /// </summary>
    /// <value>Whether the revision is obsolete</value>
    [DataMember(Name="isObsolete", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isObsolete")]
    public bool? IsObsolete { get; set; }

    /// <summary>
    /// Part number of the revision
    /// </summary>
    /// <value>Part number of the revision</value>
    [DataMember(Name="partNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partNumber")]
    public string PartNumber { get; set; }

    /// <summary>
    /// Configuration of the Part studio or Assembly element
    /// </summary>
    /// <value>Configuration of the Part studio or Assembly element</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// Revision Id
    /// </summary>
    /// <value>Revision Id</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Document ID that contains the revision
    /// </summary>
    /// <value>Document ID that contains the revision</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// revision name of the revision
    /// </summary>
    /// <value>revision name of the revision</value>
    [DataMember(Name="revision", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "revision")]
    public string Revision { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class RevisionsGetRevisionHistoryInCompanyResponse200Items {\n");
      sb.Append("  ElementType: ").Append(ElementType).Append("\n");
      sb.Append("  ViewRef: ").Append(ViewRef).Append("\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  DocumentName: ").Append(DocumentName).Append("\n");
      sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
      sb.Append("  PreviousRevisionId: ").Append(PreviousRevisionId).Append("\n");
      sb.Append("  NextRevisionId: ").Append(NextRevisionId).Append("\n");
      sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  VersionName: ").Append(VersionName).Append("\n");
      sb.Append("  IsObsolete: ").Append(IsObsolete).Append("\n");
      sb.Append("  PartNumber: ").Append(PartNumber).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
