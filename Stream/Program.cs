using System.Text.Json;
using System.Text.RegularExpressions;

namespace Stream;

class Program
{
    static void Main(string[] args)
    {
        // FrequencyTextAnalyzer();
        // SwapWords();
        // DeserializeJson();
        
        string file = "Employees.dat";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Position = "Manager", Experience = 5, Salary = 50000 },
            new Employee { Position = "Developer", Experience = 3, Salary = 40000 },
            new Employee { Position = "Designer", Experience = 2, Salary = 35000 }
        };

        // Сохранить
        SaveEmployees(file, employees);

        // Загрузить
        List<Employee> restored = LoadEmployees(file);

        Console.WriteLine("Считанные данные:");
        foreach (var employee in restored)
        {
            Console.WriteLine($"{employee.Position}, {employee.Experience} лет, зарплата {employee.Salary}");
        }
    }

    public static void FrequencyTextAnalyzer()
    {
        Dictionary<string, int> storage = new Dictionary<string, int>();
        using StreamReader streamReader = new StreamReader("input.txt");
        string line;
        while ((line = streamReader.ReadLine()) != null)
        {
            var words = Regex.Split(line.ToLower(), @"\W+")
                .Where(word => !string.IsNullOrWhiteSpace(word));

            foreach (var word in words)
            {
                if (!storage.TryAdd(word, 1))
                {
                    storage[word]++;
                }
            }
        }
        var sorted = storage.OrderByDescending(w => w.Value);
        using StreamWriter writer = new StreamWriter("output.txt");
        foreach (var s in sorted)
        {
            writer.WriteLine($"{s.Key} -  {s.Value}");
        }
    }

    public static void SwapWords()  // 2 задача
    {
        using StreamReader reader = new StreamReader("input2.txt");
        using  StreamWriter writer = new StreamWriter("output2.txt");
        string line;
        while ((line = reader.ReadLine()) != null)
        {
            line = line.Replace("старое", "новое");
            writer.WriteLine(line);
        }
    }

    public static void DeserializeJson() //3 задача
    {
        string jsonText = File.ReadAllText("data.json");
        
        // (JsonDocument.Parse(jsonText))
        // {
        //     Console.WriteLine("JSON корректный.");
        // }
        Dictionary<string, object>? data =
            JsonSerializer.Deserialize<Dictionary<string, object>>(jsonText);
        
        Console.WriteLine($"Number of keys: {data?.Keys.Count}");
    }
    
    // 6 задача
    public static void SaveEmployees(string filePath, List<Employee> employees)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(employees.Count); 
            foreach (var employee in employees)
            {
                writer.Write(employee.Position);
                writer.Write(employee.Experience);
                writer.Write(employee.Salary);
            }
        }
    }
    
    public static List<Employee> LoadEmployees(string filePath)
    {
        List<Employee> employees = new List<Employee>();

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int count = reader.ReadInt32();

            for (int i = 0; i < count; i++)
            {
                Employee employee = new Employee
                {
                    Position = reader.ReadString(),
                    Experience = reader.ReadInt32(),
                    Salary = reader.ReadDouble()
                };

                employees.Add(employee);
            }
        }

        return employees;
    }

    
}