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
  public class DocumentsUpdateExternalReferencesToLatestDocumentsBody {
    /// <summary>
    /// update the external references that are pointing to [elements] if [elements] is not empty,                                        otherwise update all external references in the given element
    /// </summary>
    /// <value>update the external references that are pointing to [elements] if [elements] is not empty,                                        otherwise update all external references in the given element</value>
    [DataMember(Name="elements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elements")]
    public List<string> Elements { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsUpdateExternalReferencesToLatestDocumentsBody {\n");
      sb.Append("  Elements: ").Append(Elements).Append("\n");
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
