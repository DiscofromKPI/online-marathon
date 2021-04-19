using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    public static class IListExtensions
    {
        public static List<int> IncreaseWith(this List<int> a, int value)
        {
            for (int i = 0; i < a.Count; i++)
            {
                a[i] += value;
            }
            return a;
        }
    }
    public static class IEnumerableExtensions
    {
        public static string ToString<T>(this List<int> a)
        {
            return '[' + string.Join(", ", a.ToArray()) + ']';
        }
    }
}
