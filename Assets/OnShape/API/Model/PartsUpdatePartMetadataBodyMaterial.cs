using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Part material (Can only be modified in workspace)
  /// </summary>
  [DataContract]
  public class PartsUpdatePartMetadataBodyMaterial {
    /// <summary>
    /// Name of the material library
    /// </summary>
    /// <value>Name of the material library</value>
    [DataMember(Name="libraryName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "libraryName")]
    public string LibraryName { get; set; }

    /// <summary>
    /// Id of the material
    /// </summary>
    /// <value>Id of the material</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Properties of the material
    /// </summary>
    /// <value>Properties of the material</value>
    [DataMember(Name="properties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "properties")]
    public List<PartMaterialProperties> Properties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartsUpdatePartMetadataBodyMaterial {\n");
      sb.Append("  LibraryName: ").Append(LibraryName).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
