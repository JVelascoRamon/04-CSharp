using System;
using System.Collections.Generic;

public class ResizingLists
{
    static void Main()
    {
    /*
        List<int> list = new List<int>();
        int n = int.Parse(Console.ReadLine());

        string lineBreak = new string('-', 20);

        for (int i = 0; i < n + 1; i++)
        {
            var capacity = list.Capacity;
            var count = list.Count;
            Console.WriteLine("Total Capacity of the List: {0}\nused:{1}\n{2}",
                capacity, count, lineBreak);
            list.Add(i);
        }

        Console.ReadLine();
    */

    /*    // Ejercicio 1. Clase 08/05/2023

        int[] array = new int[20];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
            Console.Write($"Elemento {i}: {array[i]} \n");
        }

        Console.WriteLine("Fin");

    */

    /*    // Ejercicio 2. Clase 08/05/2023

        //int[] array1 = {0, 1, 2, 3, 4};
        //int[] array2 = {0, 1, 2, 3, 4};

        Console.Write("Introduzca el número de elementos de ambos arrays: ");
        int tamaño = int.Parse(Console.ReadLine());
        int[] array1 = new int[tamaño]; // Inicializo los array
        int[] array2 = new int[tamaño];

        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Introduzca el elemento {i} del primer array: ");
            array1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < tamaño; i++)
        {
            Console.Write($"Introduzca el elemento {i} del segundo array: ");
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < tamaño; i++)
        {
            if (array1[i] == array2[i])
            {
                Console.Write($"El elemento {i} es igual: {array1[i]} = {array2[i]} \n");
            }
            else
            {
                Console.Write($"El elemento {i} es distinto: {array1[i]} != {array2[i]} \n");
            }
        }
    */

        // Ejercicio 3. Clase 08/05/2023

        Console.Write("Introduzca la primera frase: ");
        string frase1 = Console.ReadLine();
        Console.Write("Introduzca la segunda frase: ");
        string frase2 = Console.ReadLine();


        if (string.Compare(frase1, frase2) == 0) // Compara las dos frases y devuelve 0 si son iguales
        {
            Console.WriteLine("Las frases son iguales.");
        }
        else
        {
            Console.WriteLine("Las frases son distintas.");
        }

        // A partir de aquí es para comparar caracter por caracter
        frase1 = frase1.Replace(" ", "");
        frase2 = frase2.Replace(" ", "");

        if (frase1.Length != frase2.Length) 
        {
            Console.WriteLine("Las frases no tienen el mismo tamaño.");
        }

        int tamaño = Math.Min(frase1.Length , frase2.Length);
        char[] array1 = new char[tamaño];
        char[] array2 = new char[tamaño];

        for (int i = 0 ; i < tamaño ; i++)
        {
            array1 [i] = frase1 [i];
            array2 [i] = frase2 [i];
            if (array1 [i] == array2 [i])
            {
                Console.WriteLine($"El elemento {i} es igual: {array1[i]} = {array2[i]}");
            }
            else
            {
                Console.WriteLine($"El elemento {i} es distinto: {array1[i]} != {array2[i]}");
            }
        }

     


    }
}
