
using ConsoleAppLorenzo;
using static ConsoleAppLorenzo.ArrayUtils;


int[] a = { 9, 5, 6, 3, 1, 7, 5, 8, 9, 1 };
Console.WriteLine(ArrayUtils.FindIndexOfMin(a));

//// Metodo per invertire gli elementi di un array
//static int[] ReverseArray(int[] array)
//{
//    int[] reverse = new int[array.Length];
//    for (int i = 0; i < array.Length; i++)
//    {
//        reverse[i] = array[array.Length - 1 - i];
//    }
//    return reverse;
//}

//// Metodo per stampare gli elementi di un array
//static void PrintArray(int[] array)
//{
//    foreach (int i in array)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine();
//}

//int FindFirstIndexOfElement(int[] array, int element)
//{
//    for (int i = 0; i < array.Length; i++)
//    {
//        if (array[i] == element)
//            return i;
//    }
//    return -1;

//}

//esercizio 1 - calcolo ipotenusa
//Console.WriteLine("Inserisci la base del triangolo rettangolo:");
//double bSide = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Inserisci l'altezza del triangolo rettangolo:");
//double hSide = Convert.ToDouble(Console.ReadLine());

//double hypotenuse = Math.Sqrt(Math.Pow(bSide, 2) + Math.Pow(hSide, 2));

//Console.WriteLine($"L'ipotenusa del triangolo rettangolo è: {hypotenuse}");


// esercizio 2 - solo numeri positivi interi

//do
//{
//    Console.Write("Inserisci un numero intero positivo: ");
//    bool isValid = uint.TryParse(Console.ReadLine(), out uint number);
//    if(isValid && number % 2 == 0)
//    {
//        Console.WriteLine("Bravo, hai inserito un numero intero positivo");
//        break;
//    }
//    else
//        Console.WriteLine("Errore: Devi inserire un numero intero positivo. Riprova:");

//} while (true);


//int[] intsIndex = { 1, 2, 3 };
//int indexOf2 = FindFirstIndexOfElement(intsIndex, 2);

//    // Inizializzazione corretta dell'array
//    int[] ints = { 1, 2, 3 };

//    // Chiamata al metodo PrintArray
//    PrintArray(ints);
//    Console.WriteLine("___");

//    // Chiamata al metodo ReverseArray
//    int[] reverse = ReverseArray(ints);

//    // Stampa dell'array invertito
//    PrintArray(reverse);



//var random = new Random();
//int solution = random.Next(0, 101);
//int guess;

//Console.WriteLine("Indovina un numero da 0 a 100");

//do
//{
//    var readNumber = Console.ReadLine();
//    guess = Convert.ToInt32(readNumber);

//    if (guess > solution)
//        Console.WriteLine("Troppo alto");
//    else if (guess < solution)
//        Console.WriteLine("Troppo basso");
//} while (guess != solution);

//if (guess == solution)
//    Console.WriteLine("Complimenti, sei un genio!");
//else
//    Console.WriteLine("Mi dispiace, hai perso..");






