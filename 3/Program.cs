double[] array = new double[10];


void CreateArray()
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(1, 101) + random.NextDouble();
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
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }


    }


    System.Console.WriteLine($"Разница min и max = {max - min}");

}


CreateArray();
PrintArray();
FindElementArray();
