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
  public class AssembliesCreateInstanceBody {
    /// <summary>
    /// If isAssembly and isWholePartStudio are false, then this is the id of the part           or surface to be inserted. Must be left blank if featureId is set.
    /// </summary>
    /// <value>If isAssembly and isWholePartStudio are false, then this is the id of the part           or surface to be inserted. Must be left blank if featureId is set.</value>
    [DataMember(Name="partId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partId")]
    public string PartId { get; set; }

    /// <summary>
    /// If isAssembly and isWholePartStudio are false, then this is the id of the           feature to be inserted. Currently, only sketch features are valid. Must be left blank if partId is set.
    /// </summary>
    /// <value>If isAssembly and isWholePartStudio are false, then this is the id of the           feature to be inserted. Currently, only sketch features are valid. Must be left blank if partId is set.</value>
    [DataMember(Name="featureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureId")]
    public string FeatureId { get; set; }

    /// <summary>
    /// If true then the source element must be an assembly and whole assembly is           inserted.
    /// </summary>
    /// <value>If true then the source element must be an assembly and whole assembly is           inserted.</value>
    [DataMember(Name="isAssembly", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isAssembly")]
    public bool? IsAssembly { get; set; }

    /// <summary>
    /// The document microversionId in which the elementId and partId will be           resolved. This is valid only if no versionId is specified. When a versionId is specified, the partId           must be obtained from the specified version.
    /// </summary>
    /// <value>The document microversionId in which the elementId and partId will be           resolved. This is valid only if no versionId is specified. When a versionId is specified, the partId           must be obtained from the specified version.</value>
    [DataMember(Name="microversionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversionId")]
    public string MicroversionId { get; set; }

    /// <summary>
    /// The document versionId from which the parts or assembly to be inserted will           be taken. If documentId references a different document than did, this must be set to a valid version.
    /// </summary>
    /// <value>The document versionId from which the parts or assembly to be inserted will           be taken. If documentId references a different document than did, this must be set to a valid version.</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// The id of the content document containing the parts or assemblies to be           inserted.
    /// </summary>
    /// <value>The id of the content document containing the parts or assemblies to be           inserted.</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }

    /// <summary>
    /// Configuration of the source element, valid only if the           referenced element is a Part Studio.
    /// </summary>
    /// <value>Configuration of the source element, valid only if the           referenced element is a Part Studio.</value>
    [DataMember(Name="configuration", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "configuration")]
    public string Configuration { get; set; }

    /// <summary>
    /// The id of the element containing the part(s), feature or assemblies to be           inserted.
    /// </summary>
    /// <value>The id of the element containing the part(s), feature or assemblies to be           inserted.</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// If true then the source element must be a partStudio and all parts           are inserted.
    /// </summary>
    /// <value>If true then the source element must be a partStudio and all parts           are inserted.</value>
    [DataMember(Name="isWholePartStudio", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isWholePartStudio")]
    public bool? IsWholePartStudio { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AssembliesCreateInstanceBody {\n");
      sb.Append("  PartId: ").Append(PartId).Append("\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  IsAssembly: ").Append(IsAssembly).Append("\n");
      sb.Append("  MicroversionId: ").Append(MicroversionId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
      sb.Append("  Configuration: ").Append(Configuration).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  IsWholePartStudio: ").Append(IsWholePartStudio).Append("\n");
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
