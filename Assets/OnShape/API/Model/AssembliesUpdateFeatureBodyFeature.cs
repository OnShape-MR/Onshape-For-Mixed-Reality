using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The feature to add
  /// </summary>
  [DataContract]
  public class AssembliesUpdateFeatureBodyFeature {
    /// <summary>
    /// The type name for the feature structure
    /// </summary>
    /// <value>The type name for the feature structure</value>
    [DataMember(Name="typeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "typeName")]
    public string TypeName { get; set; }

    /// <summary>
    /// The serialized feature definition
    /// </summary>
    /// <value>The serialized feature definition</value>
    [DataMember(Name="message", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "message")]
    public Object Message { get; set; }

    /// <summary>
    /// The type number for the feature structure
    /// </summary>
    /// <value>The type number for the feature structure</value>
    [DataMember(Name="type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "type")]
    public string Type { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesUpdateFeatureBodyFeature {\n");
      sb.Append("  TypeName: ").Append(TypeName).Append("\n");
      sb.Append("  Message: ").Append(Message).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
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
