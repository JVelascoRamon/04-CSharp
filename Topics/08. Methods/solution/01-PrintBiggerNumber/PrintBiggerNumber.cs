using System;

class PrintBiggerNumber
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("\nBiggest number: {0}\n", GetMax(GetMax(a, b), c));
    }

    static int GetMax(int a, int b)
    {
        return Math.Max(a, b);
    }
}