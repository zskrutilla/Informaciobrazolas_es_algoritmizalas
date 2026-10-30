// TELJES OKTATÓI MEGOLDÁS
using System;
using System.Collections.Generic;
namespace Het10;
public static class Program
{
    public static void Main()
    {
        int[] a = { 3, 1, 3, 5 }, b = { 3, 4, 4, 1 };
        Console.WriteLine("10. hét - Metszet, egyesítés, összefuttatás");
        Console.WriteLine($"Metszet: {string.Join(", ", Metszet(a, b))}");
        Console.WriteLine($"Egyesítés: {string.Join(", ", Egyesites(a, b))}");
        int[] x = { 1, 3, 3, 8 }, y = { 2, 3, 9 };
        Console.WriteLine($"Összefuttatás: {string.Join(", ", Osszefuttat(x, y))}");
    }
    public static bool Tartalmaz(List<int> a, int keresett)
    {
        for (int i = 0; i < a.Count; i++)
            if (a[i] == keresett) return true;
        return false;
    }
    public static List<int> Metszet(int[] a, int[] b)
    {
        List<int> eredmeny = new List<int>();
        List<int> masodik = new List<int>(b);
        for (int i = 0; i < a.Length; i++)
            if (Tartalmaz(masodik, a[i]) && !Tartalmaz(eredmeny, a[i]))
                eredmeny.Add(a[i]);
        return eredmeny;
    }
    public static List<int> Egyesites(int[] a, int[] b)
    {
        List<int> eredmeny = new List<int>();
        for (int i = 0; i < a.Length; i++)
            if (!Tartalmaz(eredmeny, a[i])) eredmeny.Add(a[i]);
        for (int i = 0; i < b.Length; i++)
            if (!Tartalmaz(eredmeny, b[i])) eredmeny.Add(b[i]);
        return eredmeny;
    }
    // Előfeltétel: mindkét bemenet nemcsökkenően rendezett.
    // Az ismétlődések megmaradnak.
    public static List<int> Osszefuttat(int[] a, int[] b)
    {
        List<int> eredmeny = new List<int>();
        int i = 0, j = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] <= b[j]) { eredmeny.Add(a[i]); i++; }
            else { eredmeny.Add(b[j]); j++; }
        }
        while (i < a.Length) { eredmeny.Add(a[i]); i++; }
        while (j < b.Length) { eredmeny.Add(b[j]); j++; }
        return eredmeny;
    }
}
