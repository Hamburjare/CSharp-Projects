using System;

Console.Write("User 1, enter a number between 0 and 100: ");
int luku = Convert.ToInt32(Console.ReadLine());
if (luku < 0 || luku > 100)
{
    Console.Write("User 1, enter a number between 0 and 100: ");
    luku = Convert.ToInt32(Console.ReadLine());
}
Console.Clear();

Console.WriteLine("User 2, guess the number.");
Console.Write("What is your next quess? ");
int arvaus = Convert.ToInt32(Console.ReadLine());
while (arvaus > luku || arvaus < luku)
{
    if (arvaus == luku)
    {
        break;
    }
    else if (arvaus < luku)
    {
        Console.WriteLine($"{arvaus} is too low.");
    }
    else
    {
        Console.WriteLine($"{arvaus} is too high");
    }
    Console.Write("What is your next quess? ");
    arvaus = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("You quessed the number!");