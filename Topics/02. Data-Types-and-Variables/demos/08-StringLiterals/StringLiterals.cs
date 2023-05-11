using System;

class StringLiterals
{
	static void Main()
	{
		// Here is a string literal using escape sequences
		string quotation = "\"Hello, Jude\", he said.";
		string path = "C:\\WINNT\\Darts\\Darts.exe"; // La barra \ es un caracter de escape. Hace que se puedan utilizar caracteres reservados a funciones como las comillas o la misma barra \
		Console.WriteLine(quotation);
		Console.WriteLine(path);
		
		// Here is an example of the usage of @
		quotation = @"""Hello, Jimmy!"", she answered."; // El @ es un caracter de escape pero más potente todavía que la barra
		path = @"C:\WINNT\Darts\Darts.exe";
		Console.WriteLine(quotation);
		Console.WriteLine(path);

		Console.WriteLine(@"
			This is a multi-line text,
			represented as verbatim string.
			Note that \n and \t are printed
			as normal characters, not as
			escaping sequences.
		");
	}
}
