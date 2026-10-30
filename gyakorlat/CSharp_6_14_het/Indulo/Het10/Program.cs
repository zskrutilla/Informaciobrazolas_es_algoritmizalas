// INDULÓ KÓD: a TODO részek kitöltése szükséges.
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
        // TODO 10.1: készítse el a feladatlap szerint.
        return false;
    }
    public static List<int> Metszet(int[] a, int[] b)
    {
        // TODO 10.2: készítse el a feladatlap szerint.
        return new List<int>();
    }
    public static List<int> Egyesites(int[] a, int[] b)
    {
        // TODO 10.3: készítse el a feladatlap szerint.
        return new List<int>();
    }
    // Előfeltétel: mindkét bemenet nemcsökkenően rendezett.
    // Az ismétlődések megmaradnak.
    public static List<int> Osszefuttat(int[] a, int[] b)
    {
        // TODO 10.4: készítse el a feladatlap szerint.
        return new List<int>();
    }
}
