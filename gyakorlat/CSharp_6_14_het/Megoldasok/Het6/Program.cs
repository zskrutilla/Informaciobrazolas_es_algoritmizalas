// TELJES OKTATÓI MEGOLDÁS
using System;
using System.Text;
namespace Het6;
public static class Program
{
    public static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("6. hét - Karakterek és algoritmusleírás");
        foreach (char c in new char[] { 'A', '0', 'á', 'ő' })
            Console.WriteLine($"{c}: {(int)c}, U+{(int)c:X4}, ASCII: {AsciiE(c)}");
        foreach (string s in new string[] { "ABC", "ár", "A😀" })
        {
            Console.WriteLine($"{s}: UTF-16 egység: {s.Length}, " +
                $"kódpont: {KodpontDarab(s)}, UTF-8 bájt: {Utf8BajtDarab(s)}");
        }
        string magyar = "ár";
        byte[] ascii = Encoding.ASCII.GetBytes(magyar);
        byte[] utf8 = Encoding.UTF8.GetBytes(magyar);
        Console.WriteLine($"ASCII visszaolvasva: {Encoding.ASCII.GetString(ascii)}");
        Console.WriteLine($"UTF-8 visszaolvasva: {Encoding.UTF8.GetString(utf8)}");
        Console.WriteLine($"Nagyobbik(7, 3): {Nagyobbik(7, 3)}");
        Console.WriteLine($"Nagyobbik(4, 4): {Nagyobbik(4, 4)}");
    }
    public static bool AsciiE(char c)
    {
        return c <= 127;
    }
    public static int Utf8BajtDarab(string szoveg)
    {
        return Encoding.UTF8.GetByteCount(szoveg);
    }
    // KÉSZ DEMÓ: egy Rune egy Unicode skalárértéket képvisel.
    // A példák érvényes Unicode szövegek. Ez nem grafémaszámlálás.
    public static int KodpontDarab(string szoveg)
    {
        int darab = 0;
        foreach (Rune r in szoveg.EnumerateRunes()) darab++;
        return darab;
    }
    public static int Nagyobbik(int a, int b)
    {
        if (a >= b) return a;
        return b;
    }
}
