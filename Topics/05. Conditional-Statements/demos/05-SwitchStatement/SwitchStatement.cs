using System;

class SwitchStatement
{
    static void Main()
    {
    /*
        Console.Write("Enter a number in the range [1..7]: ");

        int day = int.Parse(Console.ReadLine());
        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    */
        Console.Write("Enter a number in the range [1..9]: ");
        int score;
        if (int.TryParse(Console.ReadLine(), out score))
        {
            switch (score)
            {
                case 1:
                case 2: 
                case 3:
                    score = 10 * score;
                    Console.WriteLine($"The new score is: {score}");
                    break;

                case 4:
                case 5: 
                case 6:
                    score = 100 * score;
                    Console.WriteLine($"The new score is: {score}");
                    break;

                case 7:
                case 8: 
                case 9:
                    score = 1000 * score;
                    Console.WriteLine($"The new score is: {score}");
                    break;

                default:
                    Console.WriteLine("The score is not in the range [1..9]");
                    break;
            }
        }
        else  Console.WriteLine("This is not a valid score");
    }
}
