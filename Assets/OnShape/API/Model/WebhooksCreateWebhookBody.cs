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
  public class WebhooksCreateWebhookBody {
    /// <summary>
    /// URL to which to send notifications
    /// </summary>
    /// <value>URL to which to send notifications</value>
    [DataMember(Name="url", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "url")]
    public string Url { get; set; }

    /// <summary>
    /// Context for webhook, in one of two forms:  \"{$DocumentId} = '[did]' && {$WorkspaceId} = '[wid]' && {$ElementId} = '[eid]'\"  or \"{$UserId} = '[uid]' && {$ClientId} = 'cid'\"  [did] is a document ID, etc., but the components in brackets and the quotes must remain exactly as written, in the same order
    /// </summary>
    /// <value>Context for webhook, in one of two forms:  \"{$DocumentId} = '[did]' && {$WorkspaceId} = '[wid]' && {$ElementId} = '[eid]'\"  or \"{$UserId} = '[uid]' && {$ClientId} = 'cid'\"  [did] is a document ID, etc., but the components in brackets and the quotes must remain exactly as written, in the same order</value>
    [DataMember(Name="filter", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "filter")]
    public string Filter { get; set; }

    /// <summary>
    /// Data to encapsulate in webhook
    /// </summary>
    /// <value>Data to encapsulate in webhook</value>
    [DataMember(Name="data", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "data")]
    public string Data { get; set; }

    /// <summary>
    /// Array of event names for which to register webhook
    /// </summary>
    /// <value>Array of event names for which to register webhook</value>
    [DataMember(Name="events", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "events")]
    public List<string> Events { get; set; }

    /// <summary>
    /// Options object, with one optional field: collapseEvents, which is set to true/false and says whether similar events should be collapsed into one notification
    /// </summary>
    /// <value>Options object, with one optional field: collapseEvents, which is set to true/false and says whether similar events should be collapsed into one notification</value>
    [DataMember(Name="options", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "options")]
    public Object Options { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class WebhooksCreateWebhookBody {\n");
      sb.Append("  Url: ").Append(Url).Append("\n");
      sb.Append("  Filter: ").Append(Filter).Append("\n");
      sb.Append("  Data: ").Append(Data).Append("\n");
      sb.Append("  Events: ").Append(Events).Append("\n");
      sb.Append("  Options: ").Append(Options).Append("\n");
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
