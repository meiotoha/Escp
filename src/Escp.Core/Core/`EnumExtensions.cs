using System;
using System.Collections.Generic;
using System.Text;

namespace Escp.Core.Core
{
    public static class EnumExtensions
    {
        public static byte ToByte(this Alignment value) => (byte)value;
        public static byte ToByte(this AsciiFontMode value) => (byte)value;
        public static byte ToByte(this FontSize value) => (byte)value;
        public static byte ToByte(this ScaleMode value) => (byte)value;

    }
}
