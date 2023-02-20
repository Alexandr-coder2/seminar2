// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет


int[,] GetArray(int row, int col, int minValue, int maxValue)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} \t");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите первое число");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int m = int.Parse(Console.ReadLine()!);

void FindElement(int[,] Array)
{
    if (n > Array.GetLength(0) || m > Array.GetLength(1))
    {
        Console.WriteLine("такого элемента нет");
    }
    else
    {
        Console.WriteLine(
            $"значение элемента {n} строки и {m} столбца равно {Array[n - 1, m - 1]}"
        );
    }
}

Console.WriteLine();
int[,] myArray = GetArray(4, 3, 10, 99);
PrintArray(myArray);
FindElement(myArray);