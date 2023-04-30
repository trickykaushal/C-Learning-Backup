using System;
using System.Collections.Generic;
using System.Text;

namespace linq
{
    static class helper
    {
        public static string GenerateLowerCase(this string k)
        {
            char[] vs = k.ToCharArray();
            vs[0] = char.IsUpper(vs[0]) ? vs[0] : char.ToLower(vs[0]);
            return new string(vs);
        }
    }
}
