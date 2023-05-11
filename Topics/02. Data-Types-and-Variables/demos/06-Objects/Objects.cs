using System;

class Objects
{
	static void Main()
	{
		object dataContainer = 5; //Objet es como si fuera una caja. Sirve para transportar algo de un sitio a otro
		Console.Write("The value of dataContainer is: ");
		Console.WriteLine(dataContainer);

		dataContainer = "Five"; //Saco el 5 de la caja y meto la cadena "Five"
		Console.Write("The value of dataContainer is: ");
		Console.WriteLine(dataContainer);
	}
}
