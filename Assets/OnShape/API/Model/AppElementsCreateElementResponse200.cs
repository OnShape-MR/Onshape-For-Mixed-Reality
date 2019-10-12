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
  public class AppElementsCreateElementResponse200 {
    /// <summary>
    /// The elementId of the created element
    /// </summary>
    /// <value>The elementId of the created element</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// The changeId of the creation operation
    /// </summary>
    /// <value>The changeId of the creation operation</value>
    [DataMember(Name="changeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeId")]
    public string ChangeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsCreateElementResponse200 {\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  ChangeId: ").Append(ChangeId).Append("\n");
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
