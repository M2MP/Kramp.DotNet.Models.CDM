using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Percent
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Percent() { }

        /// <summary>
        /// Construct a new Percent with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Percent(decimal value) { Value = value; }

        [XmlAttribute(AttributeName = "format")]
        public string Format;

        [XmlText()]
        public decimal Value;

        public override string ToString() { return Value.ToString(); }
    }
}