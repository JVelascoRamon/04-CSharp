// See https://aka.ms/new-console-template for more information
//public GSM(string phoneModel, string manufacturer, int price, string owner, Battery battery = null, Display display = null)


//Battery batteryOne = new Battery ("Alcalina", 4, 5);

GSM mobileOne = new GSM("11s Plus", "iPhone", 234, "Paco", new Battery ("Lithium", 60, 25), new Display (6, 2048)); //

//Console.WriteLine(batteryOne.Model);
Console.WriteLine("Modelo del teléfono: " + mobileOne.PhoneModel);
Console.WriteLine("Fabricante: " + mobileOne.Manufacturer);
Console.WriteLine("Precio: " + mobileOne.Price + "€");
Console.WriteLine("Dueño: " + mobileOne.Owner + "\n");

Console.WriteLine("Modelo de batería: " + mobileOne.Battery.Model);
Console.WriteLine("Horas en espera de la batería: " + mobileOne.Battery.HoursIdle + "h");
Console.WriteLine("Horas en uso de la batería: " + mobileOne.Battery.HoursTalking + "h" + "\n");

Console.WriteLine("Tamaño de Display: " + mobileOne.Display.Size + "\"");
Console.WriteLine("Número de colores de Display: " + mobileOne.Display.NumberOfColours);
