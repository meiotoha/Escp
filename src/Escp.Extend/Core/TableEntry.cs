using System.Xml.Serialization;
using Escp.Core;

namespace Escp.Extend.Core
{
    public class TableEntry : EntryBase
    {
        [XmlElement] 
        public TableEntryColumn[] Columns { get; set; }

        [XmlAttribute] 
        public string Source { get; set; }

        public override void Print(IEscPosCore printer, CoreParameter parameter)
        {

          
        }
    }
}
