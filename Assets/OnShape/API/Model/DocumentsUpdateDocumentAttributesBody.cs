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
  public class DocumentsUpdateDocumentAttributesBody {
    /// <summary>
    /// Whether document is not revision managed
    /// </summary>
    /// <value>Whether document is not revision managed</value>
    [DataMember(Name="notRevisionManaged", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notRevisionManaged")]
    public bool? NotRevisionManaged { get; set; }

    /// <summary>
    /// New document name
    /// </summary>
    /// <value>New document name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// New document description
    /// </summary>
    /// <value>New document description</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsUpdateDocumentAttributesBody {\n");
      sb.Append("  NotRevisionManaged: ").Append(NotRevisionManaged).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Description: ").Append(Description).Append("\n");
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
