namespace Collection;

class Program
{
    static void Main(string[] args)
    {
        List<Book> books = new List<Book>()
        {
            new Book()
            {
                Name = "Name", Author = "Author"
            },
            new Book()
            {
                Name = "Name 2", Author = "Author 2"
            }
        };
        
        Library library = new Library(books);
       
        Librarian librarian = new Librarian(library);

        while (librarian.Next())
        {
            Book book = librarian.Current;
            Console.WriteLine(book.Name);
        }

        foreach (var book in books)
        {
            Console.WriteLine(book.Name);
        }
        
        IEnumerator<Book> enumerator = books.GetEnumerator();

        while (enumerator.MoveNext())
        {
            Book book = enumerator.Current;
            Console.WriteLine(book.Name);
        }
        
        MyStack<int> myStack = new MyStack<int>();
        
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(3);

        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }

        IEnumerator<int> stack = myStack.GetEnumerator();
        while (stack.MoveNext())
        {
            int item = stack.Current;
            Console.WriteLine(item);
        }
        
        MyQueue<Book> myQueue = new MyQueue<Book>();
        myQueue.Enqueue(new Book() { Name = "Book 1", Author = "Author A" });
        myQueue.Enqueue(new Book() { Name = "Book 2", Author = "Author B" });
        myQueue.Enqueue(new Book() { Name = "Book 3", Author = "Author C" });

        Console.WriteLine("\nQueue (FIFO):");
        foreach (var book in myQueue)
        {
            Console.WriteLine($"{book.Name} by {book.Author}");
        }

        Console.WriteLine("\nDequeuing from queue:");
        Console.WriteLine(myQueue.Dequeue()?.Name);
        Console.WriteLine(myQueue.Dequeue()?.Name);
        Console.WriteLine(myQueue.Dequeue()?.Name);

        var employers = GenerateEmployees(1_000_000);
        var countOfItiration = 0;
        foreach (var employee in employers)
        {
            if (employee.Department == 15)
            {
                Console.WriteLine(employee.Name);
                Console.WriteLine(countOfItiration);
                break;
            }
            countOfItiration++;
        }

        int[] array = [1, 3, 4, 5, 3, 14, 53];
        var evenNumbersCollection = GetAllEvenNumbers(array);
        foreach (var num in evenNumbersCollection)
        {
            Console.WriteLine(num);
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
        
    
    // написать коллекцию которая будет хранить массив обход элементов должен быть прыжками 1 > 3 > 2 > 4 > 3 > 5
        
        
    // List add remove count обычный массив 
}