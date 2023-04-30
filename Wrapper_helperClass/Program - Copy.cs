using System;
using System.Linq;
using System.Text;

public static class Class1
{

    public static string GenerateLowerCase(this string k)
    {
        if (k.Length > 0)
        {
            char[] vs = k.ToCharArray();
            vs[0] = char.IsLower(vs[0]) ? char.ToUpper(vs[0]) : vs[0]; 
            return new string(vs);
        }
        return "Pls enter the string.";
    }

}
