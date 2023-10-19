using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Identifier
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Identifier() { }
        
        /// <summary>
        /// Construct a new Identifier with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Identifier(string value) { Value = value; }

        [XmlAttribute(AttributeName = "schemeID")]
        public string SchemeID;

        [XmlAttribute(AttributeName = "schemeName")]
        public string SchemeName;

        [XmlAttribute(AttributeName = "schemeAgencyID")]
        public string SchemeAgencyID;

        [XmlAttribute(AttributeName = "schemeAgencyName")]
        public string SchemeAgencyName;

        [XmlAttribute(AttributeName = "schemeAgencyVersionID")]
        public string SchemeAgencyVersionID;

        [XmlAttribute(AttributeName = "schemeDataURI")]
        public string schemeDataURI;

        [XmlAttribute(AttributeName = "schemeURI")]
        public string schemeURI;

        [XmlText()]
        public string Value;

        public override string ToString() { return Value; }
    }
}