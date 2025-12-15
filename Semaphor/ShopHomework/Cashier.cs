using System.Collections.Concurrent;

namespace Semaphor.ShopHomework;

public class Cashier
{
    public string Name { get; }
    
    private readonly SemaphoreSlim _semaphoreSlim = new SemaphoreSlim(1, 1);
    private readonly ConcurrentQueue<Buyer> _queue = new ConcurrentQueue<Buyer>();

    public Cashier(string name)
    {
        Name = name;
    }
    public void EnterQueue(Buyer buyer, Product product)
    {
        // 1️⃣ Покупатель встаёт в очередь
        _queue.Enqueue(buyer);

        // 2️⃣ Выводим текущую очередь в консоль
        lock (Console.Out) // чтобы строки не перемешивались
        {
            Console.Write($"Cashier {Name} queue: ");
            foreach (var b in _queue)
            {
                Console.Write($"Buyer {b.Id} ");
            }
            Console.WriteLine();
        }

        // 3️⃣ Ждём своей очереди у кассира
        _semaphoreSlim.Wait();
        try
        {
            // Берём следующего покупателя из очереди
            if (_queue.TryDequeue(out Buyer currentBuyer))
            {
                Console.WriteLine($"Cashier {Name} serving Buyer {currentBuyer.Id} for {product.Name}");
                Thread.Sleep(2000); // имитация обслуживания
            }
        }
        finally
        {
            _semaphoreSlim.Release();
        }
    }

    /*
    public void CashierServing(Product product, Buyer buyer)
    {
        _semaphoreSlim.Wait();

        try
        {
            Console.WriteLine($"Cashier {Name} serving buyer{buyer.Id} who is buying {product.Name}.");
            Thread.Sleep(2000);
        }
        finally
        {
            _semaphoreSlim.Release();
        }
    }
    */
}