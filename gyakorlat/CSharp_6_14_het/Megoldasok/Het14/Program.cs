// TELJES OKTATÓI MEGOLDÁS
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
        long s = 0;
        for (int i = 0; i < a.Length; i++) s += a[i];
        return s;
    }
    public static int SikeresDarab(int[] a)
    {
        int d = 0;
        for (int i = 0; i < a.Length; i++) if (a[i] >= 50) d++;
        return d;
    }
    public static bool VanSikertelen(int[] a)
    {
        for (int i = 0; i < a.Length; i++) if (a[i] < 50) return true;
        return false;
    }
    public static int MinIndex(int[] a)
    {
        if (a.Length == 0) return -1;
        int m = 0;
        for (int i = 1; i < a.Length; i++) if (a[i] < a[m]) m = i;
        return m;
    }
    public static int MaxIndex(int[] a)
    {
        if (a.Length == 0) return -1;
        int m = 0;
        for (int i = 1; i < a.Length; i++) if (a[i] > a[m]) m = i;
        return m;
    }
    public static List<int> Sikeresek(int[] a)
    {
        List<int> e = new List<int>();
        for (int i = 0; i < a.Length; i++) if (a[i] >= 50) e.Add(a[i]);
        return e;
    }
    public static bool Tartalmaz(List<int> a, int k)
    {
        for (int i = 0; i < a.Count; i++) if (a[i] == k) return true;
        return false;
    }
    public static List<int> Metszet(int[] a, int[] b)
    {
        List<int> e = new List<int>(), masodik = new List<int>(b);
        for (int i = 0; i < a.Length; i++)
            if (Tartalmaz(masodik, a[i]) && !Tartalmaz(e, a[i])) e.Add(a[i]);
        return e;
    }
    public static List<int> Egyesites(int[] a, int[] b)
    {
        List<int> e = new List<int>();
        for (int i = 0; i < a.Length; i++) if (!Tartalmaz(e, a[i])) e.Add(a[i]);
        for (int i = 0; i < b.Length; i++) if (!Tartalmaz(e, b[i])) e.Add(b[i]);
        return e;
    }
    public static void Beszuro(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            int kulcs = a[i], j = i - 1;
            while (j >= 0 && a[j] > kulcs)
            { a[j + 1] = a[j]; j--; }
            a[j + 1] = kulcs;
        }
    }
    public static int Binaris(int[] a, int k)
    {
        int bal = 0, jobb = a.Length - 1;
        while (bal <= jobb)
        {
            int kozep = bal + (jobb - bal) / 2;
            if (a[kozep] == k) return kozep;
            if (a[kozep] < k) bal = kozep + 1;
            else jobb = kozep - 1;
        }
        return -1;
    }
    public static List<int> Osszefuttat(int[] a, int[] b)
    {
        List<int> e = new List<int>();
        int i = 0, j = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] <= b[j]) { e.Add(a[i]); i++; }
            else { e.Add(b[j]); j++; }
        }
        while (i < a.Length) { e.Add(a[i]); i++; }
        while (j < b.Length) { e.Add(b[j]); j++; }
        return e;
    }
}
