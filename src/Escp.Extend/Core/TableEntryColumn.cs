using System.Xml.Serialization;

namespace Escp.Extend.Core
{
    public class TableEntryColumn
    {

        [XmlAttribute]
        public string Header { get; set; }

        [XmlAttribute]
        public string Size { get; set; }

        [XmlAttribute]
        public string IsBold {get;set;}

        [XmlAttribute]
        public string IsUnderlined { get; set; }

        [XmlAttribute]
        public int Width { get; set; }  

        [XmlText] 
        public string Value { get; set; }

        [XmlElement] 
        public TextEntry Entry { get; set; }
    }

}
