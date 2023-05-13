Console.Write("Enter number 1 ( 1 to 100 ): ");
double num1 = double.Parse(Console.ReadLine());
Console.Write("Enter number 2 ( 1 to 100 ): ");
double num2 = double.Parse(Console.ReadLine());

double n = Math.Max(num1, num2);
double k = Math.Min(num1, num2);
double factn = 1;
double factk = 1;

for (int i = 1; i <= n; i++)
{
    factn = factn * i; 
}

for (int i = 1; i <= k; i++)
{
    factk = factk * i;
}

Console.WriteLine(factn/factk);