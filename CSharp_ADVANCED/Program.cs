using System;

public class Program
{
	/*
	Delegates
	Func, Action y Predicate
	*/
	public delegate void PrintMessage(string value);

	public static void Main(string[] args)
	{
		PrintMessage printHello = new PrintMessage(PrintHello);

		printHello("Alfredo");

		Console.Read();
	}

	public static void PrintHello(string name)
	{
		Console.WriteLine($"Hola, {name}.");
	}
}

