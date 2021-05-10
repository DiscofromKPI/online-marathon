using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace FirstSpring
{
    class ParallelUtils<T, TR>
    {
        public TR Result { get; set; }
        Func<T, T, TR> Func { get; set; }
        T First;
        T Second;
        public ParallelUtils(Func<T, T, TR> func, T first, T second)
        {
            Func = func;
            First = first;
            Second = second;
        }
        public void StartEvaluation()
        {
            Thread thread = new Thread(new ThreadStart(() => Result = Func(First, Second)));
            thread.Start();
        }
        public void Evaluate()
        {
            Thread thread = new Thread(new ThreadStart(() => Result = Func(First, Second)));
            thread.Start();
            thread.Join();
        }
    }
}
