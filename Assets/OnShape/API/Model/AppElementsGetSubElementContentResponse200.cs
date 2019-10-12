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
  public class AppElementsGetSubElementContentResponse200 {
    /// <summary>
    /// List of subelement content.  The order in which subelements are returned   is unspecified
    /// </summary>
    /// <value>List of subelement content.  The order in which subelements are returned   is unspecified</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public List<AppElementsGetSubElementContentResponse200Data> Data { get; set; }

    /// <summary>
    /// The changeId representing the state of the element at which the   content was retrieved
    /// </summary>
    /// <value>The changeId representing the state of the element at which the   content was retrieved</value>
    [DataMember(Name="changeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeId")]
    public string ChangeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsGetSubElementContentResponse200 {\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
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
