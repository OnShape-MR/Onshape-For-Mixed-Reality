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
  public class PartStudiosGetSketchInfoResponse200 {
    /// <summary>
    /// Array of information for each sketch
    /// </summary>
    /// <value>Array of information for each sketch</value>
    [DataMember(Name="sketches", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sketches")]
    public List<PartStudiosGetSketchInfoResponse200Sketches> Sketches { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetSketchInfoResponse200 {\n");
      sb.Append("  Sketches: ").Append(Sketches).Append("\n");
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
