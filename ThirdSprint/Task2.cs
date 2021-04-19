using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace FirstSpring
{
    public static class StringExtensions
    {
        public static int WordCount(this string s)
        {
            char[] separators = { ' ', ',', '.', ';', ':', '!', '?', '"', ')', '(', '/', '-' };
            return s.Split(separators, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}
