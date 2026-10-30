// INDULÓ KÓD: a TODO részek kitöltése szükséges.
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
        // TODO 13.1: készítse el a feladatlap szerint.
        osszeh = 0; csere = 0;
    }
    public static void Kivalasztasos(int[] a, out long osszeh, out long csere)
    {
        // TODO 13.2: készítse el a feladatlap szerint.
        osszeh = 0; csere = 0;
    }
    public static void Beszuro(int[] a, out long osszeh, out long eltolas)
    {
        // TODO 13.3: készítse el a feladatlap szerint.
        osszeh = 0; eltolas = 0;
    }
}
