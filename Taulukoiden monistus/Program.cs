using System;

int[] array = new int[5];
int[] array2 = new int[5];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Anna numero listan {i + 1} kohtaan: ");
    int number = Convert.ToInt32(Console.ReadLine());
    array[i] = number;
}
Console.WriteLine("[{0}]", string.Join(", ", array));

for (int i = 0; i < array.Length; i++)
{
    int number = array[i];
    array2[i] = number;
}
Console.WriteLine("[{0}]", string.Join(", ", array2));