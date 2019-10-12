using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Object containing a field for each named view. The key of each field is the name of the view
  /// </summary>
  [DataContract]
  public class AssembliesGetNamedViewsResponse200NamedViews {
    /// <summary>
    /// Gets or Sets ViewName
    /// </summary>
    [DataMember(Name="viewName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "viewName")]
    public AssembliesGetNamedViewsResponse200NamedViewsViewName ViewName { get; set; }

    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name="key", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "key")]
    public AssembliesGetNamedViewsResponse200NamedViewsKey Key { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesGetNamedViewsResponse200NamedViews {\n");
      sb.Append("  ViewName: ").Append(ViewName).Append("\n");
      sb.Append("  Key: ").Append(Key).Append("\n");
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
