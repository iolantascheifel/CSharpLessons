namespace OOPPrinciple.CurrencyConverter;

public static class Converter
{
    public static string Convert(this decimal number)
    {
        if (number % 100 >= 11 && number % 100 <= 19)
        {
            return $"{number} рублей";
        } else if (number % 10 == 1)
        {
            return $"{number} рубль";
        } else if (number % 10 >= 2 && number % 10 <= 4)
        {
            return $"{number} рубля";
        }

        return $"{number} рублей";
    }
}