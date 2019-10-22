using System;
using System.Dynamic;
using System.Linq;
using System.Xml.Serialization;
using Escp.Core;
using Escp.Core.Core;

namespace Escp.Extend.Core
{
    public class TextEntry : EntryBase
    {

        [XmlAttribute]
        public bool? IsBold { get; set; }

        [XmlAttribute]
        public bool? IsUnderlined { get; set; }

        [XmlAttribute]
        public ScaleMode? ScaleMode { get; set; }

        [XmlAttribute]
        public Alignment? Position { get; set; }

        [XmlAttribute]
        public FontSize? Size { get; set; }

        [XmlAttribute]
        public string Value { get; set; }

        [XmlElement]

        public TextEntryElement[] Content { get; set; }


        public override void Print(IEscPosCore printer, CoreParameter parameter)
        {
            if (Content != null && Content.Length > 0)
            {
                foreach (var element in Content)
                {
                    element.Print(printer, parameter.Parameters);
                }
            }

            else if (string.IsNullOrEmpty(Value))
            {
                var str = Value.ParseText(parameter.Parameters);
                if (str != null)
                {
                    printer
                        .PrintText(str);
                }


            }
        }
    }
}