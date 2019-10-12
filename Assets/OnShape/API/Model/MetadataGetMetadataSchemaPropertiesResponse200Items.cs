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
  public class MetadataGetMetadataSchemaPropertiesResponse200Items {
    /// <summary>
    /// Property description
    /// </summary>
    /// <value>Property description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Additional information about property.
    /// </summary>
    /// <value>Additional information about property.</value>
    [DataMember(Name="propertyConfigSummaryInfoList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyConfigSummaryInfoList")]
    public List<Object> PropertyConfigSummaryInfoList { get; set; }

    /// <summary>
    /// Property owner type, which can be: 0: user, 1: company, 2:             onshape
    /// </summary>
    /// <value>Property owner type, which can be: 0: user, 1: company, 2:             onshape</value>
    [DataMember(Name="ownerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerType")]
    public decimal? OwnerType { get; set; }

    /// <summary>
    /// Value type of property, which can be: 0:STRING, 1:BOOL, 2:INT,             3:DOUBLE, 4:DATE, 5:ENUM, 6:OBJECT, 7:BLOB, 8:USER
    /// </summary>
    /// <value>Value type of property, which can be: 0:STRING, 1:BOOL, 2:INT,             3:DOUBLE, 4:DATE, 5:ENUM, 6:OBJECT, 7:BLOB, 8:USER</value>
    [DataMember(Name="valueType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "valueType")]
    public decimal? ValueType { get; set; }

    /// <summary>
    /// Gets or Sets PropertyConfigInfoList
    /// </summary>
    //[DataMember(Name="propertyConfigInfoList", EmitDefaultValue=false)]
    //[JsonProperty(PropertyName = "propertyConfigInfoList")]
    //public PropertyConfigInfoList { get; set; }

    /// <summary>
    /// Property namespace (use to disambiguate properties with same             name)
    /// </summary>
    /// <value>Property namespace (use to disambiguate properties with same             name)</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// True if this property can be edited in a version.
    /// </summary>
    /// <value>True if this property can be edited in a version.</value>
    [DataMember(Name="editableInVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editableInVersion")]
    public bool? EditableInVersion { get; set; }

    /// <summary>
    /// True if this property can be edited in a             workspace.
    /// </summary>
    /// <value>True if this property can be edited in a             workspace.</value>
    [DataMember(Name="editableInMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editableInMicroversion")]
    public bool? EditableInMicroversion { get; set; }

    /// <summary>
    /// Property owner ID
    /// </summary>
    /// <value>Property owner ID</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// Property ID
    /// </summary>
    /// <value>Property ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Property name
    /// </summary>
    /// <value>Property name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataGetMetadataSchemaPropertiesResponse200Items {\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  PropertyConfigSummaryInfoList: ").Append(PropertyConfigSummaryInfoList).Append("\n");
      sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
      //sb.Append("  PropertyConfigInfoList: ").Append(PropertyConfigInfoList).Append("\n");
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
      sb.Append("  EditableInVersion: ").Append(EditableInVersion).Append("\n");
      sb.Append("  EditableInMicroversion: ").Append(EditableInMicroversion).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
