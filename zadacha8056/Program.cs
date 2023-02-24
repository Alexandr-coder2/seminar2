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

void FindSmallerSum(int[,] inarray)
{
    int min = 0;
    int minRow = 1;
    int sum;
    bool isStarted = false;
    for (int i = 0; i < inarray.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < inarray.GetLength(1); j++)
        {
            sum += inarray[i, j];
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

Console.Write("rows =");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("columns =");
int columns = int.Parse(Console.ReadLine()!);

int[,] Array = GetArray(rows, columns, -1, 10);
Console.WriteLine();

PrintArray(Array);
FindSmallerSum(Array);

