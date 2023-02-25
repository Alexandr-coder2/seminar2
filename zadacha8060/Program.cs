// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[] ShuffleArray(int[] array)
{
    Random rng = new Random();
    int n = array.Length;
    while (n > 1)
    {
        --n;
        int k = rng.Next(n + 1);
        int temp = array[k];
        array[k] = array[n];
        array[n] = temp;
        
    }
    return array;
}

int[] GetRandomArrayUnigues(int min, int max)
{
    int[] values = new int[max - min + 1];
    for (int i = min; i <= max; i++)
    {
        values[i - min] = i;
    }
    return ShuffleArray(values);
}

int[,,] GetArray3D(int l, int m, int n, int minValue, int maxValue)
{
    int[] values = GetRandomArrayUnigues(minValue, maxValue);
    int[,,] array3D = new int[l, m, n];
    int cnt = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                array3D[i, j, k] = values[cnt++];
            }
        }
    }
    return array3D;
}

void PrintArray3D(int[,,] array3D)
{
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write($"{array3D[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] myArray = GetArray3D(4, 4, 4, 10, 99);
PrintArray3D(myArray);

