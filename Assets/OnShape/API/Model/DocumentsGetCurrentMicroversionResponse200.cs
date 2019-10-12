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
  public class DocumentsGetCurrentMicroversionResponse200 {
    /// <summary>
    /// The document microversion ID associated with the workspace or             version
    /// </summary>
    /// <value>The document microversion ID associated with the workspace or             version</value>
    [DataMember(Name="microversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversion")]
    public string Microversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetCurrentMicroversionResponse200 {\n");
      sb.Append("  Microversion: ").Append(Microversion).Append("\n");
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
