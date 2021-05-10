/*
* 3. Write a method that from a given array of students
* finds all students whose first name is before its last
* name alphabetically. Use LINQ query operators.
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
        var linqQuery =
                   from student in students
                   where student.FirstName.CompareTo(student.LastName) < 0
                   select student;

        // Extension method
        var extensionMethod = students.Where(student => student.FirstName.CompareTo(student.LastName) < 0);

        Console.WriteLine("#1: Using LINQ query: ");
        Console.WriteLine(string.Join(Environment.NewLine, linqQuery));

        Console.WriteLine("\n#2: Using Extension method: ");
        Console.WriteLine(string.Join(Environment.NewLine, extensionMethod));
    }
}