using System;

Console.Write("Anna x arvo: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Anna y arvo: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0) Console.WriteLine("Enemy is to the north east");
if (x > 0 && y == 0) Console.WriteLine("Enemy is to the east");
if (x > 0 && y < 0) Console.WriteLine("Enemy is to the south east");
if (x == 0 && y > 0) Console.WriteLine("Enemy is to the north");
if (x == 0 && y == 0) Console.WriteLine("Enemy is on top of you");
if (x == 0 && y < 0) Console.WriteLine("Enemy is to the south");
if (x < 0 && y > 0) Console.WriteLine("Enemy is to the north west");
if (x < 0 && y == 0) Console.WriteLine("Enemy is to the west");
if (x < 0 && y < 0) Console.WriteLine("Enemy is to the south west");