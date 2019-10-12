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
  public class WebhooksGetWebhookResponse200 {
    /// <summary>
    /// URL to which notifications are sent
    /// </summary>
    /// <value>URL to which notifications are sent</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// ID of webhook
    /// </summary>
    /// <value>ID of webhook</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Context for webhook
    /// </summary>
    /// <value>Context for webhook</value>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter")]
    public string Filter { get; set; }

    /// <summary>
    /// Number of dropped events
    /// </summary>
    /// <value>Number of dropped events</value>
    [DataMember(Name="droppedEventCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "droppedEventCount")]
    public decimal? DroppedEventCount { get; set; }

    /// <summary>
    /// Gets or Sets Options
    /// </summary>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public WebhooksGetWebhookResponse200Options Options { get; set; }

    /// <summary>
    /// Data returned from webhook
    /// </summary>
    /// <value>Data returned from webhook</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public string Data { get; set; }

    /// <summary>
    /// Array of events to which webhook is registered
    /// </summary>
    /// <value>Array of events to which webhook is registered</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhooksGetWebhookResponse200 {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      sb.Append("  DroppedEventCount: ").Append(DroppedEventCount).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
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
