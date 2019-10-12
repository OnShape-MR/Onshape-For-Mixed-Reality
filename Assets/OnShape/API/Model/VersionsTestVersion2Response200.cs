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
  public class VersionsTestVersion2Response200 {
    /// <summary>
    /// The list of supported version numbers
    /// </summary>
    /// <value>The list of supported version numbers</value>
    [DataMember(Name="supportedVersions", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "supportedVersions")]
    public List<decimal?> SupportedVersions { get; set; }

    /// <summary>
    /// The earliest support version
    /// </summary>
    /// <value>The earliest support version</value>
    [DataMember(Name="earliestVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "earliestVersion")]
    public decimal? EarliestVersion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class VersionsTestVersion2Response200 {\n");
      sb.Append("  SupportedVersions: ").Append(SupportedVersions).Append("\n");
      sb.Append("  EarliestVersion: ").Append(EarliestVersion).Append("\n");
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
