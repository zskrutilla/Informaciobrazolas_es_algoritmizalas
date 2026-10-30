// INDULÓ KÓD: a TODO részek kitöltése szükséges.
using System;
namespace Het7;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("7. hét - Feladatelemzés és algoritmusterv");
        foreach (int pont in new int[] { 0, 49, 50, 62, 100, -1, 101 })
            Console.WriteLine($"{pont} pont: {PontMinosites(pont)}");
        foreach (int ar in new int[] { 0, 9999, 10000, -1 })
            Console.WriteLine($"{ar} Ft rendelés végösszege: {Vegosszeg(ar)} Ft");
        foreach (int perc in new int[] { 0, 59, 60, 125 })
            Console.WriteLine($"{perc} perc = {IdoSzoveg(perc)}");
        Console.WriteLine("Írjon be egy 0 és 100 közötti pontszámot!");
        string? sor = Console.ReadLine();
        if (sor != null)
        {
            if (int.TryParse(sor, out int pont))
                Console.WriteLine(PontMinosites(pont));
            else Console.WriteLine("Hibás számformátum.");
        }
    }
    // Érvényes pontszám: 0..100; 50-től sikeres.
    public static string PontMinosites(int pont)
    {
        // TODO 7.1: készítse el a feladatlap szerint.
        return "Nincs kitöltve";
    }
    // Érvénytelen árra -1. Egyébként 10000 Ft alatt 1500 Ft szállítás.
    public static int Vegosszeg(int termekAr)
    {
        // TODO 7.2: készítse el a feladatlap szerint.
        return -1;
    }
    // Előfeltétel: 0 <= osszesPerc <= 1000000.
    public static string IdoSzoveg(int osszesPerc)
    {
        // TODO 7.3: készítse el a feladatlap szerint.
        return "Nincs kitöltve";
    }
}
