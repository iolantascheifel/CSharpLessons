using Collection.homework;

namespace Collection;

class Program
{
    static void Main(string[] args)
    {
        // List<Book> books = new List<Book>()
        // {
        //     new Book()
        //     {
        //         Name = "Atomic Habits", 
        //         Author = "Author Welslkds", 
        //         PageCount = -1
        //     },
        //     new Book()
        //     {
        //         Name = "100 essays", 
        //         Author = "Author Second", 
        //         PageCount = 230
        //     }
        // };
        //
        // books.Sort(new BookComparer());
        //
        //
        // // контрвариантность 
        // IValidator<Text> textValidator = new TextValidator();
        // IValidator<Book> bookValidator = textValidator;
        //
        //
        // foreach (var book in books)
        // {
        //     bool isValid = bookValidator.IsValid(book);
        //     Console.WriteLine($"{book},  isValid: {isValid}");
        // }
        //
        //
        //
        // Library library = new Library(books);
        //
        // Librarian librarian = new Librarian(library);
        //
        // while (librarian.Next())
        // {
        //     Book book = librarian.Current;
        //     Console.WriteLine(book.Name);
        // }
        //
        // foreach (var book in books)
        // {
        //     Console.WriteLine(book.Name);
        // }
        //
        // IEnumerator<Book> enumerator = books.GetEnumerator();
        //
        // while (enumerator.MoveNext())
        // {
        //     Book book = enumerator.Current;
        //     Console.WriteLine(book.Name);
        // }
        //
        // MyStack<int> myStack = new MyStack<int>();
        //
        // myStack.Push(1);
        // myStack.Push(2);
        // myStack.Push(3);
        //
        // foreach (var item in myStack)
        // {
        //     Console.WriteLine(item);
        // }
        //
        // IEnumerator<int> stack = myStack.GetEnumerator();
        // while (stack.MoveNext())
        // {
        //     int item = stack.Current;
        //     Console.WriteLine(item);
        // }
        //
        // MyQueue<Book> myQueue = new MyQueue<Book>();
        // myQueue.Enqueue(new Book() { Name = "Book 1", Author = "Author A" });
        // myQueue.Enqueue(new Book() { Name = "Book 2", Author = "Author B" });
        // myQueue.Enqueue(new Book() { Name = "Book 3", Author = "Author C" });
        //
        // Console.WriteLine("\nQueue (FIFO):");
        // foreach (var book in myQueue)
        // {
        //     Console.WriteLine($"{book.Name} by {book.Author}");
        // }
        //
        // Console.WriteLine("\nDequeuing from queue:");
        // Console.WriteLine(myQueue.Dequeue()?.Name);
        // Console.WriteLine(myQueue.Dequeue()?.Name);
        // Console.WriteLine(myQueue.Dequeue()?.Name);
        //
        // var employers = GenerateEmployees(1_000_000);
        // var countOfItiration = 0;
        // foreach (var employee in employers)
        // {
        //     if (employee.Department == 15)
        //     {
        //         Console.WriteLine(employee.Name);
        //         Console.WriteLine(countOfItiration);
        //         break;
        //     }
        //     countOfItiration++;
        // }
        //
        // int[] array = [1, 3, 4, 5, 3, 14, 53];
        // var evenNumbersCollection = GetAllEvenNumbers(array);
        // foreach (var num in evenNumbersCollection)
        // {
        //     Console.WriteLine(num);
        // }
        
        // Workshop workshop = new Workshop();
        // workshop.Add(new Instrument()
        // {
        //     Name = "A", 
        //     Resource = 80
        // });
        // workshop.Add(new Instrument()
        // {
        //     Name = "B", 
        //     Resource = 90
        // });
        // workshop.Add(new Instrument()
        // {
        //     Name = "C", 
        //     Resource = 40
        // });
        // workshop.Add(new Instrument()
        // {
        //     Name = "D", 
        //     Resource = 50
        // });
        //
        //
        // IEnumerator<Instrument> master = workshop.GetEnumerator();
        // int countIsNotBroken = 0;
        // while (master.MoveNext())
        // {
        //     var instrument = master.Current;
        //     Console.WriteLine(instrument.Name);
        //     countIsNotBroken++;
        // }
        // master.Reset();
        // Console.WriteLine(countIsNotBroken);
        //
        //
        // countIsNotBroken = 0;
        // foreach (var instrument in workshop)
        // {
        //     Console.WriteLine(instrument.Name);
        //     countIsNotBroken++;
        // }
        // Console.WriteLine(countIsNotBroken);
        
        EuUnion eu = new EuUnion();

        eu.Add(new Country("Германия", true));
        eu.Add(new Country("Франция", true));
        eu.Add(new Country("Швейцария", false));
        eu.Add(new Country("Польша", true));
        eu.Add(new Country("Норвегия", false));

        Console.WriteLine("Страны ЕС:");

        foreach (Country country in eu)
        {
            Console.WriteLine(country);
        }
        
    }

    public static IEnumerable<Employee> GenerateEmployees(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Employee employee = new Employee();
            employee.Name = Guid.NewGuid().ToString();
            employee.Department = new Random().Next(1, 100);
            yield return employee;
        }
    }

    public static IEnumerable<int> GetAllEvenNumbers(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                yield return numbers[i];
            }
        }
    }
        
    
}