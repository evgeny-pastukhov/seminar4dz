﻿int[] array = new int[10];


void CreateArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 101);
    }
}

void PrintArray()
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");

    }
    System.Console.WriteLine();
}

void FindElementArray()
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            k++;
        }


    }
    System.Console.WriteLine($"Количество чётных чисел = {k}");

}


CreateArray();
PrintArray();
FindElementArray();
