using System;

int result = AskForNumber("Mikä on koiran maximi nopeus km/h ? ");
int vastaus = 0;

int AskForNumber(string text)
{
    Console.Write(text);
    int vastaus = Convert.ToInt32(Console.ReadLine());
    return vastaus;
}

Console.WriteLine($"Koiran maksimi nopeus on {result}");

while (vastaus <= 0)
{
    if (vastaus == -1)
    {
        Console.Clear();
        Console.WriteLine("Aseta luku antamiesi lukujen välistä");
    }
    
    Console.Write("Anna minimi luku: ");
    int min = Convert.ToInt32(Console.ReadLine());
    Console.Write("Anna maksimi luku: ");
    int max = Convert.ToInt32(Console.ReadLine());

    vastaus = AskForNumberInRange("Mikä on kissan nopeus km/h ? ", min, max);
}


int AskForNumberInRange(string text, int min, int max)
{
    Console.Write(text);
    int vastaus = Convert.ToInt32(Console.ReadLine());
    if (vastaus <= max && vastaus >= min) return vastaus ;
    return -1;
}

Console.WriteLine($"Kissan nopeus on {vastaus} km/h");

Rekursiivinen(10);

static void Rekursiivinen(int num)
{
    Console.WriteLine(num.ToString());
    if (num > 1)
        Rekursiivinen(num - 1);
}



