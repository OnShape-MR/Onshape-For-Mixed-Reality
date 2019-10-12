using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// Insertable information
  /// </summary>
  [DataContract]
  public class DocumentsGetInsertablesResponse200Items {
    /// <summary>
    /// Feature type
    /// </summary>
    /// <value>Feature type</value>
    [DataMember(Name="featureType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureType")]
    public string FeatureType { get; set; }

    /// <summary>
    /// Element name
    /// </summary>
    /// <value>Element name</value>
    [DataMember(Name="elementName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementName")]
    public string ElementName { get; set; }

    /// <summary>
    /// Body type
    /// </summary>
    /// <value>Body type</value>
    [DataMember(Name="bodyType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "bodyType")]
    public string BodyType { get; set; }

    /// <summary>
    /// Insertable query
    /// </summary>
    /// <value>Insertable query</value>
    [DataMember(Name="insertableQuery", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "insertableQuery")]
    public string InsertableQuery { get; set; }

    /// <summary>
    /// Data type
    /// </summary>
    /// <value>Data type</value>
    [DataMember(Name="dataType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "dataType")]
    public string DataType { get; set; }

    /// <summary>
    /// The type of insertable
    /// </summary>
    /// <value>The type of insertable</value>
    [DataMember(Name="classType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "classType")]
    public decimal? ClassType { get; set; }

    /// <summary>
    /// Part name
    /// </summary>
    /// <value>Part name</value>
    [DataMember(Name="partName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "partName")]
    public string PartName { get; set; }

    /// <summary>
    /// Feature ID
    /// </summary>
    /// <value>Feature ID</value>
    [DataMember(Name="featureId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureId")]
    public string FeatureId { get; set; }

    /// <summary>
    /// Version ID
    /// </summary>
    /// <value>Version ID</value>
    [DataMember(Name="versionId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionId")]
    public string VersionId { get; set; }

    /// <summary>
    /// Feature name
    /// </summary>
    /// <value>Feature name</value>
    [DataMember(Name="featureName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "featureName")]
    public string FeatureName { get; set; }

    /// <summary>
    /// Element ID
    /// </summary>
    /// <value>Element ID</value>
    [DataMember(Name="elementId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementId")]
    public string ElementId { get; set; }

    /// <summary>
    /// Version name
    /// </summary>
    /// <value>Version name</value>
    [DataMember(Name="versionName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "versionName")]
    public string VersionName { get; set; }

    /// <summary>
    /// Insertable parent
    /// </summary>
    /// <value>Insertable parent</value>
    [DataMember(Name="parentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentId")]
    public string ParentId { get; set; }

    /// <summary>
    /// Thumbnail URI
    /// </summary>
    /// <value>Thumbnail URI</value>
    [DataMember(Name="thumbnailUri", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "thumbnailUri")]
    public string ThumbnailUri { get; set; }

    /// <summary>
    /// Part deteministic ID
    /// </summary>
    /// <value>Part deteministic ID</value>
    [DataMember(Name="deterministicId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "deterministicId")]
    public string DeterministicId { get; set; }

    /// <summary>
    /// Element type
    /// </summary>
    /// <value>Element type</value>
    [DataMember(Name="elementType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "elementType")]
    public string ElementType { get; set; }

    /// <summary>
    /// Insertable ID
    /// </summary>
    /// <value>Insertable ID</value>
    [DataMember(Name="id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "id")]
    public string Id { get; set; }

    /// <summary>
    /// Document ID
    /// </summary>
    /// <value>Document ID</value>
    [DataMember(Name="documentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "documentId")]
    public string DocumentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class DocumentsGetInsertablesResponse200Items {\n");
      sb.Append("  FeatureType: ").Append(FeatureType).Append("\n");
      sb.Append("  ElementName: ").Append(ElementName).Append("\n");
      sb.Append("  BodyType: ").Append(BodyType).Append("\n");
      sb.Append("  InsertableQuery: ").Append(InsertableQuery).Append("\n");
      sb.Append("  DataType: ").Append(DataType).Append("\n");
      sb.Append("  ClassType: ").Append(ClassType).Append("\n");
      sb.Append("  PartName: ").Append(PartName).Append("\n");
      sb.Append("  FeatureId: ").Append(FeatureId).Append("\n");
      sb.Append("  VersionId: ").Append(VersionId).Append("\n");
      sb.Append("  FeatureName: ").Append(FeatureName).Append("\n");
      sb.Append("  ElementId: ").Append(ElementId).Append("\n");
      sb.Append("  VersionName: ").Append(VersionName).Append("\n");
      sb.Append("  ParentId: ").Append(ParentId).Append("\n");
      sb.Append("  ThumbnailUri: ").Append(ThumbnailUri).Append("\n");
      sb.Append("  DeterministicId: ").Append(DeterministicId).Append("\n");
      sb.Append("  ElementType: ").Append(ElementType).Append("\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
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
