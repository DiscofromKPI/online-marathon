using System.Collections.Generic;

class ShowPower
{
     public static IEnumerable<float> SuperPower(float num, float degree)
        {
           float result = 1;
           if (num == 0) yield return 0;
            else if(degree > 0)
            {
                for(int i = 1; i <= degree; ++i)
                {
                    result *= num;
                    yield return result;
                }
            }
            else if(degree < 0)
            {
                for(int i = -1; i>= degree; --i)
                {
                    result /= num;
                    yield return result;
                }
            }
            else yield return 1;
        }

}
