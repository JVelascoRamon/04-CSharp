using System;

class DataValidation
{
	/*
	static void Main()
	{
	
		Console.WriteLine("What time is it?");
		
		Console.Write("Hours: ");
		int hours = int.Parse(Console.ReadLine());

		Console.Write("Minutes: ");
		int minutes = int.Parse(Console.ReadLine());

		bool isValidTime = ValidateHours(hours) && ValidateMinutes(minutes);
		if (isValidTime)
		{
			Console.WriteLine("The time is {0}:{1} now.", hours, minutes);
		}
		else
		{
			Console.WriteLine("Incorrect time!");
		}
		
		Console.ReadLine();
	}

	static bool ValidateMinutes(int minutes)
	{
		bool result = (minutes >= 0) && (minutes <= 59);
		return result;
	}

	static bool ValidateHours(int hours)
	{
		bool result = (hours >= 0) && (hours <= 24);
		return result;

	*/



	



	/*	// Ejercicio 1. Clase 09/05/2023
	static int GetMax(int first , int second) //Defino el método fuera del Main. Lee dos números enteros y devuelve el mayor
	{
		if (first > second)
		{
			return first;
		}
		return second;
	}

	static void Main()
	{
		Console.Write("Please enter your 3 numbers: ");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());

		
		int Bigger = GetMax(num1 , num2); //Este bigger es auxiliar, puesto que tengo que aplicar el método 2 veces
		int Biggest = GetMax(Bigger , num3);

		Console.WriteLine ($"The biggest number of theese three is: {Biggest}");

	*/






	/*	// Ejercicio 2. Clase 09/05/2023
	static void LastDigit(int number) //Lee un entero y escribe una cadena. Cono no devuelve nada, es void.
	{
		int digit = number % 10; //Me quedo con el resto de dividir entre 10, lo que me dará el último dígito del número
		switch (digit)
		{
			case 0:
                Console.WriteLine("Zero"); break;
            case 1:
                Console.WriteLine("One"); break;
			case 2:
                Console.WriteLine("Two"); break;
			case 3:
                Console.WriteLine("Three"); break;
			case 4:
                Console.WriteLine("Four"); break;
			case 5:
                Console.WriteLine("Five"); break;
			case 6:
                Console.WriteLine("Six"); break;
			case 7:
                Console.WriteLine("Seven"); break;
			case 8:
                Console.WriteLine("Eight"); break;
			case 9:
                Console.WriteLine("Nine"); break;	
		}
	}

	static void Main()
	{
		Console.Write("Please enter your number: ");
        int num = int.Parse(Console.ReadLine());
		LastDigit (num);
	}
	*/






	/*	// Ejercicio 3. Clase 09/05/2023
	static void AppearanceTimes(int number, int [] conjunto) //Lee un entero y escribe una cadena. Cono no devuelve nada, es void.
	{
		int times = 0;
		foreach (int num in conjunto)
		{
			if (num == number)
			{
				times++;
			}
		}

		Console.WriteLine($"The number {number} appears {times} times in the array given");
	}

	static void Main()
	{
		int numInteresado = 5;
		int[] conjunto = {1, 2, 3, 3, 3, 3, 4, 5, 5, 5, 35, 60};
		AppearanceTimes(numInteresado , conjunto); //Le paso al método el número que quiero contar y el array en el que contarlo
	}
	*/


	



	/*	// Ejercicios 4. Clase 09/05/2023

	static void BiggerThanNeighbors(int position, int [] conjunto) //Lee un entero y escribe una cadena. Es void porque no devuelve nada.
	{
		if (conjunto.Length == 1) //Caso en el que solo hay un elemento
		{
			Console.WriteLine("The array given is just one element long.");
		}

		else if (position == conjunto.Length - 1) //Caso en el que el número es el último elemento. Tiene en cuenta que el array sea de 2 elementos
		{
			if (conjunto[position] > conjunto[position - 1]) //Compruebo si es mayor que el anterior
			{
				Console.WriteLine($"The number {conjunto[position]} is the last number of the array and it is BIGGER than his neighbor: {conjunto[position - 1]}.");
			}
			else {Console.WriteLine($"The number {conjunto[position]} is the last number of the array and it is lower than his neighbor: {conjunto[position - 1]}.");}
		}

		else if (position == 0) //Caso en el que el número es el primer elemento. Tiene en cuenta que el array sea de 2 elementos
		{
			if (conjunto[position] > conjunto[position + 1]) //Compruebo si es mayor que el siguiente
			{
				Console.WriteLine($"The number {conjunto[position]} is the first number of the array and it is BIGGER than his neighbor: {conjunto[position + 1]}.");
			}
			else {Console.WriteLine($"The number {conjunto[position]} is the first number of the array and it is lower than his neighbor: {conjunto[position + 1]}.");}
		}

		else
		{
			if (conjunto[position] > conjunto[position - 1] && conjunto[position] > conjunto[position + 1]) //Compruebo si es mayor que el previo y el siguiente
			{
				Console.WriteLine($"The number {conjunto[position]} is BIGGER than his neighbors: {conjunto[position - 1]} and {conjunto[position + 1]}.");
			}
			else {Console.WriteLine($"The number {conjunto[position]} is lower than one or both his neighbors: {conjunto[position - 1]} and {conjunto[position + 1]}.");}
		}
		
		
	}

	static void Main()
	{
		int position = 3;
		//int[] conjunto = {2};
		int[] conjunto = {1, 2, -2, 34, 5, 4, 3, 35, 60};
		BiggerThanNeighbors(position , conjunto); //Le paso al método la posición y el array
	}
	*/
	


	 	// Ejercicio 5. Clase 09/05/2023

		static bool BiggerThanNeighbors(int position, int [] conjunto) 
	{
		if (conjunto.Length == 1) {return true;}

		else if (position == conjunto.Length - 1) 
		{
			if (conjunto[position] > conjunto[position - 1]) {return true;}
			else {return false;}
		}

		else if (position == 0) 
		{
			if (conjunto[position] > conjunto[position + 1]) {return true;}
			else {return false;}
		}

		else
		{
			if (conjunto[position] > conjunto[position - 1] && conjunto[position] > conjunto[position + 1]) {return true;}
			else {return false;}
		}
	}

	static void Main()
	{
		int[] conjunto = {-3, -2, 4, 4, 4, 4, 3, 3, 2};
		int resultado = -1;

		for (int i = 0; i < conjunto.Length; i++)
		{
			if (BiggerThanNeighbors(i , conjunto) == true) //Le paso al método la posición y el array
			{
				resultado = conjunto[i];
				Console.WriteLine($"The number {resultado} is the first element of the array given that is BIGGER than his neighbors");
				break; //Quiero que pare cuando encuentre el primer elemento que cumple la condición
			}
		}

		Console.WriteLine($"There is no element of the array given that is BIGGER than his neighbors");

	}
}
