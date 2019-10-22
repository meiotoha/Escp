using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Escp.Extend.Core
{
    public static class TemplateStringHelper
    {

        public static string ParseText(this string template, params object[] context)
        {
            var sb = new StringBuilder(template);
            var keys = Regex.Matches(template,@"\{\w+\}");
            foreach (Match match in keys)
            {
                sb.Replace(match.Value, context.TryGetFirstOrDefaultValue(match.Value)?.ToString() ?? string.Empty);
            }
            return sb.ToString();
        }

        private static object TryGetFirstOrDefaultValue(this object[] context, string name)
        {
            if (context == null)
            {
                return default;
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                return default;
            }

            var propertyName = name.Replace('{', ' ').Replace('}', ' ').Trim();
            var ctx = context.Reverse();
            foreach (var obj in ctx)
            {
                var value = obj.TryGetValue(propertyName);
                if (value != null)
                {
                    return value;
                }
            }
            return default;
        }
        private static object TryGetValue(this object obj, string name)
        {
            var type = obj.GetType();
            var property =  type.GetProperty(name);
            return property != null ? property.GetValue(obj) : default;
        }

    }
}
