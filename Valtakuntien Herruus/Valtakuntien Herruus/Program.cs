using System;
int maatilaP = 1;
int herttuakuntaP = 3;
int maakuntaP = 6;

Console.WriteLine("Montako Maatilaa omistat?");
int maatila = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Montako Herttuakuntaa omistat?");
int herttuakunta = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Montako Maakuntaa omistat?");
int maakunta = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Sait pisteitä yhteensä: " + Math.Abs(maatilaP * maatila + herttuakuntaP * herttuakunta + maakuntaP * maakunta));