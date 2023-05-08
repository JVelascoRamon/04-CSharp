Console.Write($"Enter an integer (0 to 4,294,967,295): ");
uint n = uint.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.Write(i + " ");
}
