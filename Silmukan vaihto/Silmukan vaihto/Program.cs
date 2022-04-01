using System;


int[] array = new int[] { 5, 52, -6, 14, -98, 16, -7, 46, 91 };
int currentMininum = int.MaxValue; // Otetaan suurin mahdollinen arvo oletukseksi.


foreach (int i in array)
{
    if (i < currentMininum)
    {
        currentMininum = i;
    }
        
}

Console.WriteLine("Minimiarvo: " + currentMininum);


int total = 0;

foreach (int i in array)
{
    total += i;
}

float average = (float)total / array.Length;

Console.WriteLine("Keskiarvo: " + average);