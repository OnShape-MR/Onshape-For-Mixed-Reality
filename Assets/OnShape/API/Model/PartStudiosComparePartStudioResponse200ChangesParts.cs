using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Differences in Part Studio Parts
  /// </summary>
  [DataContract]
  public class PartStudiosComparePartStudioResponse200ChangesParts {
    /// <summary>
    /// Type of the differences in Part collection in the Part             Studio (see API description for values)
    /// </summary>
    /// <value>Type of the differences in Part collection in the Part             Studio (see API description for values)</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }

    /// <summary>
    /// List of changes in Part Studio Parts             collection
    /// </summary>
    /// <value>List of changes in Part Studio Parts             collection</value>
    [DataMember(Name="collectionChanges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collectionChanges")]
    public List<PartStudiosComparePartStudioResponse200ChangesPartsCollectionChanges> CollectionChanges { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosComparePartStudioResponse200ChangesParts {\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  CollectionChanges: ").Append(CollectionChanges).Append("\n");
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
