using System;

// Määritetään lohikäärmeelle hp
int dragonHp = 10;
// Määritetään kaupungille hp
int townHp = 15;
// Määritetään kierros
int round = 1;
// Määritetään kuinka kaukana lohikäärme on kaupungista
int dragonDistance = -1;
// Määritetään paljonko kanuuna tekee damagea
int cannonDamage = 0;
// Määritetään kanuunan oletus kantama
int cannonDistance = 0;

// Kysytään käyttäjältä haluaako se pelata yksin
Console.Write("Haluatko yksinpelin? (y/n) ");
string playerCount = Console.ReadLine();
Console.Clear();

// Mikäli käyttäjä valitsi pelaavansa yksin generoidaan random numero 0-100
if (playerCount.ToLower() == "y" || playerCount.ToLower() == "yes")
{
    // Tallennetaan "dragonDistance" muuttujaan "RandomDragonDistance" tulos
    dragonDistance = RandomDragonDistance();

} else
{
    // Looppi joka jatkuu niin pitkään jos pelaaja 1 asettaa luvun < 0 tai > 100
    while(dragonDistance < 0 || dragonDistance > 100)
    {
        Console.Write("Pelaaja 1, kuinka kaukana lohikäärme on kaupungista? (0-100) ");
        Console.ForegroundColor = ConsoleColor.Magenta;
        // Tallennetaan muuttujaan pelaajan 1 asettama luku
        dragonDistance = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.White;
    }
    Console.Clear();
}



// Pelaajan 2 vuoro alkaa

Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine("Pelaajan 2 vuoro.");
Console.ForegroundColor = ConsoleColor.White;

// Looppi joka pyörii niin kauan kun muuttuja "dragonHp" <= 0 tai muuttuja "townHp" <= 0
while (dragonHp > 0 && townHp > 0)
{
    
    string status = $"STATUS: Kierros: {round}  Lohikäärme: {dragonHp}/10  Kaupunki: {townHp}/15";

    // Printtaa viivan jonka pituus on muuttujan "status" pituus + 4 merkkiä
    PrintLine(status.Length + 4);
    // Printtaa muuttujan "status" sisällön;
    Console.WriteLine(status);

    // Kutsutaan metodia mikä määrittää paljonko kanuuna tekee vahinkoa kierroksen perusteella
    GetCannonDamage();

    // Kutsutaan metodia millä saadaan etäisyys kuinka pitkälle kanuunalla ammutaan
    GetCannonDistance();

    // Metodi muuttaa muuttujan "round" ja "townHp" määrää
    ChangeRoundAndHealth();
}

// Printataan pelin tulos
PrintResults();


// Metodit

// Muuttaa muuttujia "round" ja "townHp"
void ChangeRoundAndHealth()
{
    
    if (dragonHp <= 0 || townHp <= 0)
    {
        // Jos lohikäärmeellä tai kaupungilla on healttia 0 tai vähemmän metodista hypätään pois
        return;
    }
    else
    {   
        // Vähennetään muuttujasta "townHp" 1 luku
        townHp--;
        
        
        if (townHp > 0)
        {
            //Jos muuttuja "townHp" on suurempi kuin 0 kierros lukua suurennetaan yhdellä
            round++;
        }
        
    }
}

// Määritetään paljonko kanuuna tekee damagea kierroksen aikana
void GetCannonDamage()
{
    
    if (round % 3 == 0 || round % 5 == 0)
    {
        if (round % 3 == 0 && round % 5 == 0)
        {
            // Jos kierros on jaollinen 3 ja 5 kanuuna tekee 10 damagea
            cannonDamage = 10;
        }

        // Jos kierros on jaollinen 3 tai 5 kanuuna tekee 3 damagea
        cannonDamage = 3;
    } else
    {
        // Jos kierros ei ole jaollinen 3 tai 5 kanuuna tekee 1 damagen
        cannonDamage = 1;
    }

    Console.ForegroundColor = ConsoleColor.Cyan;
    // Printtaa paljonko kanuuna tekee damagea tällä kierroksella
    Console.WriteLine($"Kanuuna tekee tällä kierroksella {cannonDamage} vahinkoa lohikäärmeeseen.");
    Console.ForegroundColor = ConsoleColor.White;

}

// Metodi mikä generoi random luvun mikäli käyttäjä valitsi pelaavansa yksin
int RandomDragonDistance()
{
    Random random = new Random();
    // Tallennetaan random luku väliltä 0 - 100 muuttujaan "randomNumber"
    int randomNumber = random.Next(0, 101);
    return randomNumber;
}

// Metodi mikä määrittää kuinka pitkälle kanuunalla ammutaan
void GetCannonDistance()
{
    // Kysytään pelaajalta kuinka pitkälle hän haluaa ampua
    Console.Write("Mille etäisyydelle kanuunalla ammutaan: ");
    Console.ForegroundColor = ConsoleColor.Magenta;
    int distance = Convert.ToInt32(Console.ReadLine());

    if (distance == dragonDistance)
    {
        // Jos pelaajan asettama luku on sama kuin kuinka kaukana lohikäärme on printataan "Osuma!" konsoliin
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Beep(1000, 200);
        Console.WriteLine("Osuma!");

        // Vähennetään lohikäärmeeltä hpta riippuen siitä paljonko kanuuna tekee damagea joka saadaan muuttujasta "cannonDamage"
        dragonHp = dragonHp - cannonDamage;
        Console.ForegroundColor = ConsoleColor.White;
    } else if (distance > dragonDistance)
    {
        // Jos pelaajan antama luku on suurempi kuin lohikäärmeen etäisyys kaupungista siitä ilmoitetaan pelaajalle
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Beep(500, 200);
        Console.WriteLine("Tähtäsit liian pitkälle ja luoti meni lohikäärmeen yli!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    else
    {
        // Jos pelaajan antama luku on pienempi kuin lohikäärmeen etäisyys kaupungista siitä ilmoitetaan pelaajalle
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Beep(500, 200);
        Console.WriteLine("Tähtäsit liian lähelle ja luoti meni ei ylettynyt lohikäärmeen luokse!");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}

// Metodi mikä printtaa viivan jonka pituus on se mitä asetetaan kun metodia kutsutaan
void PrintLine(int length)
{
    Console.WriteLine("\n" + new string('-', length));
}

// Metodi mikä tulostaa pelin tuloksen pelin päätyttyä
void PrintResults()
{
    // Printtaa viivan minkä pituus on 58 merkkiä
    PrintLine(58);


    if (dragonHp <= 0)
    {
        // Jos lohikäärmeellä on 0 healthia ilmoitetaan pelaajalle että se on voittanut
        Console.WriteLine("Päihitit lohikäärmeen! Kaupunkisi on turvassa jälleen");
        // Tulostetaan mille kierrokselle pelaaja pääsi
        Console.WriteLine($"Pääsit kierrokselle: {round}");
        // Tulostetaan paljonko kaupungille jäi healthia
        Console.WriteLine($"Kaupungin hp: {townHp}");
        // Tulostetaan paljonko lohikäärmeelle jäi healthia ja varmistetaan, että luku ei ole pienempi kuin 0
        Console.WriteLine($"Lohikäärmeen hp: {Math.Max(dragonHp, 0)}");
    } else
    {
        // Jos lohikäärmeelle jäi enemmän hpta ja kaupunki tuhoutui pelaajalle ilmoitetaan siitä
        Console.WriteLine("Lohikäärme tuhosi kaupunkisi! Jouduit lähtemään maanpakoon");
        // Tulostetaan mille kierrokselle pelaaja pääsi
        Console.WriteLine($"Pääsit kierrokselle: {round}");
        // Tulostetaan paljonko kaupungille jäi healthia
        Console.WriteLine($"Kaupungin hp: {townHp}");
        // Tulostetaan paljonko lohikäärmeelle jäi healthia ja varmistetaan, että luku ei ole pienempi kuin 0
        Console.WriteLine($"Lohikäärmeen hp: {Math.Max(dragonHp, 0)}");
    }

}

