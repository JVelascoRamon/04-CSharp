## Strings and Text Processing

1. Write a program that reads a string, reverses it and prints the result at the console.
    * Example: `"sample"` -> `"elpmas"`.

    * [Solution](01-ReverseString/ReverseString.cs)
2. Write a program to check if in a given expression the brackets are put correctly.
    * Example of correct expression: `((a+b)/5-d)`.
    * Example of incorrect expression: `)(a+b))`.

    * [Solution](02-ValidExpression/ValidExpression.cs)
3. Write a program that finds how many times a substring is contained in a given text (perform case insensitive search). Example:
    * The target substring is "in".
    * The text is as follows: We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.
    * The result is: 9.

    * [Solution](03-OccursOfWord/OccursOfWord.cs)
4. You are given a text. Write a program that changes the text in all regions surrounded by the tags `<upcase>` and `</upcase>` to uppercase. The tags cannot be nested.
    *  Example: We are living in a \<upcase\>yellow submarine\</upcase\>. We don't have \<upcase\>anything\</upcase\> else.
    * The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.

    * [Solution](04-UpCase/TagMakesWordsLarge.cs)
5. Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with `'*'`. Print the result string into the console.

    * [Solution](05-StringFilledWithStars/StringFilledWithStars.cs)
6. Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings.
   * Sample input: Hi!
   * Expected output: `\u0048\u0069\u0021`

    * [Solution](06-StringToUnicode/EncodingAndDecodingOfWord.cs)
7. Write a program that reverses the words in given sentence. Example:
    * "C# is not C++, not PHP and not Delphi!"
    * "Delphi not and PHP, not C++ not is C#!"

    * [Solution](07-ReverseWords/ReverseWordsInSentence.cs)
8. Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. Example: `"aaaaabbbbbcdddeeeedssaa"` -> `"abcdedsa"`.

    * [Solution](08-ReplaceSequencesWithSingleElement/ReplaceSequencesWithSingleElement.cs)
9. Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

    * [Solution](09-SortAlphabetical/SortAlphabetical.cs)
