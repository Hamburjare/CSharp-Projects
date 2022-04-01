using System;

Console.WriteLine("***Teimon Kyläkauppa***\nInventaario:\n1 - Miekka\n2 - Kirves\n3 - Köysi\n4 - Kanootti\n5 - Lusikka & Haarukka\n6 - Makuupussi\n7 - Teltta");
Console.Write("Anna nimesi: ");
string nimi = Console.ReadLine();
string nimipieni = nimi.ToLower();
Console.Write("Minkä esineen hinnan haluat tietää? ");
int item = Convert.ToInt32(Console.ReadLine());
int jakaja = 1;

if (nimipieni == "kalle")
{
    jakaja = 2;
}
switch(item)
{
    case 1:
        Console.WriteLine($"Miekka maksaa {50 / jakaja} kultakolikkoa.");
        break;
    case 2:
        Console.WriteLine($"Kirves maksaa {40 / jakaja} kultakolikkoa.");
        break;
    case 3:
        Console.WriteLine($"Köysi maksaa {15 / jakaja} kultakolikkoa.");
        break;
    case 4:
        Console.WriteLine($"Kanootti maksaa {75 / jakaja} kultakolikkoa.");
        break;
    case 5:
        Console.WriteLine($"Lusikka & Haarukka maksaa {20 / jakaja} kultakolikkoa.");
        break;
    case 6:
        Console.WriteLine($"Makuupussi maksaa {70 / jakaja} kultakolikkoa.");
        break;
    case 7:
        Console.WriteLine($"Teltta maksaa {100 / jakaja} kultakolikkoa.");
        break;
    default:
        Console.WriteLine("Aseta jokin toinen luku.");
        break;
}