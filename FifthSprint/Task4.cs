using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace FirstSpring
{
    class Task1
    {
        public static bool ListDictionaryCompare(List<string> letters, Dictionary<string, string> dict)
        {
            if (letters.Count == 0 && dict.Count == 0) return true;
            var arr = dict.Values;
            foreach (var a in arr)
            {
                if (!letters.Contains(a)) return false;
            }
            foreach (var b in letters)
            {
                if (!arr.Contains(b)) return false;
            }
            return true;
        }
    }
}
