Homework: Extension-Methods-Delegates-Lambda-LINQ
=================================================

### Problem 1. StringBuilder.Substring
*	Implement an extension method `Substring(int index, int length)` for the class `StringBuilder` that returns new `StringBuilder` and has the same functionality as `Substring` in the class `String`.

### Problem 2. IEnumerable extensions
*	Implement a set of extension methods for `IEnumerable<T>` that implement the following group functions: sum, product, min, max, average.

### Problem 3. First before last
```cs
        var students = new[]
        {
            new { FirstName = "Peter", LastName = "Smith" },
            new { FirstName = "Noah", LastName = "Anderson" },
            new { FirstName = "Liam", LastName = "Singh" },
            new { FirstName = "Boris", LastName = "Morton" },
            new { FirstName = "Michael", LastName = "Brown" }
        };
```
*	Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
*	Use LINQ query operators.

### Problem 4. Age range
*	Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

### Problem 5. Order students
*	Using the extension methods `OrderBy()` and `ThenBy()` with lambda expressions sort the students by first name and last name in descending order.
*	Rewrite the same with LINQ.

### Problem 6. Divisible by 7 and 3
*	Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
