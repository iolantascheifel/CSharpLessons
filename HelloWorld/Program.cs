namespace HelloWorld;

class Program
{
    static void Main(string[] args)
   {

    ConvertSecondsToTime(3650);

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

    CountSumInFourDigitNumber();
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
        if ((number >= 100 && number <= 999) || (number <= -100 && number >= -999))
        {
            if (IsPalindrome(number)) 
            {
                Console.WriteLine("This is palindrome");
            } else 
            {
                Console.WriteLine("This is not palindrome");
            }
            return true;
        }
        else
        {
            Console.WriteLine("This is not a three-digit number. Enter again.");
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

    // ****************************
    // *   Count sum in 4-digit number   *
    // ****************************

    static void CountSumInFourDigitNumber() 
    {
        int number;

        while (true) 
        {
        Console.WriteLine("Enter 4-digit number:");
        string input = Console.ReadLine();

        char[] charArray = input.ToCharArray();

            if(charArray.Length == 4 && int.TryParse(input, out number))
            {
                int sum = 0;
                foreach (char digit in number.ToString())
                {
                    sum += int.Parse(digit.ToString());
                }

                Console.WriteLine($"Sum of all digits of {number} equals to {sum}");
            }
            else 
            {
                Console.WriteLine($"Error: enter correct number");
            }

        }   
        
    }
}
