class CalcAsync
    {
        public static async void PrintSeqAsync(int n)
        {
            int a = await Task.Run(() => Calc.Seq(n));
            Console.WriteLine($"Seq[{n}] = {a}");
        }

    }
