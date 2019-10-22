using System.Collections.Generic;
using System.Xml.Serialization;
using Escp.Core;
using Escp.Core.Core;

namespace Escp.Extend.Core
{
    public class TextEntryElement
    {

        [XmlAttribute]
        public bool IsBold { get; set; }

        [XmlAttribute]
        public bool IsUnderlined { get; set; }

        [XmlAttribute]
        public ScaleMode ScaleMode { get; set; }

        [XmlAttribute]
        public Alignment Position { get; set; }

        [XmlAttribute]
        public int Size { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        public void Print(IEscPosCore printer, object global = null)
        {
            var str = Value.ParseText(global);

        }
    }
}
