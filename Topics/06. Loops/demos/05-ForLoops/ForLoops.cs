using System;
using System.Collections.Generic;

class ForLoops
{
    static void Main()
    {       
    /*
        for (int num = 0; num < 10; num++)
        {
            Console.Write(num + " ");
        }

        Console.WriteLine();
        Console.WriteLine();

        int n = 5;
        decimal factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("{0}! = {1}", n, factorial);
        Console.WriteLine();

        for (int i = 1, sum = 1; i <= 128; i = i * 2, sum += i)
        {
            Console.WriteLine("i={0}, sum={1}", i, sum);
        }

        Console.WriteLine();

        for(string line = Console.ReadLine(); !string.IsNullOrEmpty(line); line = Console.ReadLine())
        {
            Console.WriteLine("Just read: " + line);
        }

        Console.ReadLine();
    */

    /*  //Ejercicio 1. Clase 08/05/2023

        Console.Write("Please enter the last number of the secuence: ");
        int LaststNum = int.Parse(Console.ReadLine());

        for (int num = 0; num <= LaststNum; num++)
        {
            Console.Write(num + " ");
        }
    */

    /*  //Ejercicio 2. Clase 08/05/2023

        Console.Write("Please enter the last number of the secuence: ");
        int LaststNum = int.Parse(Console.ReadLine());

        for (int num = 0; num <= LaststNum; num++)
        {
            if (num % 3 != 0 || num % 7 != 0)
            {
                Console.Write(num + " ");
            }
        }
    */


    /*    //Ejercicio 3. Clase 08/05/2023

        Console.Write("Please enter the numbers of the secuence or write 'exit' to finish: ");
        List<int> numeros = new List<int>();
        
        int num;
        while (int.TryParse(Console.ReadLine(), out num))
        {
            numeros.Add(num);
        }
        
        int MAX = int.MinValue;
        int min = int.MaxValue;
        foreach (int numero in numeros)
        {
            if (numero > MAX) {MAX = numero;}
            if (numero < min) {min = numero;}
        }
        Console.Write("The maximal is: " + MAX + " ");
        Console.Write("The minimal is: " + min + " ");
        Console.Write("---End of the program---");
    */

        //Ejercicio 4. Clase 08/05/2023

        Console.Write("Please enter the N number: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Please enter the K number: ");
        int K = int.Parse(Console.ReadLine());

        int fact = N - K; //La división solo necesita hacer el factorial de la diferencia

        int numerador = 1;

        for (; N < K; N--)
        {
            Console.Write("Numerador: " + numerador + " ");
            Console.Write("N: " + N + "\n");
            numerador = numerador * N;
        }

        Console.Write(numerador);
    }
}
