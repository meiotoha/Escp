using System;
using System.Xml.Serialization;
using Escp.Extend.Core;

namespace Escp.Extend
{

    [Serializable]
    public class CoreTemplate
    {
        [XmlAttribute]
        public double Width { get; set; }

        [XmlElement]
        public EntryBase[] Enties { get; set; }
    }
}
