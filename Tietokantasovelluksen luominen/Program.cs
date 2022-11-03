using Harjoitus2;
//Console.WriteLine($"Yhteyden tarjoaa { ProjectConstants.DatabaseProvider}.");
//QueringLogins();
//QueringLoginByName("Teppo");
// Uusi tietue
var nickname = "Teero123";
var pincode = "5656";
if (AddLogins(pincode, nickname))
{
    Console.WriteLine("Tallennus onnistui.");
}
else
{
    Console.WriteLine("Tallennus ei onnistunut.");
}
static void QueringLogins()
{
    using (Pelitietokanta pelitietokanta = new())
    {
        Console.WriteLine("Rekisteröityneet pelaajat:");
        // Haetaan kaikki logins taulun tietueet
        IQueryable<Login>? logins = pelitietokanta.Logins;
        if (logins is null)
        {
            Console.WriteLine("Yhtään pelaajaa ei ole rekisteröitynyt.");
        return;
        }
        // Käydään kaikki tietueet läpi ja tulostetaan ne näytölle
        foreach (Login login in logins)
        {
            Console.WriteLine(login.Nickname);
        }
    }
}
static void QueringLoginByName(string nickname)
{
    using (Pelitietokanta pelitietokanta = new())
    {
        Console.WriteLine("Pelaajan " + nickname + " tiedot.");
        // Haetaan tietue nimellä
        IQueryable<Login>? logins = pelitietokanta.Logins?.Where(login => login.Nickname == nickname);
        if (logins is null)
        {
            Console.WriteLine("Pelaajaa ei löydy.");
            return;
        }
        // Käydään kaikki tietueet läpi ja tulostetaan ne näytölle
        foreach (Login login in logins)
        {
            Console.WriteLine($"{nickname} salasana on {login.Pincode} ");
        }
    }
}
static bool AddLogins(string newPincode, string newNickname)
{
    using (Pelitietokanta pelitietokanta = new())
    {
        Login login = new()
        {
            Nickname = newNickname,
            Pincode = newPincode
        };
        pelitietokanta.Logins?.Add(login);
        int affected = pelitietokanta.SaveChanges();
        return (affected == 1);
    }
}
static bool ChangeNickname(string newNickname, string pincode)
{
    using (Pelitietokanta pelitietokanta = new())
    {
        Login loginUpdate = pelitietokanta.Logins.Find(pincode);
        if (loginUpdate is null)
        {
            return false;
        }
        else
        {
            loginUpdate.Nickname = newNickname;
            int affected = pelitietokanta.SaveChanges();
            return (affected == 1);
        }
    }
}
static int DeleteLogins(string pincode)
{
    using (Pelitietokanta pelitietokanta = new())
    {
        Login loginDelete = pelitietokanta.Logins.Find(pincode);
        if (loginDelete is null)
        {
            Console.WriteLine("Ei löydy!");
            return 0;
        }
        else
        {
            pelitietokanta.Remove(loginDelete);
            int affected = pelitietokanta.SaveChanges();
            return affected;
        }
    }
}