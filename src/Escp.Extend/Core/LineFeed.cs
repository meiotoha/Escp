using System;
using System.Collections.Generic;
using System.Text;
using Escp.Core;

namespace Escp.Extend.Core
{
    public class LineFeed : EntryBase
    {
        public override void Print(IEscPosCore printer, CoreParameter parameter)
        {
            printer.LineFeed(1);
        }
    }
}
