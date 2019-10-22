using System;
using Escp.Core;

namespace Escp.Extend
{
    public static class EscPosCoreManagerExtensions
    {



        public static void Print(this IEscPosCoreManager manager, CoreTemplate template, CoreParameter parameter)
        {
            var core = manager.Begin();
            foreach (var entry in template.Enties)
            {
                entry.Print(core, parameter);
            }
        }
    }
}
