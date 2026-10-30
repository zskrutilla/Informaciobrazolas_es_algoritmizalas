// OKTATÓI MEGOLDÁS: a FELADAT jelölések a feladatlap részeire utalnak.
using System;
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
Console.WriteLine("4. hét - Egy bájt több értelmezése");
byte ertek = (byte)EgeszBeolvas("Bájt értéke (0..255): ", 0, 255);
int bitIndex = EgeszBeolvas("Vizsgált bit sorszáma (0..7): ", 0, 7);
int maszk = 1 << bitIndex; // FELADAT 4.1a
bool beVanKapcsolva = (ertek & maszk) != 0; // FELADAT 4.1b
byte bekapcsolt = (byte)(ertek | maszk); // FELADAT 4.1c
byte kikapcsolt = (byte)(ertek & ~maszk); // FELADAT 4.1d
byte valtott = (byte)(ertek ^ maszk); // FELADAT 4.1e
byte balra = unchecked((byte)(ertek << 1)); // FELADAT 4.1f
Console.WriteLine($"Eredeti minta: {Binaris8(ertek)}");
Console.WriteLine($"A vizsgált bit 1: {beVanKapcsolva}");
Console.WriteLine($"Bekapcsolás: {Binaris8(bekapcsolt)} = {bekapcsolt}");
Console.WriteLine($"Kikapcsolás: {Binaris8(kikapcsolt)} = {kikapcsolt}");
Console.WriteLine($"Átbillentés: {Binaris8(valtott)} = {valtott}");
Console.WriteLine($"Balra tolás, alsó 8 bit: {Binaris8(balra)} = {balra}");

sbyte elojeles = unchecked((sbyte)ertek); // FELADAT 4.2
Console.WriteLine($"Ugyanaz a 8 bit előjel nélkül: {ertek}, előjellel: {elojeles}");

long bajt = EgeszBeolvas("Fájl mérete bájtban (0..1000000000): ", 0, 1_000_000_000);
long bitDarab = bajt * 8; // FELADAT 4.3a
double kB = bajt / 1000.0; // FELADAT 4.3b
double KiB = bajt / 1024.0; // FELADAT 4.3c
Console.WriteLine($"Bit: {bitDarab}, kB: {kB}, KiB: {KiB}");

Console.WriteLine("Túlcsordulás megfigyelése");
byte a = 250;
int osszeg = a + 10;
byte csonkolt = unchecked((byte)osszeg); // FELADAT 4.4a
Console.WriteLine($"int összeg: {osszeg}, unchecked byte: {csonkolt}");
// Kész bemutató: a try/catch szerkezetet most elég megfigyelni.
try
{
    byte ellenorzott = checked((byte)osszeg);
    Console.WriteLine(ellenorzott);
}
catch (OverflowException)
{
    Console.WriteLine("checked byte: OverflowException");
}
sbyte maximum = 127;
sbyte kovetkezo = unchecked((sbyte)(maximum + 1)); // FELADAT 4.4b
Console.WriteLine($"127 + 1 nyolcbites előjeles csonkolás után: {kovetkezo}");

static string Binaris8(byte ertek)
{
    return Convert.ToString(ertek, 2).PadLeft(8, '0');
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

