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
  public class ReleaseManagementCreateObsoletionPackageResponse200 {
    /// <summary>
    /// Company ID for the obsoletion package
    /// </summary>
    /// <value>Company ID for the obsoletion package</value>
    [DataMember(Name="companyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "companyId")]
    public string CompanyId { get; set; }

    /// <summary>
    /// in the package as determined by the revision. Always just one item
    /// </summary>
    /// <value>in the package as determined by the revision. Always just one item</value>
    [DataMember(Name="Items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Items")]
    public List<Object> Items { get; set; }

    /// <summary>
    /// Gets or Sets Workflow
    /// </summary>
    [DataMember(Name="workflow", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "workflow")]
    public ReleaseManagementCreateObsoletionPackageResponse200Workflow Workflow { get; set; }

    /// <summary>
    /// ID of the obsoletion package.
    /// </summary>
    /// <value>ID of the obsoletion package.</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Version ID of the revision
    /// </summary>
    /// <value>Version ID of the revision</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Gets or Sets Items
    /// </summary>
    //[DataMember(Name="items", EmitDefaultValue=false)]
    //[JsonProperty(PropertyName = "items")]
    //public  Items { get; set; }

    /// <summary>
    /// Array of properties for the package
    /// </summary>
    /// <value>Array of properties for the package</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ReleaseManagementCreateObsoletionPackageResponse200Properties> Properties { get; set; }

    /// <summary>
    /// Document ID of the revision
    /// </summary>
    /// <value>Document ID of the revision</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementCreateObsoletionPackageResponse200 {\n");
      sb.Append("  CompanyId: ").Append(CompanyId).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Workflow: ").Append(Workflow).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
