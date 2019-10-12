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
  public class DocumentsGetVersionsResponse200 {
    /// <summary>
    /// Array of information for each version
    /// </summary>
    /// <value>Array of information for each version</value>
    [DataMember(Name="versions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versions")]
    public List<DocumentsGetVersionsResponse200Versions> Versions { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetVersionsResponse200 {\n");
      sb.Append("  Versions: ").Append(Versions).Append("\n");
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
