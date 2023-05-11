using System;

class LogicalOperators
{
    static void Main()
    {
    /* 
        bool a = true;
        bool b = false;
        Console.WriteLine(a && b); // False
        Console.WriteLine(a || b); // True
        Console.WriteLine(a ^ b); // True
        Console.WriteLine(!b); // True
        Console.WriteLine(b || true); // True
        Console.WriteLine(b && true); // False
        Console.WriteLine(a || true); // True
        Console.WriteLine(a && true); // True
        Console.WriteLine(!a); // False
        Console.WriteLine((5 > 7) ^ (a == b)); // False
    */

    // Ejercicios de las slides de operators and expressions

    // Ejercicio 1
    int number1 = 36;
    Console.WriteLine((number1 % 2 == 0)? "Par" : "Impar" );

    // Ejercicio 2
    int number2 = 36;
    Console.WriteLine((number2 % 5 == 0 && number2 % 7 == 0)? "Sí se puede" : "No se puede" );

    // Ejercicio 3
    int width = 7;
    int height = 4;
    Console.WriteLine($"Área del rectángulo: {width * height} cm2" );

    // Ejercicio 4
    int number4 = 3573754;
    int millar = number4 / 1000; // Obtiene los dígitos a partir del cuarto
    int centena = number4 / 100; // Obtiene los dígitos a partir del tercero
    centena = centena - millar * 10; // Le quita a la centena los dígitos de millar en adelante
    Console.WriteLine((centena % 7 == 0)? "El tercer dígito es un 7" : "El tercer dígito NO es un 7" );

    // int digito = (number4 / 100) % 10; // Esta sería otra forma de obtener el tercer dígito del número
    
    // Ejercicio 5
    int number5 = 6; 
    bool isBit3Set = (number5 & (1 << 3)) != 0; // check if bit 3 is set (true) or not (false). 1 << 3: Este es un operador de desplazamiento a la izquierda que toma el valor 1 (que en binario es 00000001) y lo desplaza 3 lugares a la izquierda
    Console.WriteLine(isBit3Set); // imprime el valor binario en la consola
    

    }
}
