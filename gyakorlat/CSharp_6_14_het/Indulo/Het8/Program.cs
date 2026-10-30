// INDULÓ KÓD: a TODO részek kitöltése szükséges.
using System;
using System.Collections.Generic;
namespace Het8;
public static class Program
{
    public static void Main()
    {
        int[] adatok = { 12, -3, 0, 7, 12, -8, 5 };
        List<int> lista = new List<int>(adatok);
        Console.WriteLine("8. hét - Összegzés, megszámlálás, eldöntés");
        Console.WriteLine($"Adatok: {string.Join(", ", adatok)}");
        Console.WriteLine($"Összeg: {Osszeg(adatok)}");
        Console.WriteLine($"Pozitív elemek: {PozitivDarab(lista)}");
        Console.WriteLine($"Van negatív: {VanNegativ(adatok)}");
        if (adatok.Length > 0)
            Console.WriteLine($"Átlag: {(double)Osszeg(adatok) / adatok.Length}");
        else Console.WriteLine("Üres sorozatnak itt nincs átlaga.");
        int[] ures = new int[0];
        Console.WriteLine($"Üres: összeg {Osszeg(ures)}, negatív {VanNegativ(ures)}");
    }
    public static long Osszeg(int[] a)
    {
        // TODO 8.1: készítse el a feladatlap szerint.
        return 0;
    }
    public static int PozitivDarab(List<int> a)
    {
        // TODO 8.2: készítse el a feladatlap szerint.
        return 0;
    }
    public static bool VanNegativ(int[] a)
    {
        // TODO 8.3: készítse el a feladatlap szerint.
        return false;
    }
}
