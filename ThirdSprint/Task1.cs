using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSpring
{
    public delegate int CalcDelegate(int f, int s, char o);
    class CalcProgram
    {
        public static int Calc(int first, int second, char operation)
        {
            switch (operation)
            {
                case '+':
                    return first + second;
                case '-':
                    return first - second;
                case '*':
                    return first * second;
                case '/':
                    if (second == 0) return 0;
                    else return first / second;
            }
            return 0;
        }
        CalcDelegate funcCalc = Calc;
    }
}
