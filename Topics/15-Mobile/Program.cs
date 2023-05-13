
GSM mobileOne = new GSM("iPhone 11", "Apple", 234, "Paco",
                new Call(new DateTime(2023, 5, 13, 13, 20, 0), 555666777, 12), 
                new Battery ("2.500mAh", 60, 25, BatteryType.LiIon), 
                new Display (6, 256)); 

GSM mobileTwo = new GSM("Galaxy S10", "Samsung"); 

Console.WriteLine(mobileOne);
Console.WriteLine(mobileTwo);
//Console.WriteLine(GSM.IPhone4s);//Así llamo directamente a la propiedad IPhone4s que está establecida en el GSM





/*
    // Ejercicio 11, 12 y 13. Clase 12/05/2023

double x = 4;
double y = 5;
double z = 3;

Euclidean3D A = new Euclidean3D (x, y, z);
Euclidean3D B = new Euclidean3D (4, 5, 1);

Console.WriteLine("A " + A);
Console.WriteLine("O " + Euclidean3D.Origin);
Console.WriteLine(string.Format("The distance between A and B is: {0}", DistanceClass.Distance (A, B)));

*/