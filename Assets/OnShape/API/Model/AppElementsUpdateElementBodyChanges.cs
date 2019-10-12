using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// An individual change
  /// </summary>
  [DataContract]
  public class AppElementsUpdateElementBodyChanges {
    /// <summary>
    /// The subelement that should be modified
    /// </summary>
    /// <value>The subelement that should be modified</value>
    [DataMember(Name="subelementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subelementId")]
    public Object SubelementId { get; set; }

    /// <summary>
    /// The initial content for a subelement (Base-64 encoded)
    /// </summary>
    /// <value>The initial content for a subelement (Base-64 encoded)</value>
    [DataMember(Name="baseContent", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "baseContent")]
    public Object BaseContent { get; set; }

    /// <summary>
    /// A delta for a sub-element (Base-64 encoded)
    /// </summary>
    /// <value>A delta for a sub-element (Base-64 encoded)</value>
    [DataMember(Name="delta", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "delta")]
    public Object Delta { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsUpdateElementBodyChanges {\n");
      sb.Append("  SubelementId: ").Append(SubelementId).Append("\n");
      sb.Append("  BaseContent: ").Append(BaseContent).Append("\n");
      sb.Append("  Delta: ").Append(Delta).Append("\n");
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
