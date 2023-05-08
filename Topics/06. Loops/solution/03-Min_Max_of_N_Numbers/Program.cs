Console.Write("Enter count of numbers (0 to 4,294,967,295): ");
uint n = uint.Parse(Console.ReadLine());
uint min = uint.MaxValue;
uint max = uint.MinValue;
uint sum = 0;
double average = 0;

for (uint i = 0; i < n; i++)
{
    Console.Write($"Enter integer {i} (-2,147,483,648 to 2,147,483,647): ");
    uint num = uint.Parse(Console.ReadLine());

    min = Math.Min(min, num);
    max = Math.Max(max, num);
    sum += num;
}

average = sum / (double)n;  
//we need to cast at least one of the members of the expression to double so that
//the calculation takes place in floating point, otherwise we will get an integer result after the calculation
//and then it will be casted to double, which will lose all precision after the decimal point.

Console.WriteLine("min= {0}, max= {1}, sum= {2}, average= {3:0.00}", min, max, sum, average);