using System;
class DogMeeting
{
	static void Main()
	{
		Console.Write("Enter first dog's name: ");
        string dogName = Console.ReadLine();
        Console.Write("Enter first dog's breed: ");
        string dogBreed = Console.ReadLine();

		// Use the Dog constructor to assign name and breed
        Dog firstDog = new Dog(dogName, dogBreed);

        // Create a new dog using the parameterless constructor
        Dog secondDog = new Dog();

		// Use properties to set name and breed
		Console.Write("Enter second dog's name: ");
        secondDog.Name = Console.ReadLine(); 
        Console.Write("Enter second dog's breed: ");
        secondDog.Breed = Console.ReadLine(); 

		// Create a Dog with no name and breed
		Dog thirdDog = new Dog(); // Para darle nombre y raza hay que pasarle 2 strings "Julián", "Perro de agua". No acepta solo uno de los dos

		// Save the dogs in an array
		Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

		// Ask each of the dogs to bark
		foreach(Dog dog in dogs)
		{ 
            if (dog.Name == "Átomo")
            {Console.WriteLine("Vámonos Átomo!!");} //Por los loles
			dog.SayBau();
		}
		
		Console.ReadLine();
	}
}