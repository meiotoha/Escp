using System;
using System.Collections.Generic;
using System.Text;

namespace Escp.Core.Core
{
    public enum ScaleMode : byte
    {
        Normal         = 0x00,
        Width          = 0x01,
        Height         = 0x10,
        WidthAndHeight = 0x11
    }
}
