// INDULÓ KÓD: a TODO sorokat egészítsd ki a feladatlap alapján.
using System;
Console.WriteLine("2. hét - Számrendszer átváltó");
int szam = EgeszBeolvas("Tízes alapú egész (0..255): ", 0, 255);
Console.WriteLine($"Bináris: {Tizesbol(szam, 2)}");
Console.WriteLine($"Oktális: {Tizesbol(szam, 8)}");
Console.WriteLine($"Decimális: {Tizesbol(szam, 10)}");
Console.WriteLine($"Hexadecimális: {Tizesbol(szam, 16)}");

Console.WriteLine("Átváltás két választott alap között");
int forrasAlap = AlapBeolvas();
string bemenet = SzamBeolvas("Átváltandó szám: ", forrasAlap, 255);
int celAlap = AlapBeolvas();
int tizesErtek = Tizesbe(bemenet, forrasAlap);
string kimenet = "?"; // TODO 2.4: hívd meg a Tizesbol függvényt
Console.WriteLine($"Tízes érték: {tizesErtek}");
Console.WriteLine($"Célrendszerbeli alak: {kimenet}");

static string Tizesbol(int szam, int alap)
{
    const string jegyek = "0123456789ABCDEF";
    if (szam == 0) return "0";
    string eredmeny = "";
    while (szam > 0)
    {
        int maradek = 0; // TODO 2.2: szam osztási maradéka az alap szerint
        eredmeny = jegyek[maradek] + eredmeny;
        szam = szam / alap;
    }
    return eredmeny;
}

static int Tizesbe(string szoveg, int alap)
{
    const string jegyek = "0123456789ABCDEF";
    int eredmeny = 0;
    foreach (char c in szoveg)
    {
        int jegy = jegyek.IndexOf(c);
        eredmeny = eredmeny + jegy; // TODO 2.3: a korábbi értéket előbb szorozd az alappal
    }
    return eredmeny;
}

// KÉSZ SEGÉDRÉSZ: a beolvasás részleteit most nem kell megírnod.
static int EgeszBeolvas(string kerdes, int minimum, int maximum)
{
    while (true)
    {
        Console.Write(kerdes);
        string szoveg = Console.ReadLine() ?? "";
        if (int.TryParse(szoveg, out int ertek) &&
            ertek >= minimum && ertek <= maximum)
            return ertek;
        Console.WriteLine($"Egész számot adj meg {minimum} és {maximum} között!");
    }
}

static int AlapBeolvas()
{
    while (true)
    {
        int alap = EgeszBeolvas("Számrendszer alapja (2, 8, 10, 16): ", 2, 16);
        if (alap == 2 || alap == 8 || alap == 10 || alap == 16)
            return alap;
        Console.WriteLine("Csak a 2, 8, 10 és 16 alap választható.");
    }
}

static string SzamBeolvas(string kerdes, int alap, int maximum)
{
    const string jegyek = "0123456789ABCDEF";
    while (true)
    {
        Console.Write(kerdes);
        string szoveg = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
        bool helyes = szoveg.Length > 0 && szoveg.Length <= 16;
        int ertek = 0;
        foreach (char c in szoveg)
        {
            int jegy = jegyek.IndexOf(c);
            if (jegy < 0 || jegy >= alap) { helyes = false; break; }
            ertek = ertek * alap + jegy;
            if (ertek > maximum) { helyes = false; break; }
        }
        if (helyes) return szoveg;
        Console.WriteLine($"Az adott alapban 0..{maximum} értékű számot adj meg!");
    }
}
