using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Code
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Code() { }

        /// <summary>
        /// Construct a new Code with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Code(string value) { Value = value; }

        [XmlAttribute(AttributeName = "listID")]
        public string ListID;

        [XmlAttribute(AttributeName = "listAgencyID")]
        public string ListAgencyID;

        [XmlAttribute(AttributeName = "listAgencyName")]
        public string ListAgencyName;

        [XmlAttribute(AttributeName = "listName")]
        public string ListName;

        [XmlAttribute(AttributeName = "listVersionID")]
        public string ListVersionID;

        [XmlAttribute(AttributeName = "name")]
        public string Name;

        [XmlAttribute(AttributeName = "languageID")]
        public string LanguageID;

        [XmlAttribute(AttributeName = "listURI")]
        public string ListURI;

        [XmlAttribute(AttributeName = "listSchemeURI")]
        public string ListSchemeURI;

        [XmlText()]
        public string Value;

        public override string ToString() { return Value; }
    }
}