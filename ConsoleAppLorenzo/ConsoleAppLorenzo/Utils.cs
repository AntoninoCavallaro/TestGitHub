namespace Web;

public static class Utils
{
    public static double TeoremaPitagora(double bSide, double hSide)
    {
        //esercizio 1 - calcolo ipotenusa
        Console.WriteLine("Inserisci la base del triangolo rettangolo:");
        bSide = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Inserisci l'altezza del triangolo rettangolo:");
        hSide = Convert.ToDouble(Console.ReadLine());

        double hypotenuse = Math.Sqrt(Math.Pow(bSide, 2) + Math.Pow(hSide, 2));

        Console.WriteLine($"L'ipotenusa del triangolo rettangolo è: {hypotenuse}");
        return hypotenuse;
    }
    
}