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
  public class TranslationsCreateTranslationBody {
    /// <summary>
    /// If storeInDocument is true and formatName is ONSHAPE and        the source is a Parasolid file, this specifies the preference as to whether the import should be completed        prior to the completion of the request (importInBackground=false) or whether it should be performed        asynchronously (importInBackground=true). Historically, this parameter was implicitly set to false, but large        imports can take long enough that the request could result in a timeout. Applications are encouraged to set        this parameter to true for reliable operation.
    /// </summary>
    /// <value>If storeInDocument is true and formatName is ONSHAPE and        the source is a Parasolid file, this specifies the preference as to whether the import should be completed        prior to the completion of the request (importInBackground=false) or whether it should be performed        asynchronously (importInBackground=true). Historically, this parameter was implicitly set to false, but large        imports can take long enough that the request could result in a timeout. Applications are encouraged to set        this parameter to true for reliable operation.</value>
    [DataMember(Name="importInBackground", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importInBackground")]
    public bool? ImportInBackground { get; set; }

    /// <summary>
    /// Version of output format to use (format-dependent)
    /// </summary>
    /// <value>Version of output format to use (format-dependent)</value>
    [DataMember(Name="versionString", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionString")]
    public string VersionString { get; set; }

    /// <summary>
    /// Name of format into which this element should be translated. ONSHAPE        indicates that the model file should be translated into a Part Studio or Assembly.
    /// </summary>
    /// <value>Name of format into which this element should be translated. ONSHAPE        indicates that the model file should be translated into a Part Studio or Assembly.</value>
    [DataMember(Name="formatName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "formatName")]
    public string FormatName { get; set; }

    /// <summary>
    /// If true, remove assembly structure and create only a        Part Studio
    /// </summary>
    /// <value>If true, remove assembly structure and create only a        Part Studio</value>
    [DataMember(Name="flattenAssemblies", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "flattenAssemblies")]
    public bool? FlattenAssemblies { get; set; }

    /// <summary>
    /// If true, treat the model's Y axis as the vertical axis.  Otherwise,        Z is treated as the vertical axis.
    /// </summary>
    /// <value>If true, treat the model's Y axis as the vertical axis.  Otherwise,        Z is treated as the vertical axis.</value>
    [DataMember(Name="yAxisIsUp", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "yAxisIsUp")]
    public bool? YAxisIsUp { get; set; }

    /// <summary>
    /// Whether a user notification should be generated on completion
    /// </summary>
    /// <value>Whether a user notification should be generated on completion</value>
    [DataMember(Name="notifyUser", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "notifyUser")]
    public bool? NotifyUser { get; set; }

    /// <summary>
    /// controls whether the translation is stored as a new element or        whether the data is stored as external data (storeInDocument=false).
    /// </summary>
    /// <value>controls whether the translation is stored as a new element or        whether the data is stored as external data (storeInDocument=false).</value>
    [DataMember(Name="storeInDocument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeInDocument")]
    public bool? StoreInDocument { get; set; }

    /// <summary>
    /// If not specified or if specified as false, bodies to be imported        are examined for validity and any found to be faulty are removed from the import. If all bodies are found to        be faulty, the import fails. If the value is specified as true, we attempt to import the bodies that appear to        have faults.
    /// </summary>
    /// <value>If not specified or if specified as false, bodies to be imported        are examined for validity and any found to be faulty are removed from the import. If all bodies are found to        be faulty, the import fails. If the value is specified as true, we attempt to import the bodies that appear to        have faults.</value>
    [DataMember(Name="allowFaultyParts", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "allowFaultyParts")]
    public bool? AllowFaultyParts { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TranslationsCreateTranslationBody {\n");
      sb.Append("  ImportInBackground: ").Append(ImportInBackground).Append("\n");
      sb.Append("  VersionString: ").Append(VersionString).Append("\n");
      sb.Append("  FormatName: ").Append(FormatName).Append("\n");
      sb.Append("  FlattenAssemblies: ").Append(FlattenAssemblies).Append("\n");
      sb.Append("  YAxisIsUp: ").Append(YAxisIsUp).Append("\n");
      sb.Append("  NotifyUser: ").Append(NotifyUser).Append("\n");
      sb.Append("  StoreInDocument: ").Append(StoreInDocument).Append("\n");
      sb.Append("  AllowFaultyParts: ").Append(AllowFaultyParts).Append("\n");
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
