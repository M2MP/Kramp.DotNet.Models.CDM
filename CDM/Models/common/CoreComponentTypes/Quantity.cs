using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Quantity
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Quantity() { }

        /// <summary>
        /// Construct a new Quantity with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Quantity(decimal value) { Value = value; }

        [XmlAttribute(AttributeName = "unitCode")]
        public string UnitCode;

        [XmlAttribute(AttributeName = "unitCodeListID")]
        public string UnitCodeListID;

        [XmlAttribute(AttributeName = "unitCodeListAgencyID")]
        public string UnitCodeListAgencyID;

        [XmlAttribute(AttributeName = "unitCodeListAgencyName")]
        public string UnitCodeListAgencyName;

        [XmlText()]
        public decimal Value;

        public override string ToString() { return Value.ToString(); }
    }
}