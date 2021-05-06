using System.Collections.Generic;

class ShowPowerRange 
    {
      public static IEnumerable<int> PowerRanger(int degree, int start, int finish)
        {
            int result;
            int count = 0;
            if (degree == 0) yield return 1;
            else if(start < 0 || finish < 0 || start > finish) yield return 0;
            else while (count <= finish)
            {   
                result = (int)Math.Pow(count, degree);
                if(result <= finish && result >= start) yield return result;
                count++;
            }
            
        }
    }
