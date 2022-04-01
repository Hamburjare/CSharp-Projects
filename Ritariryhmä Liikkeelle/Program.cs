using System;

Console.Title = "Ritariryhmä Liikkeelle";
Console.Write("Kohde rivi? ");
int rivi = Convert.ToInt32(Console.ReadLine());
if (rivi > 8)
{
    Console.WriteLine("Aseta pienempi numero.");
    Environment.Exit(0);
}
Console.Write("Kohde sarake? ");
int sarake = Convert.ToInt32(Console.ReadLine());
if (sarake > 8)
{
    Console.WriteLine("Aseta pienempi numero.");
    Environment.Exit(0);
}
Console.WriteLine("Lähetetään ritarit.");
Console.ForegroundColor = ConsoleColor.Red;
Console.Beep(440, 300);
Console.WriteLine($"Ritari yksi kohteeseen ({rivi}, {sarake - 1})");
Console.ForegroundColor = ConsoleColor.Green;
Console.Beep(440, 300);
Console.WriteLine($"Ritari kaksi kohteeseen ({rivi - 1}, {sarake})");
Console.ForegroundColor = ConsoleColor.Blue;
Console.Beep(440, 300);
Console.WriteLine($"Ritari kolme kohteeseen ({rivi}, {sarake + 1})");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.Beep(440, 300);
Console.WriteLine($"Ritari yksi kohteeseen ({rivi + 1}, {sarake})");
Console.ForegroundColor = ConsoleColor.White;