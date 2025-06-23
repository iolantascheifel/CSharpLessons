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
		if(str[i] == 'A' && ++count >= 2)
		{
			return false;
		}
	}

	return true;
}

Console.WriteLine(CheckRecord("PPLLAPL"));
