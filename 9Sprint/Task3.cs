class CalcAsync
    {
        public static async Task<int> SeqAsync(int n)
        {
            int a = await Task.Run(() => Calc.Seq(n));
            return a;
        }
        public static async void PrintSeqElementsConsequentlyAsync(int quant)
        {
            for (int i = 1; i <= quant; i++)
            {
                Console.WriteLine($"Seq[{i}] = {await SeqAsync(i)}");
            }
        }
        public static async void PrintSeqElementsInParallelAsync(int quant)
        {
            Task<int>[] arr = GetSeqAsyncTasks(quant);
            for (int i = 1; i < arr.Length; i++)
            {
                Console.WriteLine($"Seq[{i}] = {await arr[i]}");
            }
        }
        public static Task<int>[] GetSeqAsyncTasks(int n)
        {
            Task<int>[] arr = new Task<int>[n + 1];
            for (int i = 1; i <= n; i++)
            {
                arr[i] = SeqAsync(i);
            }
            return arr;
        }
    }
