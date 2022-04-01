using System;

int i = 1;

while (i <= 100)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine($"{i}: Electric and Fire");
    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i}: Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor= ConsoleColor.Yellow;
        Console.WriteLine($"{i}: Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i}: Normal");
    }

    Console.ForegroundColor = ConsoleColor.White;
    i++;
}

