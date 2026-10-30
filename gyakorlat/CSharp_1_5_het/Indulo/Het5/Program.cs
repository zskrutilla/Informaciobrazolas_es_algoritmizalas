// INDULÓ KÓD: a TODO sorokat egészítsd ki a feladatlap alapján.
using System;
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
Console.WriteLine("5. hét - Lebegőpontos kísérletek");

float f = 0f; // TODO 5.1a: 0.1f + 0.2f
double d = 0; // TODO 5.1b: 0.1 + 0.2
decimal m = 0m; // TODO 5.1c: 0.1m + 0.2m
Console.WriteLine($"float G9: {f:G9}, egyenlő 0.3f-fel: {f == 0.3f}");
Console.WriteLine($"double G17: {d:G17}, egyenlő 0.3-mal: {d == 0.3}");
Console.WriteLine($"decimal: {m}, egyenlő 0.3m-mel: {m == 0.3m}");

double szam = PozitivBeolvas();
double szignifikandusz = szam;
int kitevo = 0;
while (szignifikandusz >= 2)
{
    szignifikandusz /= 2;
    kitevo += 0; // TODO 5.2a: kettővel osztáskor a kitevő nő
}
while (szignifikandusz < 1)
{
    szignifikandusz *= 2;
    kitevo -= 0; // TODO 5.2b: kettővel szorzáskor a kitevő csökken
}
Console.WriteLine($"Normalizált alak: {szignifikandusz:G17} * 2^{kitevo}");
Console.WriteLine($"Visszaellenőrzés: {szignifikandusz * Math.Pow(2, kitevo):G17}");

Console.WriteLine("Egészre kerekítés");
KerekitestMutat(2.5m);
KerekitestMutat(3.5m);
KerekitestMutat(-2.5m);
KerekitestMutat(-3.5m);

float nagy = 16_777_216f;
Console.WriteLine($"float: (nagy + 1f) == nagy: {nagy + 1f == nagy}");
double a = 1e16, b = -1e16, c = 1;
Console.WriteLine($"(a + b) + c = {(a + b) + c}, a + (b + c) = {a + (b + c)}");
Console.WriteLine($"Abszolút eltérés 0.3-tól: {Math.Abs(d - 0.3):G17}");

double max = double.MaxValue;
double tulNagy = max * 2;
double minimum = double.Epsilon;
double tulKicsi = minimum / 2;
double nulla = 0;
double nemSzam = nulla / nulla;
Console.WriteLine($"Túlcsordult eredmény végtelen: {double.IsPositiveInfinity(tulNagy)}");
Console.WriteLine($"Legkisebb pozitív double fele nulla: {tulKicsi == 0}");
Console.WriteLine($"0.0 / 0.0 NaN: {double.IsNaN(nemSzam)}");

// Választható megfigyelés: 16 bites feles pontosság.
Half h = (Half)0.1f;
Console.WriteLine($"Half 0.1 közelítése floatként: {(float)h:G9}");

static void KerekitestMutat(decimal x)
{
    decimal paros = x; // TODO 5.3a: Math.Round és ToEven
    decimal elfele = x; // TODO 5.3b: Math.Round és AwayFromZero
    Console.WriteLine($"{x}: ToEven = {paros}, AwayFromZero = {elfele}");
}

// KÉSZ SEGÉDRÉSZ: ponttal és vesszővel beírt pozitív számot is elfogad.
static double PozitivBeolvas()
{
    while (true)
    {
        Console.Write("Normalizálandó pozitív szám (0.0001..1000000): ");
        string s = (Console.ReadLine() ?? "").Replace(',', '.');
        if (double.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out double x)
            && x >= 0.0001 && x <= 1_000_000)
            return x;
        Console.WriteLine("A tartományon belüli pozitív számot adj meg!");
    }
}
