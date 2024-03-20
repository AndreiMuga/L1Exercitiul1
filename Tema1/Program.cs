using System;

class Program
{
    public static void Main(string [] args)
    {

        /*Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
paralelipiped dreptunghic, va afisa volumul lui*/

        int lungimea;
        int latimea;
        int inaltimea;
        Console.WriteLine("Introduceti lungimea paralepipedului dreptunghic: ");
        lungimea = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Introduceti latimea paralepipedului dreptunghic: ");
        latimea = Convert.ToInt32( Console.ReadLine());
        Console.WriteLine("Introduceti inaltime paralelipipedului dreptunghic: ");
        inaltimea = Convert.ToInt32(Console.ReadLine());
        int rezultat = lungimea + latimea + inaltimea;
        Console.WriteLine();
        Console.WriteLine("Volumul paralelipipedului dreptunghiului este: " + rezultat);
    }

}
