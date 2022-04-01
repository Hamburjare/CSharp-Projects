using System;

Console.WriteLine("Montako kalaa karhut ovat kalastaneet päivän aikana?");
int kalastetutKalat = Convert.ToInt32(Console.ReadLine());


if (kalastetutKalat % 4 == 0)
{
    Console.WriteLine("Karhut saivat jokainen: " + kalastetutKalat / 4 + " kalaa");
    Console.WriteLine("Kissa sai: 0 kalaa");
} else
{
    int kalastetutKalat2 = kalastetutKalat % 4;
    kalastetutKalat2 = kalastetutKalat - kalastetutKalat2;
    Console.WriteLine("Karhut saivat jokainen: " + kalastetutKalat2 / 4 + " kalaa");
    Console.WriteLine("Kissa sai: "+ kalastetutKalat % 4 + " kalaa");
}

// 6, 11, 3, 2, 1 lukuja jossa kissa saa enemmän kuin karhut