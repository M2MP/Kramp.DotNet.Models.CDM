using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    [AttributeUsage(AttributeTargets.Class)]
    public class MainDocAttribute : XmlRootAttribute
    {
        public MainDocAttribute(string xmlNamespace) : base()
        {
            Namespace = xmlNamespace;
        }
    }
}