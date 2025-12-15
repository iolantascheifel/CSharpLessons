namespace Threads;

class Program
{
    static void Main(string[] args)
    {
        /* Gardener 
        char[,] garden = new char[10, 10];

        Thread gadnererA = new Thread(() => GardenerAMoving(garden));
        Thread gardenerB = new Thread(() => GardenerBMoving(garden));

        gadnererA.Start();
        gardenerB.Start();

        gadnererA.Join();
        gardenerB.Join();
        
        ThreadPool.QueueUserWorkItem((_) => GardenerAMoving(garden));
        ThreadPool.QueueUserWorkItem((_) => GardenerBMoving(garden));
        Console.ReadKey();
        
        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Console.Write(garden[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        */
        
        List<Vector> vectors = new List<Vector>();
        Random randomizer = new Random();
        for (int i = 0; i < 300_000; i++)
        {
            vectors.Add(new Vector()
            {
                X = randomizer.Next(-100, 100),
                Y = randomizer.Next(-100, 100),
                Z = randomizer.Next(-100, 100)
            });
        }
        
        int k = randomizer.Next(100, 10000);

        int countOfThreads = 5;
        for (int numberOfThreads = 1; numberOfThreads <= countOfThreads; numberOfThreads++)
        {
            int numberOfThreadsCopy = numberOfThreads;
            ThreadPool.QueueUserWorkItem((_) => CircleVectorProcess(vectors, k, numberOfThreadsCopy, countOfThreads));
        }

        Console.ReadKey();
        foreach (var vector in vectors)
        {
            Console.WriteLine(vector);
        }
    }

    //partial process - for next time
    public static void CircleVectorProcess(List<Vector> vectors, int k, int numberOfThread, int countOfThread)
    {
        for (int i = numberOfThread - 1; i < vectors.Count; i += countOfThread)
        {
            vectors[i].X *= k;
            vectors[i].Y *= k;
            vectors[i].Z *= k;
        }
        
        Console.WriteLine($"Number of threads: {numberOfThread} is complete");
    }

    public static void GardenerAMoving(char[,] garden)
    {
        bool isRight = true;
        var rows = garden.GetLength(0);
        var columns = garden.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            if (isRight)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (garden[i, j] != 'b')
                    {
                        garden[i, j] = 'a';
                        Thread.Sleep(100);
                    }
                    else
                    {
                        columns = j;
                        break;
                    }
                }
            }
            else
            {
                for (int j = columns - 1; j >= 0; j--)
                {
                    if(garden[i, j] != 'b')
                    {
                        garden[i, j] = 'a';
                        Thread.Sleep(100);
                    }
                    else
                    {
                        columns--;
                        continue;
                    }
                }
            }
            isRight = !isRight;
        }
        Console.WriteLine("a is done");
    }
    
    public static void GardenerBMoving(char[,] garden)
    {
        bool up = true;
        var rows = garden.GetLength(0);
        var columns = garden.GetLength(1);
        for (int i = columns - 1; i >=0 ; i--)
        {
            if (up)
            {
                for (int j = rows - 1; j >= 0; j--)
                {
                    if (garden[j, i] == 'a')
                    {
                        break;
                    }

                    garden[j, i] = 'b';
                    Thread.Sleep(100);
                }
            }
            else
            {
                for (int j = 0; j < rows; j++)
                {
                    if (garden[j, i] == 'a')
                    {
                        continue;
                    }
                    

                    garden[j, i] = 'b';
                    Thread.Sleep(100);
                }
            }
            up = !up;
        }
        Console.WriteLine("b is done");
    }
}