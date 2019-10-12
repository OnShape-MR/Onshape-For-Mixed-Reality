using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// A single sketch entity description. The fields of each    sketch entity depend on the type of entity.
  /// </summary>
  [DataContract]
  public class PartStudiosGetSketchInfoResponse200GeomEntities {
    /// <summary>
    /// (spline[Segment]) The spline knot vector
    /// </summary>
    /// <value>(spline[Segment]) The spline knot vector</value>
    [DataMember(Name="knots", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "knots")]
    public List<decimal?> Knots { get; set; }

    /// <summary>
    /// (lineSegment, arc, ellipticArc, curvePoints=true) The end point of the segment
    /// </summary>
    /// <value>(lineSegment, arc, ellipticArc, curvePoints=true) The end point of the segment</value>
    [DataMember(Name="endPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endPoint")]
    public List<decimal?> EndPoint { get; set; }

    /// <summary>
    /// (line) An arbitrary point on the line
    /// </summary>
    /// <value>(line) An arbitrary point on the line</value>
    [DataMember(Name="point", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "point")]
    public List<decimal?> Point { get; set; }

    /// <summary>
    /// (curvePoints=true) The point that is half    way between the start and end of the curve
    /// </summary>
    /// <value>(curvePoints=true) The point that is half    way between the start and end of the curve</value>
    [DataMember(Name="midPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "midPoint")]
    public List<decimal?> MidPoint { get; set; }

    /// <summary>
    /// The type of the entity. Can be one of:    \"point\", \"line\", \"lineSegment\", \"circle\", \"arc\", \"ellipse\", \"ellipticArc\", \"spline\", \"splineSegment\",    \"interpolatedSpline\", \"interpolatedSplineSegment\", \"unknownGeometry\".
    /// </summary>
    /// <value>The type of the entity. Can be one of:    \"point\", \"line\", \"lineSegment\", \"circle\", \"arc\", \"ellipse\", \"ellipticArc\", \"spline\", \"splineSegment\",    \"interpolatedSpline\", \"interpolatedSplineSegment\", \"unknownGeometry\".</value>
    [DataMember(Name="entityType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "entityType")]
    public string EntityType { get; set; }

    /// <summary>
    /// (curvePoints=true) The tangent vector    at the start of the curve
    /// </summary>
    /// <value>(curvePoints=true) The tangent vector    at the start of the curve</value>
    [DataMember(Name="startVector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startVector")]
    public List<decimal?> StartVector { get; set; }

    /// <summary>
    /// (circle, arc). The circular radius
    /// </summary>
    /// <value>(circle, arc). The circular radius</value>
    [DataMember(Name="radius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "radius")]
    public decimal? Radius { get; set; }

    /// <summary>
    /// (arc, ellipticArc) If true, the segment    is oriented clockwise from the startPoint to the endPoint around the center.
    /// </summary>
    /// <value>(arc, ellipticArc) If true, the segment    is oriented clockwise from the startPoint to the endPoint around the center.</value>
    [DataMember(Name="clockwise", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "clockwise")]
    public bool? Clockwise { get; set; }

    /// <summary>
    /// (lineSegment, arc, ellipticArc, curvePoints=true)    The start point of the segment
    /// </summary>
    /// <value>(lineSegment, arc, ellipticArc, curvePoints=true)    The start point of the segment</value>
    [DataMember(Name="startPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startPoint")]
    public List<decimal?> StartPoint { get; set; }

    /// <summary>
    /// (splineSegment, interpolatedSplineSegment)    The end parameter of the spline segment
    /// </summary>
    /// <value>(splineSegment, interpolatedSplineSegment)    The end parameter of the spline segment</value>
    [DataMember(Name="endParam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endParam")]
    public decimal? EndParam { get; set; }

    /// <summary>
    /// (splineSegment, interpolatedSplineSegment)    The start parameter of the spline segment
    /// </summary>
    /// <value>(splineSegment, interpolatedSplineSegment)    The start parameter of the spline segment</value>
    [DataMember(Name="startParam", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startParam")]
    public decimal? StartParam { get; set; }

    /// <summary>
    /// A 2-dimensional array of endpoint ids,    if the curve is a bounded curve.
    /// </summary>
    /// <value>A 2-dimensional array of endpoint ids,    if the curve is a bounded curve.</value>
    [DataMember(Name="endPointIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endPointIds")]
    public List<string> EndPointIds { get; set; }

    /// <summary>
    /// (interpolatedSpline[Segment]) For    a non-periodic spline the derivative at the end of the spline
    /// </summary>
    /// <value>(interpolatedSpline[Segment]) For    a non-periodic spline the derivative at the end of the spline</value>
    [DataMember(Name="endDerivative", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endDerivative")]
    public List<decimal?> EndDerivative { get; set; }

    /// <summary>
    /// (interpolatedSpline[Segment]) For    a non-periodic spline the derivative at the start of the spline
    /// </summary>
    /// <value>(interpolatedSpline[Segment]) For    a non-periodic spline the derivative at the start of the spline</value>
    [DataMember(Name="startDerivative", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startDerivative")]
    public List<decimal?> StartDerivative { get; set; }

    /// <summary>
    /// (ellipse, ellipticArc) The minor radius    of the elliptic entity
    /// </summary>
    /// <value>(ellipse, ellipticArc) The minor radius    of the elliptic entity</value>
    [DataMember(Name="minorRadius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "minorRadius")]
    public decimal? MinorRadius { get; set; }

    /// <summary>
    /// (spline[Segment]) If true, the spline is    in rational form
    /// </summary>
    /// <value>(spline[Segment]) If true, the spline is    in rational form</value>
    [DataMember(Name="rational", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "rational")]
    public bool? Rational { get; set; }

    /// <summary>
    /// (curvePoints=true) The length of the curve
    /// </summary>
    /// <value>(curvePoints=true) The length of the curve</value>
    [DataMember(Name="curveLength", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "curveLength")]
    public decimal? CurveLength { get; set; }

    /// <summary>
    /// (spline[Segment]) The spline control    points
    /// </summary>
    /// <value>(spline[Segment]) The spline control    points</value>
    [DataMember(Name="controlPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "controlPoints")]
    public List<Object> ControlPoints { get; set; }

    /// <summary>
    /// (line, ellipse, ellipticArc)    For line, this is the line direction. For elliptic entities, this is the direction of the major axis.
    /// </summary>
    /// <value>(line, ellipse, ellipticArc)    For line, this is the line direction. For elliptic entities, this is the direction of the major axis.</value>
    [DataMember(Name="direction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "direction")]
    public List<decimal?> Direction { get; set; }

    /// <summary>
    /// (spline[Segment]) The degree of the spline
    /// </summary>
    /// <value>(spline[Segment]) The degree of the spline</value>
    [DataMember(Name="degree", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "degree")]
    public decimal? Degree { get; set; }

    /// <summary>
    /// (interpolatedSpline[Segment])  For a    non-periodic spline, the end handle point use to determine the end derivative.
    /// </summary>
    /// <value>(interpolatedSpline[Segment])  For a    non-periodic spline, the end handle point use to determine the end derivative.</value>
    [DataMember(Name="endHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endHandle")]
    public List<decimal?> EndHandle { get; set; }

    /// <summary>
    /// (curvePoints=true) The point that is one    quarter way between the start and end of the curve
    /// </summary>
    /// <value>(curvePoints=true) The point that is one    quarter way between the start and end of the curve</value>
    [DataMember(Name="quarterPoint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "quarterPoint")]
    public List<decimal?> QuarterPoint { get; set; }

    /// <summary>
    /// (interpolatedSpline[Segment])    The interpolation points for the spline
    /// </summary>
    /// <value>(interpolatedSpline[Segment])    The interpolation points for the spline</value>
    [DataMember(Name="interpolationPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "interpolationPoints")]
    public List<decimal?> InterpolationPoints { get; set; }

    /// <summary>
    /// (ellipse, ellipticArc) The major radius    of the elliptic entity
    /// </summary>
    /// <value>(ellipse, ellipticArc) The major radius    of the elliptic entity</value>
    [DataMember(Name="majorRadius", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "majorRadius")]
    public decimal? MajorRadius { get; set; }

    /// <summary>
    /// (curvePoints=true) The tangent vector    at the end of the curve
    /// </summary>
    /// <value>(curvePoints=true) The tangent vector    at the end of the curve</value>
    [DataMember(Name="endVector", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "endVector")]
    public List<decimal?> EndVector { get; set; }

    /// <summary>
    /// (circle, arc, ellipse, ellipticArc) The center    point
    /// </summary>
    /// <value>(circle, arc, ellipse, ellipticArc) The center    point</value>
    [DataMember(Name="center", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "center")]
    public List<decimal?> Center { get; set; }

    /// <summary>
    /// (spline[Segment]) The number of    control points in the spline
    /// </summary>
    /// <value>(spline[Segment]) The number of    control points in the spline</value>
    [DataMember(Name="numberControlPoints", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "numberControlPoints")]
    public decimal? NumberControlPoints { get; set; }

    /// <summary>
    /// (interpolatedSpline[Segment]) For a    non-periodic spline, the start handle point use to determine the start derivative.
    /// </summary>
    /// <value>(interpolatedSpline[Segment]) For a    non-periodic spline, the start handle point use to determine the start derivative.</value>
    [DataMember(Name="startHandle", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "startHandle")]
    public List<decimal?> StartHandle { get; set; }

    /// <summary>
    /// (spline[Segment], interpolatedSpline[Segment])    If true, the spline entity is periodic
    /// </summary>
    /// <value>(spline[Segment], interpolatedSpline[Segment])    If true, the spline entity is periodic</value>
    [DataMember(Name="periodic", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "periodic")]
    public bool? Periodic { get; set; }

    /// <summary>
    /// Set to true if this is a construction    entity
    /// </summary>
    /// <value>Set to true if this is a construction    entity</value>
    [DataMember(Name="isConstruction", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "isConstruction")]
    public bool? IsConstruction { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class PartStudiosGetSketchInfoResponse200GeomEntities {\n");
      sb.Append("  Knots: ").Append(Knots).Append("\n");
      sb.Append("  EndPoint: ").Append(EndPoint).Append("\n");
      sb.Append("  Point: ").Append(Point).Append("\n");
      sb.Append("  MidPoint: ").Append(MidPoint).Append("\n");
      sb.Append("  EntityType: ").Append(EntityType).Append("\n");
      sb.Append("  StartVector: ").Append(StartVector).Append("\n");
      sb.Append("  Radius: ").Append(Radius).Append("\n");
      sb.Append("  Clockwise: ").Append(Clockwise).Append("\n");
      sb.Append("  StartPoint: ").Append(StartPoint).Append("\n");
      sb.Append("  EndParam: ").Append(EndParam).Append("\n");
      sb.Append("  StartParam: ").Append(StartParam).Append("\n");
      sb.Append("  EndPointIds: ").Append(EndPointIds).Append("\n");
      sb.Append("  EndDerivative: ").Append(EndDerivative).Append("\n");
      sb.Append("  StartDerivative: ").Append(StartDerivative).Append("\n");
      sb.Append("  MinorRadius: ").Append(MinorRadius).Append("\n");
      sb.Append("  Rational: ").Append(Rational).Append("\n");
      sb.Append("  CurveLength: ").Append(CurveLength).Append("\n");
      sb.Append("  ControlPoints: ").Append(ControlPoints).Append("\n");
      sb.Append("  Direction: ").Append(Direction).Append("\n");
      sb.Append("  Degree: ").Append(Degree).Append("\n");
      sb.Append("  EndHandle: ").Append(EndHandle).Append("\n");
      sb.Append("  QuarterPoint: ").Append(QuarterPoint).Append("\n");
      sb.Append("  InterpolationPoints: ").Append(InterpolationPoints).Append("\n");
      sb.Append("  MajorRadius: ").Append(MajorRadius).Append("\n");
      sb.Append("  EndVector: ").Append(EndVector).Append("\n");
      sb.Append("  Center: ").Append(Center).Append("\n");
      sb.Append("  NumberControlPoints: ").Append(NumberControlPoints).Append("\n");
      sb.Append("  StartHandle: ").Append(StartHandle).Append("\n");
      sb.Append("  Periodic: ").Append(Periodic).Append("\n");
      sb.Append("  IsConstruction: ").Append(IsConstruction).Append("\n");
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
