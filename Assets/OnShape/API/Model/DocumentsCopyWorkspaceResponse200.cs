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
  public class DocumentsCopyWorkspaceResponse200 {
    /// <summary>
    /// ID of new workspace
    /// </summary>
    /// <value>ID of new workspace</value>
    [DataMember(Name="newWorkspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newWorkspaceId")]
    public string NewWorkspaceId { get; set; }

    /// <summary>
    /// Name of new document
    /// </summary>
    /// <value>Name of new document</value>
    [DataMember(Name="newDocumentName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newDocumentName")]
    public string NewDocumentName { get; set; }

    /// <summary>
    /// ID of new document
    /// </summary>
    /// <value>ID of new document</value>
    [DataMember(Name="newDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "newDocumentId")]
    public string NewDocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsCopyWorkspaceResponse200 {\n");
      sb.Append("  NewWorkspaceId: ").Append(NewWorkspaceId).Append("\n");
      sb.Append("  NewDocumentName: ").Append(NewDocumentName).Append("\n");
      sb.Append("  NewDocumentId: ").Append(NewDocumentId).Append("\n");
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
