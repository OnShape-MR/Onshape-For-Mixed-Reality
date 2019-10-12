using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Options for the webhook
  /// </summary>
  [DataContract]
  public class WebhooksGetWebhookResponse200Options {
    /// <summary>
    /// Whether similar events are collapsed into one notification
    /// </summary>
    /// <value>Whether similar events are collapsed into one notification</value>
    [DataMember(Name="collapseEvents", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "collapseEvents")]
    public bool? CollapseEvents { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhooksGetWebhookResponse200Options {\n");
      sb.Append("  CollapseEvents: ").Append(CollapseEvents).Append("\n");
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
