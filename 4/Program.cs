int N = new Random().Next(1, 100001);
int N1 = N;
int k = 0;
System.Console.WriteLine($"N = {N}");
while (N1 > 0)
{
    k++;
    N1 = N1 / 10;
}

System.Console.WriteLine($"k = {k}");

int[] array = new int[k];

for (int i = k - 1; i >= 0; i--)
{
    array[i] = N % 10;
    N = N / 10;
}

for (int i = 0; i < array.Length; i++)
{
    System.Console.Write(array[i] + " ");
}
System.Console.WriteLine();
