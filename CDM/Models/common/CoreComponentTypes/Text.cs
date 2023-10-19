using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Text
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Text() { }

        /// <summary>
        /// Construct a new Text with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Text(string value) { Value = value; }

        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID;

        [XmlAttribute(AttributeName = "languageLocaleID")]
        public string LanguageLocaleID;

        [XmlText()]
        public string Value;

        public override string ToString() { return Value; }
    }
}