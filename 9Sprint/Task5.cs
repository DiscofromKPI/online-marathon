class CalcAsync
    {
        
        public static async void PrintSpecificSeqElementsAsync(int[] n)
        {            
            List<Exception> list = new List<Exception>();
            if (n.Length == 2) Array.Sort(n);
            for (int i = 0; i < n.Length; i++)
            {
                try
                {
                    Console.WriteLine($"Seq[{n[i]}] = {await Task.Run(() => Calc.Seq(n[i]))}");
                }
                catch (ArgumentException e)
                {
                    list.Add(e);
                }
            }           
            foreach (var ex in list)
            {
                Console.WriteLine("Inner exception: " + ex.Message);
            }
        }
    }
