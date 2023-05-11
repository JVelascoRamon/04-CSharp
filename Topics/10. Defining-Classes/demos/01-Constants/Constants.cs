using System;

/*
public class Constants
{
	public const double PI = 3.1415926535897932385;
	public readonly double Size;

	public Constants(int size)
	{
		this.Size = size; // Cannot be further modified!
	}

	static void Main()
	{
		Console.WriteLine(Constants.PI);
		Constants c = new Constants(5);
		Console.WriteLine(c.Size);
		
		//c.Size = 10; // Compilation error: readonly field
		//Console.WriteLine(Constants.Size); // compile error
		
		Console.ReadLine();
	}
}
*/


// Me he apoderado de este proyecto para hacer los ejemplos. Aquí defino la clase Dog
class Dog
{
    private string name;
    private string breed;

    public Dog()
    { 
    }

    public Dog(string name, string breed)
    { 
        this.name = name;
        this.breed = breed; 
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Breed
    {
        get { return this.breed; }
        set { this.breed = value; }
    }

    public void SayBau()
    {
        Console.WriteLine("{0} said: Bauuuuuu!", 
			this.name ?? "[unnamed dog]");
    }
} 



