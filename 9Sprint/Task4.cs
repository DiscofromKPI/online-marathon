class CalcAsync
    {
        public static async IAsyncEnumerable<(int, int)> SeqStreamAsync(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                yield return (i, await Task.Run(() => Calc.Seq(i)));
            }
        }
        public static async void PrintStream(IAsyncEnumerable<(int, int)> a)
        {
            await foreach (var item in a)
            {
                Console.WriteLine($"Seq[{item.Item1}] = {item.Item2}");
            }
        }
    }
