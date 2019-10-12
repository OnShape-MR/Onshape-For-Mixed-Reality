using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Id translation result
  /// </summary>
  [DataContract]
  public class PartStudiosIdTranslationsResponse200Ids {
    /// <summary>
    /// Translation status (OK|SPLIT|FAILED_TO_RESOLVE|TRANSLATION_ERROR)
    /// </summary>
    /// <value>Translation status (OK|SPLIT|FAILED_TO_RESOLVE|TRANSLATION_ERROR)</value>
    [DataMember(Name="status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "status")]
    public Object Status { get; set; }

    /// <summary>
    /// The id in source microversion
    /// </summary>
    /// <value>The id in source microversion</value>
    [DataMember(Name="source", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "source")]
    public string Source { get; set; }

    /// <summary>
    /// [] Set of ids which corresponds to the source id. Can have 0, 1, or             more id-s.
    /// </summary>
    /// <value>[] Set of ids which corresponds to the source id. Can have 0, 1, or             more id-s.</value>
    [DataMember(Name="target", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "target")]
    public List<string> Target { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosIdTranslationsResponse200Ids {\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  Source: ").Append(Source).Append("\n");
      sb.Append("  Target: ").Append(Target).Append("\n");
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
