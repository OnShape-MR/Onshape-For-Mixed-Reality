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
  public class AppElementsCreateElementBody {
    /// <summary>
    /// The format id for the application element
    /// </summary>
    /// <value>The format id for the application element</value>
    [DataMember(Name="formatId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatId")]
    public string FormatId { get; set; }

    /// <summary>
    /// Gets or Sets Location
    /// </summary>
    [DataMember(Name="location", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "location")]
    public AppElementsCreateElementBodyLocation Location { get; set; }

    /// <summary>
    /// Initial list of sub-element contents
    /// </summary>
    /// <value>Initial list of sub-element contents</value>
    [DataMember(Name="subelements", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "subelements")]
    public List<AppElementsCreateElementBodySubelements> Subelements { get; set; }

    /// <summary>
    /// Requested app-element name
    /// </summary>
    /// <value>Requested app-element name</value>
    [DataMember(Name="name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "name")]
    public string Name { get; set; }

    /// <summary>
    /// Description of the change being made, for history tracking
    /// </summary>
    /// <value>Description of the change being made, for history tracking</value>
    [DataMember(Name="description", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "description")]
    public string Description { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsCreateElementBody {\n");
      sb.Append("  FormatId: ").Append(FormatId).Append("\n");
      sb.Append("  Location: ").Append(Location).Append("\n");
      sb.Append("  Subelements: ").Append(Subelements).Append("\n");
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
