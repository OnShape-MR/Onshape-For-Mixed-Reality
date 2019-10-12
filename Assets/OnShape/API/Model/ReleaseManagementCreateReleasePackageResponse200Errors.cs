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
  public class ReleaseManagementCreateReleasePackageResponse200Errors {
    /// <summary>
    /// severity of error 1: Informational, 2: Warning, 3:             Error. All errors of severity 3 must be resolved before the package can be transitioned to another             state.
    /// </summary>
    /// <value>severity of error 1: Informational, 2: Warning, 3:             Error. All errors of severity 3 must be resolved before the package can be transitioned to another             state.</value>
    [DataMember(Name="severity", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "severity")]
    public decimal? Severity { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementCreateReleasePackageResponse200Errors {\n");
      sb.Append("  Severity: ").Append(Severity).Append("\n");
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
