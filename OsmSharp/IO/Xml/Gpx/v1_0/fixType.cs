using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace OsmSharp.IO.Xml.Gpx.v1_0
{
  [GeneratedCode("xsd", "2.0.50727.3038")]
  [XmlType(Namespace = "http://www.topografix.com/GPX/1/0")]
  public enum fixType
  {
    none,
    [XmlEnum("2d")] Item2d,
    [XmlEnum("3d")] Item3d,
    dgps,
    pps,
  }
}
