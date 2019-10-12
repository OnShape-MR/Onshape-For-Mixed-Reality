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
  public class AppElementsGetHistoryByWorkspaceResponse200 {
    /// <summary>
    /// List of subelement history entries in order of more recent to less   recent
    /// </summary>
    /// <value>List of subelement history entries in order of more recent to less   recent</value>
    [DataMember(Name="changes", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changes")]
    public List<AppElementsGetHistoryByWorkspaceResponse200Changes> Changes { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsGetHistoryByWorkspaceResponse200 {\n");
      sb.Append("  Changes: ").Append(Changes).Append("\n");
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
