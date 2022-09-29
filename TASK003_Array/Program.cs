﻿Console.Clear();

void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 100);
        index++;
    }
}

void PrintArray(int[] col)
{
    Console.Write($"[");
    Console.Write(String.Join(", ", col));
    Console.Write($"]");
}

int[] array = new int[8];
FillArray(array);
PrintArray(array);