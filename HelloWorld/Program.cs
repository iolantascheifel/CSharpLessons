namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {

        int number;
        
        while (true)
            {
                Console.WriteLine("Введите 3x значное число:");
                string input = Console.ReadLine();

                if (int.TryParse(input, out number))
                {
                    if (CheckThreeDigitPalindrome(number))
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: введите корректное целое число.");
                }
            }

        ConvertSecondsToTime(3650);

    }

    static void ConvertSecondsToTime(int time) 
    {
        int seconds = time % 60;
        int totalMinutes = time / 60;
        int minutes = totalMinutes % 60;
        int hours = totalMinutes / 60;

        Console.WriteLine($"{seconds}, {minutes}, {hours}");
    }

    static bool CheckThreeDigitPalindrome(int number) 
    {
        if ((number >= 100 && number <= 999) || (number <= -100 && number >= -999))
        {
            if (IsPalindrome(number)) 
            {
                Console.WriteLine("Это палиндром!");
            } else 
            {
                Console.WriteLine("Это не палиндром.");
            }
            return true;
        }
        else
        {
            Console.WriteLine("Число не трёхзначное. Попробуйте снова.");
            return false;
        }
        
    }

    static bool IsPalindrome(int number)

    {
        string initialText = Math.Abs(number).ToString(); 
        char[] charArray = initialText.ToCharArray();
        Array.Reverse(charArray);
        string reversedText = new string(charArray);

       return initialText == reversedText;
    }
}
