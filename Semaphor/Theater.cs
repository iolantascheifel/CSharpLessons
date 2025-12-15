using Timer = System.Timers.Timer;

namespace Semaphor;

public class Theater
{
    private List<int> viewers = Enumerable.Range(1, 300).ToList();

    private const int timeToAct = 20;

    private void ShowAct(int iteration)
    {
        var delay = Task.Delay(1000);
        delay.Wait();
        Console.WriteLine($"прошла {iteration} секунда спектакля");
    }

    public void StartAct()
    {
        SemaphoreSlim wc = new SemaphoreSlim(5, 5);
        
        // спектакль 
        Task task = Task.Run(() =>
        {
            for (int i = 0; i < timeToAct; i++)
            {
                ShowAct(i + 1);
            }
            Console.WriteLine("представление окончено");
        });
        
        // 
        Parallel.ForEach(viewers, viewer =>
        {
            int timeToGoToWC = new Random().Next(1, 20);
            Timer timer = new Timer(timeToGoToWC * 1000);
            timer.AutoReset = false; // не запускать таймер после того как он отработает
            timer.Elapsed += (_, _) =>
            {
                if (wc.CurrentCount == 0)
                {
                    Console.WriteLine("Все кабинки заняты, ожидайте");
                }
                wc.Wait();
                Console.WriteLine($"гость с номером {viewer} занял свободную кабинку");
                var delay = Task.Delay(new Random().Next(1, 3) * 1000);
                delay.Wait();
                Console.WriteLine($"гость {viewer} освободил кабинку");
                wc.Release();
            };
            timer.Start();
        });
        
       task.Wait();
    }
}