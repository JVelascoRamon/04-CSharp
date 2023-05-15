/*
* 4. Write a LINQ query that finds the first name
* and last name of all students with age between 18 and 24.
*/

using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var students = new[]
        {
            new { FirstName = "Peter", LastName = "Smith" },
            new { FirstName = "Noah", LastName = "Anderson" },
            new { FirstName = "Liam", LastName = "Singh" },
            new { FirstName = "Boris", LastName = "Morton" },
            new { FirstName = "Michael", LastName = "Brown" }
        };

        // Linq query
        var query =
                   from student in students
                   where student.Age >= 18 && student.Age <= 24
                   select new { student.FirstName, student.LastName };

        Console.WriteLine("#1: Using LINQ query: ");
        Console.WriteLine(string.Join(Environment.NewLine, query));
    }
}