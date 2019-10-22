
using Escp.Core;
using Escp.Core.Core;

namespace Escp.Extend.Core
{
    public interface ITextElement
    {
        bool? IsBold { get; set; }
        bool? IsUnderlined { get; set; }
        ScaleMode? ScaleMode { get; set; }
        Alignment? Position { get; set; }
        FontSize? Size { get; set; }
        string Value { get; set; }

        void Print(IEscPosCore printer, params object[] contexts)
        {

        }

        
    }
}
