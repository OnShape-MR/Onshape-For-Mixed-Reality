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
  public class DocumentsCreateVersionBody {
    /// <summary>
    /// Version name
    /// </summary>
    /// <value>Version name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Microversion ID at which to create the version if fromHistory is true
    /// </summary>
    /// <value>Microversion ID at which to create the version if fromHistory is true</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// Specifies whether to create a version at a specific microversion           (specified by microversionId)
    /// </summary>
    /// <value>Specifies whether to create a version at a specific microversion           (specified by microversionId)</value>
    [DataMember(Name="fromHistory", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fromHistory")]
    public bool? FromHistory { get; set; }

    /// <summary>
    /// Workspace ID of a workspace where the version will be created if           fromHistory is false. If fromHistory is false and workspaceId is not set, the default workspace is           used.
    /// </summary>
    /// <value>Workspace ID of a workspace where the version will be created if           fromHistory is false. If fromHistory is false and workspaceId is not set, the default workspace is           used.</value>
    [DataMember(Name="workspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaceId")]
    public string WorkspaceId { get; set; }

    /// <summary>
    /// Document ID (must match path parameter)
    /// </summary>
    /// <value>Document ID (must match path parameter)</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Version description
    /// </summary>
    /// <value>Version description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsCreateVersionBody {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  FromHistory: ").Append(FromHistory).Append("\n");
      sb.Append("  WorkspaceId: ").Append(WorkspaceId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
