using System;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Kramp.DotNet.Models.CDM
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field | AttributeTargets.Property)]
    public class CommonAggregateComponentAttribute : XmlElementAttribute
    {
        public CommonAggregateComponentAttribute() 
        {
            Namespace = Constants.CommonAggregateComponentsNamespace;
            Form = XmlSchemaForm.Qualified;
        }
    }
}