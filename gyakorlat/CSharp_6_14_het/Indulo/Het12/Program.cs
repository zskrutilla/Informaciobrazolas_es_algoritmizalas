// INDULÓ KÓD: a TODO részek kitöltése szükséges.
using System;
using System.Collections.Generic;
namespace Het12;
public static class Program
{
    public static void Main()
    {
        List<int> a = new List<int> { 2, 5, 8, 12, 17, 23, 31 };
        Console.WriteLine("12. hét - Bináris keresés");
        foreach (int k in new int[] { 17, 7, 2, 31 })
        {
            int index = Binaris(a, k, out int lepes);
            Console.WriteLine($"{k}: index {index}, vizsgált középső elemek {lepes}");
        }
        List<int> hibas = new List<int> { 8, 2, 17, 5 };
        Console.WriteLine($"Hibás bemenet rendezett: {RendezettE(hibas)}");
        if (RendezettE(hibas))
            Console.WriteLine(Binaris(hibas, 8, out int lepes));
        else Console.WriteLine("A bináris keresés előfeltétele nem teljesül.");
    }
    public static bool RendezettE(List<int> a)
    {
        // TODO 12.1: készítse el a feladatlap szerint.
        return false;
    }
    // Előfeltétel: nemcsökkenő sorrend. Ismétlődésnél bármely találat jó.
    public static int Binaris(List<int> a, int keresett, out int lepes)
    {
        // TODO 12.2: készítse el a feladatlap szerint.
        lepes = 0; return -1;
    }
}
