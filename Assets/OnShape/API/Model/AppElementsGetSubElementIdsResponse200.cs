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
  public class AppElementsGetSubElementIdsResponse200 {
    /// <summary>
    /// List of subelement ids defined within the element
    /// </summary>
    /// <value>List of subelement ids defined within the element</value>
    [DataMember(Name="subelementIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subelementIds")]
    public List<string> SubelementIds { get; set; }

    /// <summary>
    /// The changeId representing the element state after the commit
    /// </summary>
    /// <value>The changeId representing the element state after the commit</value>
    [DataMember(Name="changeId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "changeId")]
    public string ChangeId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsGetSubElementIdsResponse200 {\n");
      sb.Append("  SubelementIds: ").Append(SubelementIds).Append("\n");
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
