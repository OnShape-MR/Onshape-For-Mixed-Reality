using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Translation format information
  /// </summary>
  [DataContract]
  public class PartStudiosGetTranslationFormatsResponse200Items {
    /// <summary>
    /// For internal use
    /// </summary>
    /// <value>For internal use</value>
    [DataMember(Name="translatorName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translatorName")]
    public string TranslatorName { get; set; }

    /// <summary>
    /// True if the format can contain an assembly
    /// </summary>
    /// <value>True if the format can contain an assembly</value>
    [DataMember(Name="couldBeAssembly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "couldBeAssembly")]
    public bool? CouldBeAssembly { get; set; }

    /// <summary>
    /// Name of translation format
    /// </summary>
    /// <value>Name of translation format</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetTranslationFormatsResponse200Items {\n");
      sb.Append("  TranslatorName: ").Append(TranslatorName).Append("\n");
      sb.Append("  CouldBeAssembly: ").Append(CouldBeAssembly).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
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
