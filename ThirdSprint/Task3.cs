using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    class ListProgram
    {
        public static List<int> ListWithPositive(List<int> a) => a.FindAll(a => a > 0);
        

    }
}
