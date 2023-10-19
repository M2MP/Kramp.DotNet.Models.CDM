using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Name
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Name() { }

        /// <summary>
        /// Construct a new Name with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Name(string value) { Value = value; }

        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID;

        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID;

        [XmlText()]
        public string Value;

        public override string ToString() { return Value; }
    }
}