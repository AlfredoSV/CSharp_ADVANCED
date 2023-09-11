using System;

public class Program
{
	/*
	Delegates
	*/
	public delegate void PrintMessage(string value);
	public delegate void PrintMessageGeneric<T>(T value);

	public static void Main(string[] args)
	{
		#region Simple example
		//PrintMessage printHello = new PrintMessage(PrintHello);
		//printHello("Alfredo");
		#endregion

		#region Generic Example
		//PrintMessageGeneric<string> str = new PrintMessageGeneric<string>(PrintHello);
		//PrintMessageGeneric<int> intN = new PrintMessageGeneric<int>(PrintInt);
		//PrintMessageGeneric<Guid> guid = new PrintMessageGeneric<Guid>(PrintGuid);

		//str("Alfredo");
		//intN(2);
		//guid(Guid.NewGuid());
		#endregion

		//Func, Action, Predicate and Anonymous

		#region Action

		//Action<string> printHello = PrintHello;

		//printHello("Alfredo");

		////Delegate
		//Action<int, int> add = delegate (int number1, int number2)
		//{
		//	Console.WriteLine(number1 + number2);
		//};

		////Lamda
		//Action<int, int> sub = (int number1, int number2) =>
		//{
		//	Console.WriteLine(number1 - number2);
		//};

		//add(1, 29);
		//sub(29, 1);

		#endregion

		#region Func

		//Func<int, int, int> func = SumRange;

		//int res = func(1, 2);

		//Console.WriteLine(res);

		//Func<int, int, int> func2 = delegate (int rangeInit, int rangeEnd){

		//	int sum = 1;

		//	for (int i = rangeInit; i <= rangeEnd; i++)
		//	{

		//		sum *= i;
		//	}
		//	return sum;
		//};

		//int res = func2(1, 2);

		//Console.WriteLine(res);

		#endregion

		#region Predicate

		Predicate<int> predicate = delegate (int value) { 
			return value == 0; 
		};

		Console.WriteLine(predicate(1));

		#endregion

		Console.Read();
	}

	public static void PrintHello(string name)
	{
		Console.WriteLine($"Hola, {name}.");
	}

	public static void PrintInt(int value)
	{
		Console.WriteLine($"Type: {value.GetType()}");
	}

	public static void PrintGuid(Guid value)
	{
		Console.WriteLine($"Type: {value.GetType()}");
	}

	public static int SumRange(int rangeInit, int rangeEnd)
	{
		int sum = 0;

		for (int i = rangeInit; i <= rangeEnd; i++)
		{

			sum += i;
		}

		return sum;
	}
}

