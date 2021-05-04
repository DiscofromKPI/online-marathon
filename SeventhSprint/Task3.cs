using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class Task3
    {
        public static int ProductWithCondition(List<int> list, Func<int, bool> second) =>
                list.Where(second).Aggregate(1, (x, y) => x * y);
        

    }
}
