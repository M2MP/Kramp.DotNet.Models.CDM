using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Time
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Time() { }

        /// <summary>
        /// Construct a new Date with a predefined value (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Time(string value) { Value = value; }

        [XmlText()]
        public string Value;

        public override string ToString() { return Value; }
    }
}