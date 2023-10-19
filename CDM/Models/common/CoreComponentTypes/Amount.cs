using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    public class Amount
    {
        /// <summary>
        /// Default constructor, necessary for XML serialization to work
        /// </summary>
        public Amount() { }

        /// <summary>
        /// Construct a new Indicator with a predefined value AND currency (rendered as XmlText)
        /// </summary>
        /// <param name="value"></param>
        public Amount(decimal value, string currencyID) { Value = value; CurrencyID = currencyID; }

        [XmlAttribute(AttributeName = "currencyID")]
        public string CurrencyID;

        [XmlText()]
        public decimal Value;

        public override string ToString() { return Value.ToString(); }
    }
}