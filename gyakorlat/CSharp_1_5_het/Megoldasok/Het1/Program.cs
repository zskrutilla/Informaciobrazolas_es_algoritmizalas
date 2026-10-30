// OKTATÓI MEGOLDÁS: a FELADAT jelölések a feladatlap részeire utalnak.
using System;
using System.Globalization;

// A kimenetben pont jelöli a tizedesjelet.
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
Console.WriteLine("1. hét - A maratoni óra készletkalkulátora");
Console.Write("Mi a neved? ");
string nev = Console.ReadLine() ?? "";

// Ebben az első feladatban a megadott tartományon belüli egész adatokat írjuk be.
Console.Write("Résztvevők száma (1..200): ");
int letszam = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Nyomtatott oldalak fejenként (1..100): ");
int oldalFejenkent = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Egy oldal ára forintban (1..1000): ");
int oldalAr = int.Parse(Console.ReadLine() ?? "0");

int osszesOldal = letszam * oldalFejenkent; // FELADAT 1.2
int teljesAr = osszesOldal * oldalAr; // FELADAT 1.2
double teaLiter = letszam * 0.25; // FELADAT 1.2
Console.WriteLine($"Szia, {nev}!");
Console.WriteLine($"Összes oldal: {osszesOldal}");
Console.WriteLine($"Teljes ár: {teljesAr} Ft");
Console.WriteLine($"Tea: {teaLiter} liter");

Console.WriteLine($"7 / 2 = {7 / 2}"); // FELADAT 1.3
Console.WriteLine($"7 / 2.0 = {7 / 2.0}"); // FELADAT 1.3
Console.WriteLine($"7 % 2 = {7 % 2}"); // FELADAT 1.3

int idotartamPerc = 135;
int ora = idotartamPerc / 60; // FELADAT 1.4
int perc = idotartamPerc % 60; // FELADAT 1.4
Console.WriteLine($"135 perc = {ora} óra {perc} perc");
