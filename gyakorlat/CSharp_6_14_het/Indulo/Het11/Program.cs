// INDULÓ KÓD: a TODO részek kitöltése szükséges.
using System;
namespace Het11;
public static class Program
{
    public static void Main()
    {
        int[] a = { 2, 5, 8, 12, 17, 23, 31 };
        Console.WriteLine("11. hét - Három lineáris keresés");
        foreach (int k in new int[] { 2, 17, 7, 40 })
        {
            int i = Linearis(a, k, out int l);
            int j = Strazsas(a, k, out int s);
            int r = RendezettLinearis(a, k, out int o);
            Console.WriteLine($"{k}: indexek {i}/{j}/{r}; vizsgált elemek {l}/{s}/{o}");
        }
    }
    public static int Linearis(int[] a, int keresett, out int vizsgalt)
    {
        // TODO 11.1: készítse el a feladatlap szerint.
        vizsgalt = 0; return -1;
    }
    public static int Strazsas(int[] a, int keresett, out int vizsgalt)
    {
        // TODO 11.2: készítse el a feladatlap szerint.
        vizsgalt = 0; return -1;
    }
    // Előfeltétel: nemcsökkenően rendezett bemenet.
    public static int RendezettLinearis(int[] a, int keresett, out int vizsgalt)
    {
        // TODO 11.3: készítse el a feladatlap szerint.
        vizsgalt = 0; return -1;
    }
}
