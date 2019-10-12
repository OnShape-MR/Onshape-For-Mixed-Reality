using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Subelement content for a single subelement
  /// </summary>
  [DataContract]
  public class AppElementsGetSubElementContentResponse200Data {
    /// <summary>
    /// Id of the subelement for which the data applies
    /// </summary>
    /// <value>Id of the subelement for which the data applies</value>
    [DataMember(Name="subelementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subelementId")]
    public string SubelementId { get; set; }

    /// <summary>
    /// Delta content for the subelement.  Deltas are returned in the   order that they apply
    /// </summary>
    /// <value>Delta content for the subelement.  Deltas are returned in the   order that they apply</value>
    [DataMember(Name="deltas", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deltas")]
    public List<AppElementsGetSubElementContentResponse200Deltas> Deltas { get; set; }

    /// <summary>
    /// The base content of the subelement, if it exists.  Base-64 encoded
    /// </summary>
    /// <value>The base content of the subelement, if it exists.  Base-64 encoded</value>
    [DataMember(Name="baseContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseContent")]
    public string BaseContent { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsGetSubElementContentResponse200Data {\n");
      sb.Append("  SubelementId: ").Append(SubelementId).Append("\n");
      sb.Append("  Deltas: ").Append(Deltas).Append("\n");
      sb.Append("  BaseContent: ").Append(BaseContent).Append("\n");
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
