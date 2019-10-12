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
  public class DocumentsExportElementPostJsonBody {
    /// <summary>
    /// Chord tolerance (STL)
    /// </summary>
    /// <value>Chord tolerance (STL)</value>
    [DataMember(Name="chordTolerance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "chordTolerance")]
    public decimal? ChordTolerance { get; set; }

    /// <summary>
    /// Whether single file output should be returned as a .zip           file (STL, grouping==true)
    /// </summary>
    /// <value>Whether single file output should be returned as a .zip           file (STL, grouping==true)</value>
    [DataMember(Name="zipSingleFileOutput", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "zipSingleFileOutput")]
    public bool? ZipSingleFileOutput { get; set; }

    /// <summary>
    /// Parasolid version (PS)
    /// </summary>
    /// <value>Parasolid version (PS)</value>
    [DataMember(Name="version", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "version")]
    public decimal? Version { get; set; }

    /// <summary>
    /// Export format: STL, PS
    /// </summary>
    /// <value>Export format: STL, PS</value>
    [DataMember(Name="format", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "format")]
    public string Format { get; set; }

    /// <summary>
    /// Specified microversion for operation
    /// </summary>
    /// <value>Specified microversion for operation</value>
    [DataMember(Name="microversion", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "microversion")]
    public string Microversion { get; set; }

    /// <summary>
    /// Angle tolerance (must be < pi/2) (STL)
    /// </summary>
    /// <value>Angle tolerance (must be < pi/2) (STL)</value>
    [DataMember(Name="angleTolerance", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "angleTolerance")]
    public decimal? AngleTolerance { get; set; }

    /// <summary>
    /// Minimum facet width (must be < maximumFacetWidth) (STL)
    /// </summary>
    /// <value>Minimum facet width (must be < maximumFacetWidth) (STL)</value>
    [DataMember(Name="minFacetWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minFacetWidth")]
    public decimal? MinFacetWidth { get; set; }

    /// <summary>
    /// Scale for measurements (STL)
    /// </summary>
    /// <value>Scale for measurements (STL)</value>
    [DataMember(Name="scale", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "scale")]
    public decimal? Scale { get; set; }

    /// <summary>
    /// Comma-separated list of part IDs to export
    /// </summary>
    /// <value>Comma-separated list of part IDs to export</value>
    [DataMember(Name="partIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partIds")]
    public string PartIds { get; set; }

    /// <summary>
    /// Type of file: text, binary (STL)
    /// </summary>
    /// <value>Type of file: text, binary (STL)</value>
    [DataMember(Name="mode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "mode")]
    public string Mode { get; set; }

    /// <summary>
    /// Name of base unit: meter, centimeter, millimeter, inch, foot, yard (STL)
    /// </summary>
    /// <value>Name of base unit: meter, centimeter, millimeter, inch, foot, yard (STL)</value>
    [DataMember(Name="units", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "units")]
    public string Units { get; set; }

    /// <summary>
    /// whether the output should be stored as a new element
    /// </summary>
    /// <value>whether the output should be stored as a new element</value>
    [DataMember(Name="storeInDocument", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "storeInDocument")]
    public bool? StoreInDocument { get; set; }

    /// <summary>
    /// Maximum facet width (STL)
    /// </summary>
    /// <value>Maximum facet width (STL)</value>
    [DataMember(Name="maxFacetWidth", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "maxFacetWidth")]
    public decimal? MaxFacetWidth { get; set; }

    /// <summary>
    /// The id of the workspace in which the result should be stored           if storeInDocument is true and linkDocumentId is set.
    /// </summary>
    /// <value>The id of the workspace in which the result should be stored           if storeInDocument is true and linkDocumentId is set.</value>
    [DataMember(Name="linkDocumentWorkspaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "linkDocumentWorkspaceId")]
    public string LinkDocumentWorkspaceId { get; set; }

    /// <summary>
    /// Whether parts should be exported as a group or individually in a .zip           file (STL)
    /// </summary>
    /// <value>Whether parts should be exported as a group or individually in a .zip           file (STL)</value>
    [DataMember(Name="grouping", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "grouping")]
    public bool? Grouping { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsExportElementPostJsonBody {\n");
      sb.Append("  ChordTolerance: ").Append(ChordTolerance).Append("\n");
      sb.Append("  ZipSingleFileOutput: ").Append(ZipSingleFileOutput).Append("\n");
      sb.Append("  Version: ").Append(Version).Append("\n");
      sb.Append("  Format: ").Append(Format).Append("\n");
      sb.Append("  Microversion: ").Append(Microversion).Append("\n");
      sb.Append("  AngleTolerance: ").Append(AngleTolerance).Append("\n");
      sb.Append("  MinFacetWidth: ").Append(MinFacetWidth).Append("\n");
      sb.Append("  Scale: ").Append(Scale).Append("\n");
      sb.Append("  PartIds: ").Append(PartIds).Append("\n");
      sb.Append("  Mode: ").Append(Mode).Append("\n");
      sb.Append("  Units: ").Append(Units).Append("\n");
      sb.Append("  StoreInDocument: ").Append(StoreInDocument).Append("\n");
      sb.Append("  MaxFacetWidth: ").Append(MaxFacetWidth).Append("\n");
      sb.Append("  LinkDocumentWorkspaceId: ").Append(LinkDocumentWorkspaceId).Append("\n");
      sb.Append("  Grouping: ").Append(Grouping).Append("\n");
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
