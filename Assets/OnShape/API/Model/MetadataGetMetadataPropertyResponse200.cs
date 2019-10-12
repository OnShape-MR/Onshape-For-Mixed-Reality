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
  public class MetadataGetMetadataPropertyResponse200 {
    /// <summary>
    /// Additional information about property only returned if             schemaId is included in request
    /// </summary>
    /// <value>Additional information about property only returned if             schemaId is included in request</value>
    [DataMember(Name="propertyConfigInfoList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "propertyConfigInfoList")]
    public List<MetadataGetMetadataPropertyResponse200PropertyConfigInfoList> PropertyConfigInfoList { get; set; }

    /// <summary>
    /// Object type name if valueType == OBJECT (6)
    /// </summary>
    /// <value>Object type name if valueType == OBJECT (6)</value>
    [DataMember(Name="objectDefName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectDefName")]
    public string ObjectDefName { get; set; }

    /// <summary>
    /// Property description
    /// </summary>
    /// <value>Property description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }

    /// <summary>
    /// Relative ordering of search importance. Baseline is 1.0
    /// </summary>
    /// <value>Relative ordering of search importance. Baseline is 1.0</value>
    [DataMember(Name="searchBoost", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "searchBoost")]
    public decimal? SearchBoost { get; set; }

    /// <summary>
    /// Property owner type, which can be: 0: user, 1: company
    /// </summary>
    /// <value>Property owner type, which can be: 0: user, 1: company</value>
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
    /// Set of enum values if valueType == ENUM (5)
    /// </summary>
    /// <value>Set of enum values if valueType == ENUM (5)</value>
    [DataMember(Name="enumValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "enumValues")]
    public List<Object> EnumValues { get; set; }

    /// <summary>
    /// Property namespace (use to disambiguate properties with same name)
    /// </summary>
    /// <value>Property namespace (use to disambiguate properties with same name)</value>
    [DataMember(Name="namespace", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "namespace")]
    public string Namespace { get; set; }

    /// <summary>
    /// True if this property can be edited in a Version
    /// </summary>
    /// <value>True if this property can be edited in a Version</value>
    [DataMember(Name="editableInVersion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editableInVersion")]
    public bool? EditableInVersion { get; set; }

    /// <summary>
    /// Blob mime type if valueType == BLOB (7)
    /// </summary>
    /// <value>Blob mime type if valueType == BLOB (7)</value>
    [DataMember(Name="blobMimeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "blobMimeType")]
    public string BlobMimeType { get; set; }

    /// <summary>
    /// Safe name
    /// </summary>
    /// <value>Safe name</value>
    [DataMember(Name="safeName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "safeName")]
    public string SafeName { get; set; }

    /// <summary>
    /// Property owner ID
    /// </summary>
    /// <value>Property owner ID</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// True if property is an array type
    /// </summary>
    /// <value>True if property is an array type</value>
    [DataMember(Name="array", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "array")]
    public bool? Array { get; set; }

    /// <summary>
    /// True if this property can be edited in a Microversion
    /// </summary>
    /// <value>True if this property can be edited in a Microversion</value>
    [DataMember(Name="editableInMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "editableInMicroversion")]
    public bool? EditableInMicroversion { get; set; }

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
      sb.Append("class MetadataGetMetadataPropertyResponse200 {\n");
      sb.Append("  PropertyConfigInfoList: ").Append(PropertyConfigInfoList).Append("\n");
      sb.Append("  ObjectDefName: ").Append(ObjectDefName).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
      sb.Append("  SearchBoost: ").Append(SearchBoost).Append("\n");
      sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
      sb.Append("  ValueType: ").Append(ValueType).Append("\n");
      sb.Append("  EnumValues: ").Append(EnumValues).Append("\n");
      sb.Append("  Namespace: ").Append(Namespace).Append("\n");
      sb.Append("  EditableInVersion: ").Append(EditableInVersion).Append("\n");
      sb.Append("  BlobMimeType: ").Append(BlobMimeType).Append("\n");
      sb.Append("  SafeName: ").Append(SafeName).Append("\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Array: ").Append(Array).Append("\n");
      sb.Append("  EditableInMicroversion: ").Append(EditableInMicroversion).Append("\n");
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
