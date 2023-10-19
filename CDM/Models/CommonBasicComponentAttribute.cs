using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
    public class CommonBasicComponentAttribute : XmlElementAttribute
    {
        public CommonBasicComponentAttribute() 
        {
            Namespace = Constants.CommonBasicComponentsNamespace;
            Form = XmlSchemaForm.Qualified;
        }
    }
}