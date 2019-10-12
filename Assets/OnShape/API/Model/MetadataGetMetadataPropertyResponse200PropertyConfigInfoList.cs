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
  public class MetadataGetMetadataPropertyResponse200PropertyConfigInfoList {
    /// <summary>
    /// Regular expression pattern validation for             properties whose valueType == STRING (0)
    /// </summary>
    /// <value>Regular expression pattern validation for             properties whose valueType == STRING (0)</value>
    [DataMember(Name="pattern", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "pattern")]
    public string Pattern { get; set; }

    /// <summary>
    /// Schema ID associated with this property config             object
    /// </summary>
    /// <value>Schema ID associated with this property config             object</value>
    [DataMember(Name="schemaId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "schemaId")]
    public string SchemaId { get; set; }

    /// <summary>
    /// True if property is required to have a             non-empty value
    /// </summary>
    /// <value>True if property is required to have a             non-empty value</value>
    [DataMember(Name="required", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "required")]
    public bool? Required { get; set; }

    /// <summary>
    /// Max value validation for properties whose             valueType == DOUBLE or INT
    /// </summary>
    /// <value>Max value validation for properties whose             valueType == DOUBLE or INT</value>
    [DataMember(Name="maxValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxValue")]
    public decimal? MaxValue { get; set; }

    /// <summary>
    /// Min value validation for properties whose             valueType == DOUBLE or INT
    /// </summary>
    /// <value>Min value validation for properties whose             valueType == DOUBLE or INT</value>
    [DataMember(Name="minValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minValue")]
    public decimal? MinValue { get; set; }

    /// <summary>
    /// True if string input should be multiline.             Only used if valueType == STRING
    /// </summary>
    /// <value>True if string input should be multiline.             Only used if valueType == STRING</value>
    [DataMember(Name="multiline", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "multiline")]
    public bool? Multiline { get; set; }

    /// <summary>
    /// Min length validation for properties whose             valueType == STRING
    /// </summary>
    /// <value>Min length validation for properties whose             valueType == STRING</value>
    [DataMember(Name="minLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minLength")]
    public decimal? MinLength { get; set; }

    /// <summary>
    /// Property publish state, which can be: 0:             PENDING, 1: ACTIVE, 2: INACTIVE
    /// </summary>
    /// <value>Property publish state, which can be: 0:             PENDING, 1: ACTIVE, 2: INACTIVE</value>
    [DataMember(Name="publishState", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "publishState")]
    public decimal? PublishState { get; set; }

    /// <summary>
    /// Max length validation for properties whose             valueType == STRING
    /// </summary>
    /// <value>Max length validation for properties whose             valueType == STRING</value>
    [DataMember(Name="maxLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxLength")]
    public decimal? MaxLength { get; set; }

    /// <summary>
    /// Default value, must be set if required ==             true
    /// </summary>
    /// <value>Default value, must be set if required ==             true</value>
    [DataMember(Name="defaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "defaultValue")]
    public string DefaultValue { get; set; }

    /// <summary>
    /// Property ID associated with this property             config object
    /// </summary>
    /// <value>Property ID associated with this property             config object</value>
    [DataMember(Name="propertyId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyId")]
    public string PropertyId { get; set; }

    /// <summary>
    /// Metadata object type, which can be: 0:GLOBAL,             1:DOCUMENT, 2:PART, 3:ASSEMBLY, 4:DRAWING, 5:PART_STUDIO, 6: BLOB_ELEMENT, 7:APP_ELEMENT, 8:VERSION,             9:WORKSPACE
    /// </summary>
    /// <value>Metadata object type, which can be: 0:GLOBAL,             1:DOCUMENT, 2:PART, 3:ASSEMBLY, 4:DRAWING, 5:PART_STUDIO, 6: BLOB_ELEMENT, 7:APP_ELEMENT, 8:VERSION,             9:WORKSPACE</value>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public decimal? ObjectType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataGetMetadataPropertyResponse200PropertyConfigInfoList {\n");
      sb.Append("  Pattern: ").Append(Pattern).Append("\n");
      sb.Append("  SchemaId: ").Append(SchemaId).Append("\n");
      sb.Append("  Required: ").Append(Required).Append("\n");
      sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
      sb.Append("  MinValue: ").Append(MinValue).Append("\n");
      sb.Append("  Multiline: ").Append(Multiline).Append("\n");
      sb.Append("  MinLength: ").Append(MinLength).Append("\n");
      sb.Append("  PublishState: ").Append(PublishState).Append("\n");
      sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  PropertyId: ").Append(PropertyId).Append("\n");
      sb.Append("  ObjectType: ").Append(ObjectType).Append("\n");
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
