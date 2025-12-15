using Semaphor.Homework;
using Semaphor.ShopHomework;

namespace Semaphor;

class Program
{
    static void Main(string[] args)
    {
        // Theater theater = new Theater();
        // theater.StartAct();
        
        /*
        var ivanov = new Teacher("Ivanov");
        var petrov = new Teacher("Petrov");
        var sidorov = new Teacher("Sidorov");
        
        var math = new Subject("Math", ivanov);
        var physics = new Subject("Physics", petrov);
        var programming = new Subject("Programming", sidorov);

        var students = Enumerable.Range(1, 10)
            .Select(id => new Student(id))
            .ToList();

        Console.WriteLine("Exams started...\n");

        Parallel.ForEach(students, student =>
        {
            student.PassExam(math);
            student.PassExam(physics);
            student.PassExam(programming);
        });

        Console.WriteLine("\nExams finished.\n");
        */

        Cashier cashier = new Cashier("Галина");
        Cashier cashier1 = new Cashier("Алена");
        
        Product potatoes = new Product("potatoes", cashier);
        Product pineapples = new Product("pineapples", cashier1);
        Product berries = new Product("berries", cashier1);

        List<Buyer> buyers = Enumerable.Range(1, 5)
            .Select(id => new Buyer(id))
            .ToList();

        Parallel.ForEach(buyers, buyer =>
        {
            var products = new[] { pineapples, potatoes, berries };
            foreach (var product in products)
            {
                buyer.Buying(product);
            }
        });

    }
}