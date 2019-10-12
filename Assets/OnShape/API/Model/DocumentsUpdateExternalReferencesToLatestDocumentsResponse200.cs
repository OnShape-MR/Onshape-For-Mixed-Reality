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
  public class DocumentsUpdateExternalReferencesToLatestDocumentsResponse200 {
    /// <summary>
    /// array of ids of changed elements
    /// </summary>
    /// <value>array of ids of changed elements</value>
    [DataMember(Name="changedElements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changedElements")]
    public List<string> ChangedElements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsUpdateExternalReferencesToLatestDocumentsResponse200 {\n");
      sb.Append("  ChangedElements: ").Append(ChangedElements).Append("\n");
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
