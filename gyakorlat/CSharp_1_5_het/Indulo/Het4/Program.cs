// INDULÓ KÓD: a TODO sorokat egészítsd ki a feladatlap alapján.
using System;
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
Console.WriteLine("4. hét - Egy bájt több értelmezése");
byte ertek = (byte)EgeszBeolvas("Bájt értéke (0..255): ", 0, 255);
int bitIndex = EgeszBeolvas("Vizsgált bit sorszáma (0..7): ", 0, 7);
int maszk = 0; // TODO 4.1a: az 1-et told balra bitIndex hellyel
bool beVanKapcsolva = false; // TODO 4.1b: ÉS művelet és összehasonlítás
byte bekapcsolt = ertek; // TODO 4.1c: VAGY művelet
byte kikapcsolt = ertek; // TODO 4.1d: ÉS a megfordított maszkkal
byte valtott = ertek; // TODO 4.1e: kizáró VAGY művelet
byte balra = ertek; // TODO 4.1f: balra tolás és az alsó 8 bit megtartása
Console.WriteLine($"Eredeti minta: {Binaris8(ertek)}");
Console.WriteLine($"A vizsgált bit 1: {beVanKapcsolva}");
Console.WriteLine($"Bekapcsolás: {Binaris8(bekapcsolt)} = {bekapcsolt}");
Console.WriteLine($"Kikapcsolás: {Binaris8(kikapcsolt)} = {kikapcsolt}");
Console.WriteLine($"Átbillentés: {Binaris8(valtott)} = {valtott}");
Console.WriteLine($"Balra tolás, alsó 8 bit: {Binaris8(balra)} = {balra}");

sbyte elojeles = 0; // TODO 4.2: explicit unchecked sbyte konverzió
Console.WriteLine($"Ugyanaz a 8 bit előjel nélkül: {ertek}, előjellel: {elojeles}");

long bajt = EgeszBeolvas("Fájl mérete bájtban (0..1000000000): ", 0, 1_000_000_000);
long bitDarab = 0; // TODO 4.3a: egy bájt nyolc bit
double kB = 0; // TODO 4.3b: decimális kilobájt
double KiB = 0; // TODO 4.3c: bináris kibibájt
Console.WriteLine($"Bit: {bitDarab}, kB: {kB}, KiB: {KiB}");

Console.WriteLine("Túlcsordulás megfigyelése");
byte a = 250;
int osszeg = a + 10;
byte csonkolt = 0; // TODO 4.4a: explicit unchecked byte konverzió
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
sbyte kovetkezo = 0; // TODO 4.4b: az összeg unchecked sbyte konverziója
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

