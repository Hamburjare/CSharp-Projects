using System;

Console.Write("Anna numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
if (numero % 2 == 0)
    Console.WriteLine("Tick");
else
    Console.WriteLine("Tock");