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
  public class ElementsEncodeConfigurationResponse200 {
    /// <summary>
    /// The configuration encoding string
    /// </summary>
    /// <value>The configuration encoding string</value>
    [DataMember(Name="encodedId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encodedId")]
    public string EncodedId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ElementsEncodeConfigurationResponse200 {\n");
      sb.Append("  EncodedId: ").Append(EncodedId).Append("\n");
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
