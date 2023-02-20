// Задайте двумерный массив размером m×n,
// заполненный случайными вещественными числами.
//  m = 3, n = 4.
//  0,5 7 -2 -0,2
//  1 -3,3 8 -9,9
//  8 7,8 -7,1 9


double[,] GetArray(int m, int n, double minValue, double maxValue)
{
double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().NextDouble() * 10;
        }
    }  

    return result;
}

void PrintArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            //Console.Write($"{inArray[i, j]}\t ");
            Console.Write("{0,6:F2}", inArray[i, j]);
        }
        Console.WriteLine();
    }
}

Console.Clear();

double[,] array2D = GetArray(3, 4, -99, 99);
PrintArray(array2D);


