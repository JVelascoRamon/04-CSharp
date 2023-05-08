Console.Write("Enter an integer (0 to 4,294,967,295): ");
uint n = uint.Parse(Console.ReadLine());

for (uint i = 1; i <= n; i++)
{
    if ((i %3 != 0) && (i % 7 !=0))
    {
        Console.Write(i + " ");
    }
}