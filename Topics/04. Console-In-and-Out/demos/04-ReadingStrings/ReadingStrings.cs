using System;

class ReadingStrings
{
    static void Main()
    {
    
        Console.Write("Please enter your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Hello, {0} {1}!", firstName, lastName);
    

    /*
    // Ejercicio 1. Clase del 05/05/2023

        int num1; //Inicializo las variables que voy a utilizar
        int num2;
        int num3;
        int suma; 

        Console.WriteLine("Introduzca tres números enteros:");
        // Int.Parse convierte el string en un entero. Console.ReadLine() es un string que se pide por consola
        if (int.TryParse(Console.ReadLine(), out num1)) //Intenta convertir la cadena en un número. Si no lo consigue (False), salta al else. Si lo consigue, será True
        {
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                if (int.TryParse(Console.ReadLine(), out num3))
                {
                    suma = num1 + num2 + num3;
                    Console.WriteLine($"The sum is {suma}");
                }
                else Console.WriteLine("El tercer número no es válido");
            }
            else Console.WriteLine("El segundo número no es válido");
        }
        else Console.WriteLine("El primer número no es válido");
    */  
    
    /*
    // Ejercicio 2. Clase del 05/05/2023

        double radio;
        double perimetro;
        double area;

        Console.WriteLine("Introduzca el radio del círculo:");
        radio = double.Parse(Console.ReadLine());
        perimetro = 2 * Math.PI * radio;
        area = Math.PI * Math.Pow(radio , 2);

        Console.WriteLine($"El perímetro del círculo es: {perimetro}");
        Console.WriteLine($"El área del círculo es: {area}");
    */

    /*  
    // Ejercicio 3. Clase del 05/05/2023
   
        string CompanyName, CompanyAddress, CompanyPhone, CompanyFax, CompanyWeb;
        string ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone;

        Console.WriteLine("Introduzca el nombre de la compañía:");
        CompanyName = Console.ReadLine();
        Console.WriteLine("Introduzca la dirección de la compañía:");
        CompanyAddress = Console.ReadLine();
        Console.WriteLine("Introduzca el teléfono de la compañía:");
        CompanyPhone = Console.ReadLine();
        Console.WriteLine("Introduzca el fax de la compañía:");
        CompanyFax = Console.ReadLine();
        Console.WriteLine("Introduzca la dirección web de la compañía:");
        CompanyWeb = Console.ReadLine();

        Console.WriteLine("Introduzca el primer nombre del manager:");
        ManagerFirstName = Console.ReadLine();
        Console.WriteLine("Introduzca el segundo nombre del manager:");
        ManagerLastName = Console.ReadLine();
        Console.WriteLine("Introduzca la edad del manager:");
        ManagerAge = Console.ReadLine();
        Console.WriteLine("Introduzca el teléfono del manager:");
        ManagerPhone = Console.ReadLine();

        Console.WriteLine("La compañía es: {0}, ubicada en {1}, cuyo teléfono es: {2}. También le puede mandar un fax a: {3} o visitar su página web: {4} ", CompanyName, CompanyAddress, CompanyPhone, CompanyFax, CompanyWeb);
        Console.WriteLine("El manager que la gestiona es: {0} {1}, de {2} años. Le podrá atender al número de teléfono {3}", ManagerFirstName, ManagerLastName, ManagerAge, ManagerPhone);
    */

    }
}
