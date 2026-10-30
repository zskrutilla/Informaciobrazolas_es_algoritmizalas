// TELJES OKTATÓI MEGOLDÁS
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
        vizsgalt = 0;
        for (int i = 0; i < a.Length; i++)
        {
            vizsgalt++;
            if (a[i] == keresett) return i;
        }
        return -1;
    }
    public static int Strazsas(int[] a, int keresett, out int vizsgalt)
    {
        int[] masolat = new int[a.Length + 1];
        for (int j = 0; j < a.Length; j++) masolat[j] = a[j];
        masolat[a.Length] = keresett;
        int i = 0;
        while (masolat[i] != keresett) i++;
        vizsgalt = i + 1; // A strázsa vizsgálata is beleszámít.
        if (i < a.Length) return i;
        return -1;
    }
    // Előfeltétel: nemcsökkenően rendezett bemenet.
    public static int RendezettLinearis(int[] a, int keresett, out int vizsgalt)
    {
        vizsgalt = 0;
        for (int i = 0; i < a.Length; i++)
        {
            vizsgalt++;
            if (a[i] == keresett) return i;
            if (a[i] > keresett) return -1;
        }
        return -1;
    }
}
