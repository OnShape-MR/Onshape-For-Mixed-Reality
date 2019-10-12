using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// The import definition
  /// </summary>
  [DataContract]
  public class PartStudiosGetFeaturesResponse200Message {
    /// <summary>
    /// The path for an import
    /// </summary>
    /// <value>The path for an import</value>
    [DataMember(Name="path", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "path")]
    public string Path { get; set; }

    /// <summary>
    /// The version for an import
    /// </summary>
    /// <value>The version for an import</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public string Version { get; set; }

    /// <summary>
    /// The namespace for an import
    /// </summary>
    /// <value>The namespace for an import</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string Namespace { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetFeaturesResponse200Message {\n");
      sb.Append("  Path: ").Append(Path).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
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
