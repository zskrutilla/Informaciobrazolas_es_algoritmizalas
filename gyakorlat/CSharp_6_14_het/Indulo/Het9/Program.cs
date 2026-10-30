// INDULÓ KÓD: a TODO részek kitöltése szükséges.
using System;
using System.Collections.Generic;
namespace Het9;
public static class Program
{
    public static void Main()
    {
        int[] a = { 7, 2, 9, 2, -4, 12, 5 };
        Console.WriteLine("9. hét - Kiválasztás és szélsőértékek");
        Console.WriteLine($"Első páros indexe: {ElsoParosIndex(a)}");
        Console.WriteLine($"Pozitív párosak: {string.Join(", ", PozitivParosak(a))}");
        int min = MinIndex(a), max = MaxIndex(a);
        if (min >= 0) Console.WriteLine($"Minimum: {a[min]}, index: {min}");
        else Console.WriteLine("Nincs minimum.");
        if (max >= 0) Console.WriteLine($"Maximum: {a[max]}, index: {max}");
        else Console.WriteLine("Nincs maximum.");
        Console.WriteLine($"Páratlanok között: {ElsoParosIndex(new int[] { 1, 3 })}");
        Console.WriteLine($"Üres minimumindex: {MinIndex(new int[0])}");
    }
    // A kiválasztás előfeltétele itt garantált; a hívó ellenőrzi.
    public static int KivalasztParosIndex(int[] a)
    {
        // TODO 9.1: készítse el a feladatlap szerint.
        return 0;
    }
    public static int ElsoParosIndex(int[] a)
    {
        // KÉSZ ELŐFELTÉTEL ELLENŐRZÉS: sikertelen esetben -1.
        for (int i = 0; i < a.Length; i++)
            if (a[i] % 2 == 0) return KivalasztParosIndex(a);
        return -1;
    }
    public static List<int> PozitivParosak(int[] a)
    {
        // TODO 9.2: készítse el a feladatlap szerint.
        return new List<int>();
    }
    public static int MinIndex(int[] a)
    {
        // TODO 9.3: készítse el a feladatlap szerint.
        return -1;
    }
    public static int MaxIndex(int[] a)
    {
        // TODO 9.4: készítse el a feladatlap szerint.
        return -1;
    }
}
