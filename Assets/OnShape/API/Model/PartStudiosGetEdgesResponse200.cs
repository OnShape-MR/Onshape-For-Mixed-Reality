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
  public class PartStudiosGetEdgesResponse200 {
    /// <summary>
    /// Array containing response info for each part
    /// </summary>
    /// <value>Array containing response info for each part</value>
    [DataMember(Name="parts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parts")]
    public List<PartStudiosGetEdgesResponse200Parts> Parts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetEdgesResponse200 {\n");
      sb.Append("  Parts: ").Append(Parts).Append("\n");
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
