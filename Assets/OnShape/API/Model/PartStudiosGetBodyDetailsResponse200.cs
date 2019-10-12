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
  public class PartStudiosGetBodyDetailsResponse200 {
    /// <summary>
    /// Array of body information
    /// </summary>
    /// <value>Array of body information</value>
    [DataMember(Name="bodies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bodies")]
    public List<PartStudiosGetBodyDetailsResponse200Bodies> Bodies { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetBodyDetailsResponse200 {\n");
      sb.Append("  Bodies: ").Append(Bodies).Append("\n");
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
