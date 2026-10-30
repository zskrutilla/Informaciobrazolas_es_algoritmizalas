// TELJES OKTATÓI MEGOLDÁS
using System;
namespace Het13;
public static class Program
{
    public static void Main()
    {
        Console.WriteLine("13. hét - Három rendezés");
        foreach (int[] eredeti in new int[][] {
            new int[] { 5, 1, 4, 2 }, new int[] { 1, 2, 4, 5 },
            new int[] { 5, 4, 2, 1 }, new int[] { 2, 2, 1, 1 } })
        {
            int[] a = (int[])eredeti.Clone();
            int[] b = (int[])eredeti.Clone();
            int[] c = (int[])eredeti.Clone();
            Buborek(a, out long ob, out long cs);
            Kivalasztasos(b, out long ok, out long csk);
            Beszuro(c, out long oi, out long elt);
            Console.WriteLine($"Bemenet: {string.Join(", ", eredeti)}");
            Console.WriteLine($"Buborék: {string.Join(", ", a)}; összeh. {ob}; csere {cs}");
            Console.WriteLine($"Kivál.: {string.Join(", ", b)}; összeh. {ok}; csere {csk}");
            Console.WriteLine($"Beszúró: {string.Join(", ", c)}; összeh. {oi}; eltolás {elt}");
        }
    }
    public static void Buborek(int[] a, out long osszeh, out long csere)
    {
        osszeh = 0; csere = 0;
        for (int veg = a.Length - 1; veg > 0; veg--)
        {
            bool voltCsere = false;
            for (int i = 0; i < veg; i++)
            {
                osszeh++;
                if (a[i] > a[i + 1])
                {
                    int seged = a[i]; a[i] = a[i + 1]; a[i + 1] = seged;
                    csere++; voltCsere = true;
                }
            }
            if (!voltCsere) break; // Az egész rendezés befejezhető.
        }
    }
    public static void Kivalasztasos(int[] a, out long osszeh, out long csere)
    {
        osszeh = 0; csere = 0;
        for (int i = 0; i < a.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                osszeh++;
                if (a[j] < a[min]) min = j;
            }
            if (min != i)
            {
                int seged = a[i]; a[i] = a[min]; a[min] = seged;
                csere++;
            }
        }
    }
    public static void Beszuro(int[] a, out long osszeh, out long eltolas)
    {
        osszeh = 0; eltolas = 0;
        for (int i = 1; i < a.Length; i++)
        {
            int kulcs = a[i], j = i - 1;
            while (j >= 0)
            {
                osszeh++;
                if (a[j] <= kulcs) break;
                a[j + 1] = a[j]; eltolas++; j--;
            }
            a[j + 1] = kulcs;
        }
    }
}
