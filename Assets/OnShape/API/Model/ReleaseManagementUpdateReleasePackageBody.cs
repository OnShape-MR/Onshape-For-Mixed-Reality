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
  public class ReleaseManagementUpdateReleasePackageBody {
    /// <summary>
    /// Array of items to be updated along with their desired new properties. Only the           items for which properties need to be updated to be included in this list
    /// </summary>
    /// <value>Array of items to be updated along with their desired new properties. Only the           items for which properties need to be updated to be included in this list</value>
    [DataMember(Name="items", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "items")]
    public List<ReleaseManagementUpdateReleasePackageBodyItems> Items { get; set; }

    /// <summary>
    /// Array of properties to update before doing the transition. All properties           with required=true which do not have a value must be specified. No properties with editable=false           should be specified.
    /// </summary>
    /// <value>Array of properties to update before doing the transition. All properties           with required=true which do not have a value must be specified. No properties with editable=false           should be specified.</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<ReleaseManagementUpdateReleasePackageBodyProperties1> Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ReleaseManagementUpdateReleasePackageBody {\n");
      sb.Append("  Items: ").Append(Items).Append("\n");
      sb.Append("  Properties: ").Append(Properties).Append("\n");
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
