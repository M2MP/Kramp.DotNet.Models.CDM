using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Measure
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Measure() { }

        /// <summary>
        /// Construct a new Name with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Measure(decimal value) { Value = value; }

        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode;

        [XmlAttribute(AttributeName = "unitCodeListVersionID")]
        public string UnitCodeListVersionID;

        [XmlText()]
        public decimal Value;

        public override string ToString() { return Value.ToString(); }
    }
}