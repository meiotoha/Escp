using Escp.Core;

namespace Escp.Extend.Core
{
    public interface IPrintableEntry
    {
        void Print(IEscPosCore printer, CoreParameter parameter);
    }
}
