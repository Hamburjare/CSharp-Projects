using System;

Console.Write("Anna pituus (cm): ");
double pituus = Convert.ToInt32(Console.ReadLine());
pituus = (pituus * 1.0 / 100);

Console.Write("Anna paino (kg): ");
int paino = Convert.ToInt32(Console.ReadLine());

double value = Math.Pow(pituus, 2.5);

double lasku = 1.3 * paino / value;

lasku = Math.Round(lasku, 2);

Console.WriteLine($"Paino indeksisi on {lasku} ");
