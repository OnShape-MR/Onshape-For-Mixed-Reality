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
  public class ReleaseManagementGetCompanyReleaseWorkflowResponse200 {
    /// <summary>
    /// Whether Sequential part number generation is being             used
    /// </summary>
    /// <value>Whether Sequential part number generation is being             used</value>
    [DataMember(Name="usingAutoPartNumberingScheme", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usingAutoPartNumberingScheme")]
    public bool? UsingAutoPartNumberingScheme { get; set; }

    /// <summary>
    /// Whether managed workflow is in use for this document
    /// </summary>
    /// <value>Whether managed workflow is in use for this document</value>
    [DataMember(Name="usingManagedWorkflow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "usingManagedWorkflow")]
    public bool? UsingManagedWorkflow { get; set; }

    /// <summary>
    /// The workflow ID for obsoleting existing revisions
    /// </summary>
    /// <value>The workflow ID for obsoleting existing revisions</value>
    [DataMember(Name="obsoletionWorkflowId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "obsoletionWorkflowId")]
    public string ObsoletionWorkflowId { get; set; }

    /// <summary>
    /// The workflow ID for creating new releases
    /// </summary>
    /// <value>The workflow ID for creating new releases</value>
    [DataMember(Name="releaseWorkflowId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "releaseWorkflowId")]
    public string ReleaseWorkflowId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementGetCompanyReleaseWorkflowResponse200 {\n");
      sb.Append("  UsingAutoPartNumberingScheme: ").Append(UsingAutoPartNumberingScheme).Append("\n");
      sb.Append("  UsingManagedWorkflow: ").Append(UsingManagedWorkflow).Append("\n");
      sb.Append("  ObsoletionWorkflowId: ").Append(ObsoletionWorkflowId).Append("\n");
      sb.Append("  ReleaseWorkflowId: ").Append(ReleaseWorkflowId).Append("\n");
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
