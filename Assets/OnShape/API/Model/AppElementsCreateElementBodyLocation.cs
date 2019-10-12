using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Location at which element should be inserted.
  /// </summary>
  [DataContract]
  public class AppElementsCreateElementBodyLocation {
    /// <summary>
    /// An indicator for the relative placement of the new element.    If elementId is specified, a negative number indicates insertion prior to the element and a non-negative    number indicates insertion following the element. If no elementId is specified, a negative value indicates    insertion at the end of the group or element list and a non-negative number indicates insertion at the start    of the group or elmenet list.
    /// </summary>
    /// <value>An indicator for the relative placement of the new element.    If elementId is specified, a negative number indicates insertion prior to the element and a non-negative    number indicates insertion following the element. If no elementId is specified, a negative value indicates    insertion at the end of the group or element list and a non-negative number indicates insertion at the start    of the group or elmenet list.</value>
    [DataMember(Name="position", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "position")]
    public decimal? Position { get; set; }

    /// <summary>
    /// For internal use.
    /// </summary>
    /// <value>For internal use.</value>
    [DataMember(Name="groupId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "groupId")]
    public string GroupId { get; set; }

    /// <summary>
    /// Id of an element to place the new element near.
    /// </summary>
    /// <value>Id of an element to place the new element near.</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AppElementsCreateElementBodyLocation {\n");
      sb.Append("  Position: ").Append(Position).Append("\n");
      sb.Append("  GroupId: ").Append(GroupId).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
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
