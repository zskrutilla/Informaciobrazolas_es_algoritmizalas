// TELJES OKTATÓI MEGOLDÁS
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
        long osszeg = 0;
        for (int i = 0; i < a.Length; i++) osszeg += a[i];
        return osszeg;
    }
    public static int PozitivDarab(List<int> a)
    {
        int darab = 0;
        for (int i = 0; i < a.Count; i++)
            if (a[i] > 0) darab++;
        return darab;
    }
    public static bool VanNegativ(int[] a)
    {
        int i = 0;
        // Előbb a határt vizsgáljuk: a && rövidzáras kiértékelésű.
        while (i < a.Length && a[i] >= 0) i++;
        return i < a.Length;
    }
}
