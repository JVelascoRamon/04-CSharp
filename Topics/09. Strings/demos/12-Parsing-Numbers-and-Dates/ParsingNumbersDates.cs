using System;
using System.Globalization;
using System.Threading;

class ParsingNumbersDates
{
	static void Main()
	{

	/*
		string numStr = "3.14";
		Thread.CurrentThread.CurrentCulture =
			CultureInfo.InvariantCulture;
		float f = float.Parse(numStr);
		Console.WriteLine(f); // 3.14

		numStr = "3,14";
		f = float.Parse(numStr);
		Console.WriteLine(f); // 314 -> due to invariant culture

		f = float.Parse(numStr, new CultureInfo("bg-BG"));
		Console.WriteLine(f); // 3.14

		string dateStr = "25.07.2011";
		DateTime date = DateTime.ParseExact(
			dateStr, "dd.MM.yyyy", CultureInfo.InvariantCulture);
		Console.WriteLine(date);

        Console.ReadLine();
	*/




	/*	// Ejercicio 1. Clase 09/05/2023

		Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();
		string reverse = "";

		for (int i = sentence.Length - 1; i >= 0; i--)
		{
			reverse = reverse + sentence[i];
		}

        Console.WriteLine(reverse);
	*/




		// Ejercicio 2. Clase 09/05/2023

		Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();
		string reverse = "";

		for (int i = sentence.Length - 1; i >= 0; i--)
		{
			reverse = reverse + sentence[i];
		}

        Console.WriteLine(reverse);


	}
}
