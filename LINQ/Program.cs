namespace LINQ;

class Program
{
    
    // (метод CheckRecord). Вам выдается строка s, представляющая запись о посещении учащегося, где каждый символ означает,
    // отсутствовал ли учащийся, опоздал или присутствовал в этот день. Запись содержит только следующие три символа:
    //
    // "A": Отсутствует.
    // "L": Опоздал.
    // "P": Присутствует.
    //     Студент имеет право на получение премии за посещаемость, если он соответствует обоим следующим критериям:
    //
    // Студент отсутствовал ("А") в общей сложности строго менее 2 дней.
    // Студент никогда не опаздывал ("L") в течение 3 или более дней подряд. Возвращает значение true, если учащийся имеет право на получение премии за посещаемость, или false в противном случае.
    //
    //     Пример:
    // Input: s = "PPALLP"
    // Output: true
    //
    // Ограничения:
    // 1 <= s.length <= 1000
    // s[i] может быть только: 'A', 'L', или 'P'.
    
    // (метод GetMajorityElement). Найти основной элемент массива.
    // Основной элемент - это элемент, который появляется более ⌊n / 2⌋ раз. Считаем, что основной элемент всегда существует в массиве. Пример:
    //
    // Input: nums = [3,2,3]
    // Output: 3
    // Ограничение:
    // n = = nums.length
    // 1 <= n <= 5 * 104
    // -109 <= nums[i] <= 109
    // В случае ошибки входных параметров выбросить ArgumentException.

    
    // Международный азбука Морзе определяет стандартное кодирование,
    // где каждая буква сопоставляется с серией точек и тире следующим образом:
    //
    // - 'a' сопоставляется с ".-",
    // - 'b' сопоставляется с "-...",
    // - 'c' сопоставляется с "-.-.", и так далее.
    //
    //     Для удобства полная таблица для 26 букв английского алфавита приведена ниже:
    //
    // [".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
    //
    // Дан массив строк words, где каждое слово может быть записано
    // как конкатенация кода Морзе для каждой буквы. Например, "cab" может быть записано как "-.-..--...", что является конкатенацией "-.-.", ".-", и "-...".
    // Мы будем называть такую конкатенацию трансформацией слова.
    //
    //     Верните количество различных трансформаций среди всех данных слов.
    // (подсказка можно если сделать такое выражение ‘c’ - ‘a’ оно вернет 2) (6)
    //
    
    //
    // (метод IsRotatedString). Учитывая две строки s и goal,
    // верните значение true тогда и только тогда, когда s может стать
    // целью после некоторого количества сдвигов.
    // Сдвиг строки s состоит в перемещении крайнего левого символа s в крайнюю правую позицию.
    // Например, если s = "abcde", то после одного сдвига это будет "bcdea".
    //
    // Пример:
    // Input: s = "abcde", goal = "cdeab"
    // Output: true
    //
    // Ограничения:
    // 1 <= s.length, goal.length <= 100
    // s и goal содержат только английские символы в нижнем регистре.



    static void Main(string[] args)
    {
        int[]  array = { 1, 8, 8, 6, 8, 8 };

        int majority = GetMajorityElement(array);
        
        Console.WriteLine($"majority: {majority}");


        string s = "abcd";
        string goal = "cdab";

        bool isRotatedString = IsRotatedString(s, goal);
        Console.WriteLine($"isRotatedString: {isRotatedString}");
        
        
        int[] array2 = { 0, 8, 0, 0, 8 };
        int[] shiftZeros = ShiftZeros(array2);
        
        Console.WriteLine($"shiftZeros: {string.Join(", ", shiftZeros)}");
        
        string[] words = { "flower", "fly", "flight", "flow" };
        string stringMethod = CommonPrefix(words);
        
        Console.WriteLine($"stringMethod: {stringMethod}");

    }

    public static bool CheckRecord(string s)
    {
        return s.Contains("LLL") || s.Count(x => x == 'A') < 2; 
    }
    
    public static int GetMajorityElement(int[] nums)
    {
        return nums.First(number => 
            nums.Count(innerNumber => innerNumber == number) > nums.Length / 2);
    }
    
    
    private static readonly string[] MorseCodes =
    {
        ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---",
        "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-",
        "..-", "...-", ".--", "-..-", "-.--", "--.."
    };
    
    public static int UniqueMorseRepresentations(string[] words)
    { 
        // ['C', 'A', 'T'] => ["-.-.", ".-", "---"] => "-.-..----"
        return words.Select(word => 
            String.Join(" ", word.Select(symbol => 
                MorseCodes[symbol - 'a']))).Distinct().Count();
    }

    public static bool IsRotatedString(string s, string goal) //s = "abcde", goal = "cdeab" - true
    {
        return s.Length == goal.Length && (s + s).Contains(goal);
    }
    

    public static int[] FindAllDisappearedNums(int[] nums)
    {
        int n = nums.Length;
        
        return Enumerable.Range(1, n) // - генерирует числа с 1 до n.
            .Where(number => !nums.Contains(number))
            .ToArray();
    }
    
    /*
    (метод ShiftZeros)Учитывая целочисленный массив nums, 
    переместите все нули в его конец, сохраняя относительный 
    порядок ненулевых элементов. Обратите внимание, 
    что вы должны сделать это на месте, не создавая копию массива. 
    Пример:
    Input: nums = [0,1,0,3,12]
    Output: [1,3,12,0,0]
    */

    public static int[] ShiftZeros(int[] nums)
    {
        var nonZeros = nums.Where(n => n != 0);   
        var zeros    = nums.Where(n => n == 0);  

        return nonZeros.Concat(zeros).ToArray(); 
    }
    
    /*
     * (Метод LongestCommonPrefix).
     * Напишите функцию для поиска самой длинной строки общего префикса
     * среди массива строк. Если общего префикса нет, возвращаем пустую строку.
     * Самое маленькое слово не может быть короче 2-х символов.
     * В случае неправильного параметра выбросить InvalidOperationException. (4)
     *
     * input = ['flower', 'flow', 'fly']
     * output = 'fl'
     */
    
    public static string CommonPrefix(string[] words) =>
        new string(
            words.SelectMany(w => w.Select((ch, i) => (ch, i)))
                .GroupBy(x => x.i)
                .TakeWhile(g => g.Select(x => x.ch).Distinct().Count() == 1)
                .Select(g => g.First().ch)
                .ToArray()
        );
    

}