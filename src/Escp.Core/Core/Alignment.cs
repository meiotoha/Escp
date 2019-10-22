using System;
using System.Collections.Generic;
using System.Text;

namespace Escp.Core.Core
{
    public enum Alignment : byte
    {
        Left        = 0x00,
        Center      = 0x01,
        Right       = 0x02,
        LeftAlter   = 0x48,
        CenterAlter = 0x49,
        RightAlter  = 0x50
    }
}
