
Console.WriteLine("Inserisci la base del triangolo rettangolo:");
double bSide = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Inserisci l'altezza del triangolo rettangolo:");
double hSide = Convert.ToDouble(Console.ReadLine());

double hypotenuse = Math.Sqrt(Math.Pow(bSide, 2) + Math.Pow(hSide, 2));

Console.WriteLine($"L'ipotenusa del triangolo rettangolo è: {hypotenuse}");

