// int GetFactorial(int n)
// {
// 	if(n == 1)
// 	{
// 		return 1;
// 	}

// 	return n * GetFactorial(n - 1);
// }

// int GetFibonacciNum(int n)
// {
// 	if(n == 1 || n == 2) 
// 	{
// 		return n - 1;
// 	}

// 	int previous = 0;
// 	int current = 1;

// 	for(int i = 3; i <= n; i++)
// 	{
// 		int sum = previous + current;
// 		previous = current;
// 		current = sum;
// 	}

// 	return current;
// }

//while
//recursion

int a = 5;
int b = 7;

void Swap(ref int first, ref int second) 
{
	(first, second) = (second, first);
}

Swap(ref a, ref b);
// Console.WriteLine($"{a}, {b}");

void ChangeArray(int[] nums)
{
	for(int i = 0; i < nums.Length; i++) 
	{
		if(nums[i] % 2 != 0) 
		{
			nums[i]++;
		}
	}
}

int[] array = new int[] { 2, 4, 5, 8, 9 };

ChangeArray(array);

for(int i = 0; i < array.Length; i++) 
{
	// Console.WriteLine(array[i]);
}


void ChangeString(ref string str) 
{
	str = str.Replace("Hello", "Bye");
}

string hello = "Hello";
ChangeString(ref hello);
// Console.WriteLine(hello);


bool CheckRecord(string str) 
{
	if(str.Contains("LLL")) 
	{
		return false;
	}

	int count = 0;

	for(int i = 0; i < str.Length; i++)
	{
		// if(str[i] == 'A')
		// {
		// 	count++;
		// }

		// if(count >= 2)
		// {
		// 	return false;
		// }

		// оптимизированая версия

		if(str[i] == 'A' && ++count >= 2)
		{
			return false;
		}
	}

	return true;
}

/* 
1. Сумма всех элементов массива
Дан массив целых чисел. Найти сумму всех элементов.
*/

int FindSumOfAllNumbers (int[] arr) 
{
	int sum = 0;
	foreach (int num in arr)
	{
		sum += num;
	}
	return sum;
}

// int result = FindSumOfAllNumbers(new int[] { 1, 9, 3 });
// Console.WriteLine(result);

// Console.WriteLine(FindSumOfAllNumbers({1,2,3}));
// переписать под foreach

/* 
2. Найти максимальный элемент
Дан массив целых чисел. Найти максимальное значение.
*/

int FindTheBiggest (int[] arr)
{
	int max = arr[0];

	foreach (int num in arr)
	{
	    if (num > max)
	    {
	        max = num;
	    }
	}
	return max;
}

// int result = FindTheBiggest(new int[] { 1, 9, 3 });
// Console.WriteLine(result);

/* 
3. Подсчитать чётные числа
Дан массив целых чисел. Подсчитать количество чётных.
*/

int FindNumberOfEvenNumbers (int[] arr)
{
	List<int> evenNumbers = [];

	foreach(int num in arr) 
	{
		if (num % 2 == 0)
		{
			evenNumbers.Add(num);
		}
	}
	return evenNumbers.Count;
}

int result = FindNumberOfEvenNumbers(new int[] { 1, 9, 3, 2, 6, 8, 3, 9, 5, 8 });
Console.WriteLine(result);


