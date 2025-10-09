namespace Procedural;

class Program
{
    
    class Box
    // box is a class therefore it's reference type
    {
        public int Value;
    }
    
    class Container
    {
        public int[] Data = { 1, 2, 3 };
    }
    
    static void Main(string[] args)
    {
        var box = new Box { Value = 5 };
        Change(box);
        Console.WriteLine(box.Value); // will be 20
        
        
        //// 
        string str = "Hello";
        ChangeString(str);
        Console.WriteLine(str);
        
        
        ////
        var obj = new Container();
        ChangeContainer(obj);
        Console.WriteLine(obj.Data[0]);
        
        
        ////
        string[] words = ["Hello", "C#"];
        ChangeWords(words);
        Console.WriteLine(words[0]);
        
        ////
        string text = "I am learning CSharp now";
        string[] wordsArray = text.Split(' ');
        List<string> wordsList = new List<string>(wordsArray);

        foreach (var word in wordsArray)
        {
            if (word.Length < 3)
            {
                wordsList.Remove(word);
            }
        }
        Console.WriteLine(string.Join(" ", wordsList));
        
        ////
        string exampleString = "this is a bad example of bad code";
        string[] prohibitedWords = { "bad", "code" };

        for (int i = 0; i < prohibitedWords.Length; i++)
        {
            exampleString = exampleString.Replace(prohibitedWords[i], "***");
        }
        Console.WriteLine(exampleString);   
        
        
        // Вход: "C# 2025!"
        // Выход: буквы=1, цифры=4, пробелы=1, другие=1
        
        int letters = 0;
        int digits = 0;
        int symbols = 0;

        string input = "C# 2025!";
        int spaces = input.Count(c => c == ' ');

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                letters++;
            }
            else if (char.IsDigit(c))
            {
                digits++;
            }
            else
            {
                symbols++;
            }
        }
        Console.WriteLine($"Букв: {letters}, Цифр: {digits}, Знаков: {symbols}, пробелов: {spaces}");
        
        
        ////
        string input2 = "cat apple hi";
        string[] splittedInput2 = input2.Split(' ');
        string maxWord = "";
        int maxPrice = 0;

        foreach (var word in splittedInput2)
        {
            int price = 0;
            foreach (char c in word)
            {
                price += (int)c;
            }
            if (price > maxPrice)
            {
                maxPrice = price;
                maxWord = word;
            }
        }
        Console.WriteLine($"{maxWord} ({maxPrice})");

    }
    static void Change(Box b)
    {
        b.Value = 20;
    }
    
    static void ChangeString(string s)
    {
        s += " World";
    }
    
    static void ChangeContainer(Container c)
    {
        c.Data[0] = 100;
        c = new Container();
        c.Data[0] = 200;
    }
    
    static void ChangeWords(string[] arr)
    {
        arr[0] = arr[0] + " World";
    }
}


