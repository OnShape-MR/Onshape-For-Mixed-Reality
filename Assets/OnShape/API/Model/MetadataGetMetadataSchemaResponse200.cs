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
  public class MetadataGetMetadataSchemaResponse200 {
    /// <summary>
    /// Schema owner ID
    /// </summary>
    /// <value>Schema owner ID</value>
    [DataMember(Name="ownerId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerId")]
    public string OwnerId { get; set; }

    /// <summary>
    /// URL to the schema
    /// </summary>
    /// <value>URL to the schema</value>
    [DataMember(Name="href", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "href")]
    public string Href { get; set; }

    /// <summary>
    /// Schema owner type, which can be: 0: user, 1: company
    /// </summary>
    /// <value>Schema owner type, which can be: 0: user, 1: company</value>
    [DataMember(Name="ownerType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ownerType")]
    public decimal? OwnerType { get; set; }

    /// <summary>
    /// Metadata schema ID
    /// </summary>
    /// <value>Metadata schema ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Object type of the property, which can be: 0:GLOBAL, 1:DOCUMENT,             2:PART, 3:ASSEMBLY, 4:DRAWING, 5:PART_STUDIO, 6: BLOB_ELEMENT, 7:APP_ELEMENT, 8:VERSION, 9:WORKSPACE
    /// </summary>
    /// <value>Object type of the property, which can be: 0:GLOBAL, 1:DOCUMENT,             2:PART, 3:ASSEMBLY, 4:DRAWING, 5:PART_STUDIO, 6: BLOB_ELEMENT, 7:APP_ELEMENT, 8:VERSION, 9:WORKSPACE</value>
    [DataMember(Name="objectType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "objectType")]
    public decimal? ObjectType { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MetadataGetMetadataSchemaResponse200 {\n");
      sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
      sb.Append("  Href: ").Append(Href).Append("\n");
      sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
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
