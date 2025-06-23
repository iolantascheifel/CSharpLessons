namespace HelloWorld;

class Program
{
    static void Main(string[] args)
   {
        PrintNumber(34);
        PrintSeason(8);
        GreetAccordingToTime(15);
        СуществуетЛиТреугольник(4,6,8);
        
        // Console.WriteLine(ConvertToChar(65_536 + 124));

        try
        {
            PrintNumber(22.5);
        } 
        catch (FormatException ex) 
        {
            Console.WriteLine("Неверное число");
        }
        // catch (Exception ex) 
        // {
        //     Console.WriteLine(ex.Message);
        // }
        finally 
        {
            Console.WriteLine("end block");
        }
        

    }

    // ****************************
    // *   Convert seconds to minutes and hours *
    // ****************************

    static void ConvertSecondsToTime(int time) 
    {
        int seconds = time % 60;
        int totalMinutes = time / 60;
        int minutes = totalMinutes % 60;
        int hours = totalMinutes / 60;

        Console.WriteLine($"{seconds}, {minutes}, {hours}");
    }

    // ****************************
    // *   Methods to check if number is palindrome   *
    // ****************************

    static bool CheckThreeDigitPalindrome(int number) 
    {
        int firstNumber = number % 10;
        int lastNumber = number / 100;

       return firstNumber == lastNumber;
    }


    // ****************************
    // *   Count sum in 4-digit number   *
    // ****************************

    static int CountSumInFourDigitNumber(int number) 
    {
        int fourthNumber = number % 10;
        int thirdNumber = (number / 10) % 10;
        int secondNumber = (number / 100) % 10;
        int firstNumber = number / 1000;

        return fourthNumber + thirdNumber + secondNumber + firstNumber;  

    }

    // ****************************
    // *   Convert Celsius to Fahrenheit  *
    // ****************************

    static double ConvertCelsiusToFahrenheit(double celsius)
    {
        return Math.Round((celsius * 9 / 5) + 32, 2);
    }

    // ****************************
    // *   Calculate BMI  *
    // ****************************


    static double CalculateBMI(int height, double weight)
    {
        double heightMeters = (double)height / 100;
        double bmi = weight / (heightMeters * heightMeters);
        return Math.Round(bmi, 2);
    }

    //Напишите программу, которая принимает от пользователя символ (тип char) и выводит следующий за ним символ в таблице ASCII.

    static char CalculateChar(char n)
    {  
        return (char) (n + 1);
    }

    //Пользователь вводит два числа. Одно из них — целое (int), а другое — число с плавающей запятой (double). Ваша задача — выполнить деление и обработать возможные ошибки.

    // Условие:
    // Напишите метод double Divide(int a, double b), который:
    // 1. Делит a на b.
    // 2. Выбрасывает исключение ArgumentException, если b == 0.
    // 3. Возвращает результат в виде double.
    // Напишите код, который вызывает этот метод с вводом пользователя и выводит результат.

    static double Division(int a, double b)
    {
        if(b == 0)
        {
            throw new Exception("Error, you can't divide by 0");
        }

        return a / b;
    } 

    /* 
    Пользователь вводит число, и вам нужно округлить его до целого значения. 
    Однако, если число слишком большое для хранения в int, программа должна выбросить ошибку.

    Условие:
    Напишите метод int RoundAndCheck(double value), который:
    1. Округляет value до ближайшего целого.
    2. Если результат выходит за пределы int, выбрасывает OverflowException.
    3. Возвращает округленное значение.

    Напишите код, который вызывает этот метод и обрабатывает ошибки.
    */

    static int RoundAndCheck(double value) 
    {
        return checked((int) value); 
    }

    static long SafeSum(long a, double b)
    {
        return checked((long) (a + b));
    }

    // Работа с символами
    // Описание:
    // Напишите программу, которая принимает от пользователя омер символа в ASCII и выводит символ которому он соответствует.

    static char ConvertToChar(int number)
    {
        return (char) number;
    }


    /*
    Напишите программу, которая запрашивает у пользователя текущий час (от 0 до 23) и выводит сообщение:

    "Доброе утро!", если время от 6 до 11,

    "Добрый день!", если время от 12 до 17,

    "Добрый вечер!", если время от 18 до 22,

    "Доброй ночи!", если время от 23 до 5.
    */

    static void GreetAccordingToTime(int hour)
    {
        if (hour >= 6 && hour <= 11)
        {
            Console.WriteLine("Доброе утро!");
        }
        else if (hour >= 12 && hour <= 17)
        {
            Console.WriteLine("Добрый день!");
        }
        else if (hour >= 18 && hour <= 22)
        {
            Console.WriteLine("Добрый вечер!");
        } else if (hour >= 23 && (hour >= 0 && hour <= 5)) 
        {
            Console.WriteLine("Доброй ночи!");
        } else 
        {
            throw new Exception("Неправильное число!");
        }
    }

    /*

    Напишите программу, которая запрашивает у пользователя номер месяца (от 1 до 12) и выводит название сезона:

    "Зима" для декабря (12), января (1) и февраля (2),

    "Весна" для марта (3), апреля (4) и мая (5),

    "Лето" для июня (6), июля (7) и августа (8),

    "Осень" для сентября (9), октября (10) и ноября (11).
    */

    static void PrintSeason(int mouth)
    {
        switch (mouth)
        {
            case 12:
            case 1:
            case 2:
                Console.WriteLine("Winter");
                break;
            case 3:
            case 4:
            case 5:
                Console.WriteLine("Sping");
                break;
            case 6:
            case 7:
            case 8:
                Console.WriteLine("Summer");
                break;
            case 9:
            case 10:
            case 11:
                Console.WriteLine("Autumn");
                break;
            default: 
                throw new Exception("Неправильное число!");
        }
    }

    /*
    Напишите программу, которая запрашивает у пользователя число и выводит:

    "Положительное", если число больше 0,

    "Отрицательное", если число меньше 0,

    "Ноль", если число равно 0.
    */

    static void PrintNumber(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("Положительное");
        } else if (number < 0)
        {
            Console.WriteLine("Отрицательное");
        } else
        {
            Console.WriteLine("Ноль");
        }
    }

    /*
    Напишите программу, которая запрашивает у пользователя длины трёх сторон
    и проверяет, может ли существовать треугольник с такими сторонами. 
    Треугольник существует, если сумма любых двух сторон больше третьей. 
    Выведите "Треугольник существует" или "Треугольник не существует".
    */

    static void СуществуетЛиТреугольник(int a, int b, int c)
    {
        int sum1 = a + b;
        int sum2 = b + c;
        int sum3 = a + c;
        if(sum1 > c && sum2 > a && sum3 > b)
        {
            Console.WriteLine("Существует");
        } else
        {
            Console.WriteLine("Не существует");
        }
       
    }

}
