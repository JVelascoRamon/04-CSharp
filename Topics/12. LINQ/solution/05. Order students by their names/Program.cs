/*
* 5. Using the extension methods OrderBy() and ThenBy()
* with lambda expressions sort the students by first name
* and last name in descending order. Rewrite the same with LINQ.
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

        // Extension methods
        var orderedStudents = students.OrderByDescending(x => x.FirstName).ThenBy(y => y.LastName);

        Console.WriteLine("#1: Using extension methods: ");
        Console.WriteLine(string.Join(Environment.NewLine, orderedStudents));

        // Linq query
        orderedStudents =
                         from student in students
                         orderby student.FirstName descending, student.LastName descending
                         select student;

        Console.WriteLine("\n#2: Using LINQ: ");
        Console.WriteLine(string.Join(Environment.NewLine, orderedStudents));
    }
}