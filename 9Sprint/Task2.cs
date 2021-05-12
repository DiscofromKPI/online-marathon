static class CalcAsync
    {
        public static async Task TaskPrintSeqAsync(int n)
        {
            Console.WriteLine($"Seq[{n}] = {await Task.Run(() => Calc.Seq(n))}");

        }
        public static void PrintStatusIfChanged(this Task task, ref TaskStatus status)
        {
            task.ContinueWith(ran => Console.WriteLine("RanToCompletion"));
            if (status == TaskStatus.RanToCompletion)
            {
                Console.WriteLine(task.Status);
                status = task.Status;
            }
        }
        public static void TrackStatus(this Task task)
        {
            if (task.Status == TaskStatus.WaitingForActivation)
            {
                Console.WriteLine(task.Status);
            }
            task.Wait();
            TaskStatus prev = task.Status;
            task.PrintStatusIfChanged(ref prev);
        }
    }
