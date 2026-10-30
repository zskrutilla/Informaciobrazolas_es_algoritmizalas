// TELJES OKTATÓI MEGOLDÁS
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
        if (pont < 0 || pont > 100) return "Érvénytelen";
        if (pont >= 50) return "Sikeres";
        return "Sikertelen";
    }
    // Érvénytelen árra -1. Egyébként 10000 Ft alatt 1500 Ft szállítás.
    public static int Vegosszeg(int termekAr)
    {
        if (termekAr < 0 || termekAr > 1000000) return -1;
        if (termekAr < 10000) return termekAr + 1500;
        return termekAr;
    }
    // Előfeltétel: 0 <= osszesPerc <= 1000000.
    public static string IdoSzoveg(int osszesPerc)
    {
        int ora = osszesPerc / 60;
        int perc = osszesPerc % 60;
        return $"{ora}:{perc:D2}";
    }
}
