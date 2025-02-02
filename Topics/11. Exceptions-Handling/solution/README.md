## Exceptions-Handling

* Write a program that reads an integer number and calculates and prints its square root. If the number is invalid or negative, print "Invalid number". In all cases finally print "Good bye". Use try-catch-finally.
  * [Solution](../solution/01.%20Square%20root%20of%20number/SquareRootOfNumber.cs)

* Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, the method should throw an exception. Using this method write a program that enters 10 numbers:
  * a1, a2, … a10, such that 1 < a1 < … < a10 < 100

  * [Solution](../solution/02.%20Read%20Ten%20numbers%20in%20given%20range/ReadNumbersInGivenRange.cs)

* Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console. Find in Documentation how to use System.IO.File.ReadAllText(…). Be sure to catch all possible exceptions and print user-friendly error messages.
  * [Solution](../solution/03.%20Read%20file%20content/ReadFileContent.cs)

* Write a program that downloads a file from Internet (e.g. http://www.devbg.org/img/Logo-BASD.jpg) and stores it the current directory. Find in Google how to download files in C#. Be sure to catch all exceptions and to free any used resources in the finally block.
  * [Solution](../solution/04.%20Download%20from%20I-net/DownloadFromInternet.cs)
