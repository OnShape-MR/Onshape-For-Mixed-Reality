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
  public class PartStudiosIdTranslationsBody {
    /// <summary>
    /// The id from which this request originated, in the case that it is           different than :did and :wvm is not a workspace.
    /// </summary>
    /// <value>The id from which this request originated, in the case that it is           different than :did and :wvm is not a workspace.</value>
    [DataMember(Name="linkDocumentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkDocumentId")]
    public string LinkDocumentId { get; set; }

    /// <summary>
    /// Array of topology ID strings
    /// </summary>
    /// <value>Array of topology ID strings</value>
    [DataMember(Name="ids", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ids")]
    public List<string> Ids { get; set; }

    /// <summary>
    /// document microversion of the source ids.
    /// </summary>
    /// <value>document microversion of the source ids.</value>
    [DataMember(Name="sourceDocumentMicroversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceDocumentMicroversion")]
    public string SourceDocumentMicroversion { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosIdTranslationsBody {\n");
      sb.Append("  LinkDocumentId: ").Append(LinkDocumentId).Append("\n");
      sb.Append("  Ids: ").Append(Ids).Append("\n");
      sb.Append("  SourceDocumentMicroversion: ").Append(SourceDocumentMicroversion).Append("\n");
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
