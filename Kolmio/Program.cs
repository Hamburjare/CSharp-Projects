using System;

string kanta;
string korkeus;

Console.WriteLine("Anna kolmion kannan koko:");
kanta = Console.ReadLine();
Console.WriteLine("Anna kolmion korkeus: ");
korkeus = Console.ReadLine();
int kanta1 = int.Parse(kanta);
int korkeus1 = int.Parse(korkeus);
Console.WriteLine("Kolmion pinta-ala on " + kanta1 * korkeus1 / 2 + "m²");

