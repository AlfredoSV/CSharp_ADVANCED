using System;

public class Program
{
	/*
	Delegates
	Func, Action y Predicate
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
}

