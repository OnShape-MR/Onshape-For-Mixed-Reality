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
  public class BlobElementsUploadFileUpdateElementBody {
    /// <summary>
    /// If storeInDocument is true and formatName is ONSHAPE and        the source is a Parasolid file, this specifies the preference as to whether the import should be completed        prior to the completion of the request (importInBackground=false) or whether it should be performed        asynchronously (importInBackground=true). Historically, this parameter was implicitly set to false, but large        imports can take long enough that the request could result in a timeout. Applications are encouraged to set        this parameter to true for reliable operation.
    /// </summary>
    /// <value>If storeInDocument is true and formatName is ONSHAPE and        the source is a Parasolid file, this specifies the preference as to whether the import should be completed        prior to the completion of the request (importInBackground=false) or whether it should be performed        asynchronously (importInBackground=true). Historically, this parameter was implicitly set to false, but large        imports can take long enough that the request could result in a timeout. Applications are encouraged to set        this parameter to true for reliable operation.</value>
    [DataMember(Name="importInBackground", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "importInBackground")]
    public bool? ImportInBackground { get; set; }

    /// <summary>
    /// The length of the file being uploaded, in bytes. If not present,    Onshape may restrict the upload size under some operating conditions, as the file contents may need to be    buffered in memory. If specified, it should be the actual length of the data being uploaded.
    /// </summary>
    /// <value>The length of the file being uploaded, in bytes. If not present,    Onshape may restrict the upload size under some operating conditions, as the file contents may need to be    buffered in memory. If specified, it should be the actual length of the data being uploaded.</value>
    [DataMember(Name="fileContentLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fileContentLength")]
    public decimal? FileContentLength { get; set; }

    /// <summary>
    /// Filename override interpreted as a URL-encoded string. If specified,    this overrides the filename from a Content-Disposition in the file field.
    /// </summary>
    /// <value>Filename override interpreted as a URL-encoded string. If specified,    this overrides the filename from a Content-Disposition in the file field.</value>
    [DataMember(Name="encodedFilename", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "encodedFilename")]
    public string EncodedFilename { get; set; }

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
    /// Whether the uploaded file should be translated to Onshape format,    if possible
    /// </summary>
    /// <value>Whether the uploaded file should be translated to Onshape format,    if possible</value>
    [DataMember(Name="translate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "translate")]
    public bool? Translate { get; set; }

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
      sb.Append("class BlobElementsUploadFileUpdateElementBody {\n");
      sb.Append("  ImportInBackground: ").Append(ImportInBackground).Append("\n");
      sb.Append("  FileContentLength: ").Append(FileContentLength).Append("\n");
      sb.Append("  EncodedFilename: ").Append(EncodedFilename).Append("\n");
      sb.Append("  FlattenAssemblies: ").Append(FlattenAssemblies).Append("\n");
      sb.Append("  YAxisIsUp: ").Append(YAxisIsUp).Append("\n");
      sb.Append("  Translate: ").Append(Translate).Append("\n");
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
