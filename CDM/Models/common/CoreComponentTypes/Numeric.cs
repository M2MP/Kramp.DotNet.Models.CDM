using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Numeric
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Numeric() { }

        /// <summary>
        /// Construct a new Numeric with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Numeric(decimal value) { Value = value; }

        [XmlAttribute(AttributeName = "format")]
        public string Format;

        [XmlText()]
        public decimal Value;

        public override string ToString() { return Value.ToString(); }
    }
}