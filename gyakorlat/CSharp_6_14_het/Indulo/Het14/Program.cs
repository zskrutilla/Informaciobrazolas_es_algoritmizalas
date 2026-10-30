// INDULÓ KÓD: a TODO részek kitöltése szükséges.
using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace Het14;
public static class Program
{
    public static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;
        string kurzus = "Alapok ő";
        int[] a = { 62, 48, 100, 75, 62, 0 };
        int[] b = { 50, 62, 90, 0 };
        Console.WriteLine("14. hét - Eredménykimutatás két csoportból");
        Console.WriteLine($"Kurzus: {kurzus}; UTF-8 bájt: {Encoding.UTF8.GetByteCount(kurzus)}");
        Console.WriteLine($"A csoport: {string.Join(", ", a)}");
        Console.WriteLine($"Összeg: {Osszeg(a)}; sikeres: {SikeresDarab(a)}");
        if (a.Length > 0) Console.WriteLine($"Átlag: {(double)Osszeg(a) / a.Length:F2}");
        else Console.WriteLine("Nincs átlag.");
        int min = MinIndex(a), max = MaxIndex(a);
        if (min >= 0) Console.WriteLine($"Minimum: {a[min]}; maximum: {a[max]}");
        else Console.WriteLine("Nincs szélsőérték.");
        Console.WriteLine($"Van sikertelen: {VanSikertelen(a)}");
        Console.WriteLine($"Sikeres pontok: {string.Join(", ", Sikeresek(a))}");
        Console.WriteLine($"Közös pontok: {string.Join(", ", Metszet(a, b))}");
        Console.WriteLine($"Egyesített ponthalmaz: {string.Join(", ", Egyesites(a, b))}");
        int[] rendezett = (int[])a.Clone();
        Beszuro(rendezett);
        Console.WriteLine($"Rendezett A: {string.Join(", ", rendezett)}");
        Console.WriteLine($"75 indexe a rendezett A-ban: {Binaris(rendezett, 75)}");
        Console.WriteLine($"49 indexe a rendezett A-ban: {Binaris(rendezett, 49)}");
        int[] rendezettB = (int[])b.Clone();
        Beszuro(rendezettB);
        Console.WriteLine($"Összefuttatva: {string.Join(", ", Osszefuttat(rendezett, rendezettB))}");
        byte allapot = 0;
        if (a.Length > 0) allapot = (byte)(allapot | 1);
        if (VanSikertelen(a)) allapot = (byte)(allapot | 2);
        Console.WriteLine($"Állapot: {allapot}, binárisan: {Convert.ToString(allapot, 2).PadLeft(8, '0')}");
        Console.WriteLine($"Ponttömbök nyers adata: {(a.Length + b.Length) * 4} bájt");
    }
    // Előfeltétel: minden pont 0 és 100 közötti; az üres tömb megengedett.
    public static long Osszeg(int[] a)
    {
        // TODO 14.1a: készítse el a feladatlap szerint.
        return 0;
    }
    public static int SikeresDarab(int[] a)
    {
        // TODO 14.1b: készítse el a feladatlap szerint.
        return 0;
    }
    public static bool VanSikertelen(int[] a)
    {
        // TODO 14.1c: készítse el a feladatlap szerint.
        return false;
    }
    public static int MinIndex(int[] a)
    {
        // TODO 14.2a: készítse el a feladatlap szerint.
        return -1;
    }
    public static int MaxIndex(int[] a)
    {
        // TODO 14.2b: készítse el a feladatlap szerint.
        return -1;
    }
    public static List<int> Sikeresek(int[] a)
    {
        // TODO 14.2c: készítse el a feladatlap szerint.
        return new List<int>();
    }
    public static bool Tartalmaz(List<int> a, int k)
    {
        for (int i = 0; i < a.Count; i++) if (a[i] == k) return true;
        return false;
    }
    public static List<int> Metszet(int[] a, int[] b)
    {
        // TODO 14.3a: készítse el a feladatlap szerint.
        return new List<int>();
    }
    public static List<int> Egyesites(int[] a, int[] b)
    {
        // TODO 14.3b: készítse el a feladatlap szerint.
        return new List<int>();
    }
    public static void Beszuro(int[] a)
    {
        // TODO 14.4a: készítse el a feladatlap szerint.
        // A rendezés még nem készült el.
    }
    public static int Binaris(int[] a, int k)
    {
        // TODO 14.4b: készítse el a feladatlap szerint.
        return -1;
    }
    public static List<int> Osszefuttat(int[] a, int[] b)
    {
        // TODO 14.5: készítse el a feladatlap szerint.
        return new List<int>();
    }
}
