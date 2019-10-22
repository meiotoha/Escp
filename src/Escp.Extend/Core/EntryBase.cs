using System;
using Escp.Core;

namespace Escp.Extend.Core
{
    [Serializable]
    public abstract class EntryBase : IPrintableEntry
    {
        public abstract void Print(IEscPosCore printer, CoreParameter parameter);
    }
}