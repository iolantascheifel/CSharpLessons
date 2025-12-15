namespace Tasks;

class Program
{
    static void Main(string[] args)
    {
        /*
        // implement using Tasks
        int count = 0;
        int n = 100;
        
        Parallel.For(1, n, i =>
        {
            if (IsPrimaryNumber(i))
            {
                // потоки обращаются к одному ресурсу
                // count++;
                Interlocked.Increment(ref count);
            }
        });
        Console.WriteLine(count);
        */
        
        int n = 1000;
        int taskCount = Environment.ProcessorCount; // мксимальное кол-во процессоров
        int chunkSize = n / taskCount;

        List<Task> tasks = new List<Task>();
        List<int> listOfNumbers = new List<int>();
        object locker = new object();

        for (int t = 0; t < taskCount; t++)
        {
            //partition
            int start = t * chunkSize + 1;
            int end = (t == taskCount - 1) ? n : start + chunkSize - 1;

            tasks.Add(Task.Run(() =>
            {
                for (int i = start; i <= end; i++)
                {
                    if (IsPrimaryNumber(i))
                    {
                        lock (locker)
                        {
                            listOfNumbers.Add(i);
                        }
                    }
                }
            }));
        }

        Task.WaitAll(tasks.ToArray());
        
        Console.WriteLine(listOfNumbers.Count);
    }
    //посчитать количество простых чисел с 1 до n

    public static bool IsPrimaryNumber(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }
    
}