// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }

    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FindSmallerSum(int[,] Array)
{
    int minRow = 1;
    bool isStarted = false;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int min = 0;
        int sum = 0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum += Array[i, j];
        }
        if (!isStarted || sum < min)
        {
            isStarted = true;
            min = sum;
            minRow = i + 1;
        }
    }
    Console.WriteLine($"строка № {minRow}");
}

Console.Clear();
int[,] Array = GetArray(4, 3, -1, 10);
PrintArray(Array);
FindSmallerSum(Array);
