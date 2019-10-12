using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Metadata property update request
  /// </summary>
  [DataContract]
  public class MetadataUpdateStandardContentMetadataBodyProperties {
    /// <summary>
    /// Metadata property value, (JSON type of the field needs to be compatible with the type of the property as defined in the Metadata Schema, it can be Number, String, Boolean, etc)
    /// </summary>
    /// <value>Metadata property value, (JSON type of the field needs to be compatible with the type of the property as defined in the Metadata Schema, it can be Number, String, Boolean, etc)</value>
    [DataMember(Name="value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "value")]
    public Object Value { get; set; }

    /// <summary>
    /// Metadata schema property id
    /// </summary>
    /// <value>Metadata schema property id</value>
    [DataMember(Name="propertyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyId")]
    public string PropertyId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataUpdateStandardContentMetadataBodyProperties {\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
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
