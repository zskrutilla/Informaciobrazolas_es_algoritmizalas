// OKTATÓI MEGOLDÁS: a FELADAT jelölések a feladatlap részeire utalnak.
using System;
Console.WriteLine("3. hét - Műveletek számjegyenként");
int alap = AlapBeolvas();
string a = SzamBeolvas("Első szám (tízes értéke 0..255): ", alap, 255);
int aErtek = Tizesbe(a, alap);
int bMaximum = Math.Min(aErtek, 15);
Console.WriteLine($"A második szám tízes értéke legfeljebb {bMaximum} lehet.");
string b = SzamBeolvas("Második szám: ", alap, bMaximum);
int bErtek = Tizesbe(b, alap);

Console.WriteLine($"Összeg: {Osszead(a, b, alap)}");
Console.WriteLine($"Különbség: {Kivon(a, b, alap)}");
Console.WriteLine($"Szorzat: {Szoroz(a, bErtek, alap)}");
Console.WriteLine($"Tízes ellenőrzés: {aErtek + bErtek}, {aErtek - bErtek}, {aErtek * bErtek}");

Console.WriteLine("Komplemensek 8 biten");
int pozitiv = EgeszBeolvas("Pozitív szám (1..127): ", 1, 127);
string bitek = Convert.ToString(pozitiv, 2).PadLeft(8, '0');
string egyes = "";
foreach (char bit in bitek)
{
    if (bit == '0') egyes += '1'; // FELADAT 3.4a
    else egyes += '0';
}
string kettes = Osszead(egyes, "1", 2); // FELADAT 3.4b
Console.WriteLine($"Pozitív minta: {bitek}");
Console.WriteLine($"Egyes komplemens: {egyes}");
Console.WriteLine($"Kettes komplemens: {kettes}");
Console.WriteLine($"A kettes komplemensű minta itt a {-pozitiv} értéket jelöli.");

static string Osszead(string a, string b, int alap)
{
    const string jegyek = "0123456789ABCDEF";
    int i = a.Length - 1;
    int j = b.Length - 1;
    int atvitel = 0;
    string eredmeny = "";
    while (i >= 0 || j >= 0 || atvitel > 0)
    {
        int elso = 0, masodik = 0;
        if (i >= 0) elso = jegyek.IndexOf(a[i]);
        if (j >= 0) masodik = jegyek.IndexOf(b[j]);
        int aktualis = elso + masodik + atvitel; // FELADAT 3.1a
        int ujJegy = aktualis % alap; // FELADAT 3.1b
        atvitel = aktualis / alap; // FELADAT 3.1c
        eredmeny = jegyek[ujJegy] + eredmeny;
        i--;
        j--;
    }
    return Tisztit(eredmeny);
}

static string Kivon(string a, string b, int alap)
{
    // Feltétel: a legalább akkora értékű, mint b.
    const string jegyek = "0123456789ABCDEF";
    int i = a.Length - 1;
    int j = b.Length - 1;
    int kolcson = 0;
    string eredmeny = "";
    while (i >= 0)
    {
        int elso = jegyek.IndexOf(a[i]);
        int masodik = 0;
        if (j >= 0) masodik = jegyek.IndexOf(b[j]);
        int kulonbseg = elso - masodik - kolcson; // FELADAT 3.2
        if (kulonbseg < 0)
        {
            kulonbseg += alap;
            kolcson = 1;
        }
        else kolcson = 0;
        eredmeny = jegyek[kulonbseg] + eredmeny;
        i--;
        j--;
    }
    return Tisztit(eredmeny);
}

static string Szoroz(string a, int ismetles, int alap)
{
    // Kezdő algoritmus: ismételt összeadás a választott számrendszerben.
    string eredmeny = "0";
    for (int i = 0; i < ismetles; i++)
        eredmeny = Osszead(eredmeny, a, alap); // FELADAT 3.3
    return eredmeny;
}

static string Tisztit(string s)
{
    string tiszta = s.TrimStart('0');
    if (tiszta == "") return "0";
    return tiszta;
}
static int Tizesbe(string szoveg, int alap)
{
    const string jegyek = "0123456789ABCDEF";
    int eredmeny = 0;
    foreach (char c in szoveg)
    {
        int jegy = jegyek.IndexOf(c);
        eredmeny = eredmeny * alap + jegy;
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
