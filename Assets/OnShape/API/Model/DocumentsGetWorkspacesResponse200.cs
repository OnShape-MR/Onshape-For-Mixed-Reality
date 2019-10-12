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
  public class DocumentsGetWorkspacesResponse200 {
    /// <summary>
    /// List of workspaces in document
    /// </summary>
    /// <value>List of workspaces in document</value>
    [DataMember(Name="workspaces", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workspaces")]
    public List<DocumentsGetWorkspacesResponse200Workspaces> Workspaces { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetWorkspacesResponse200 {\n");
      sb.Append("  Workspaces: ").Append(Workspaces).Append("\n");
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
