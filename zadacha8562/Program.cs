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

int SumLineElements(int[,] array)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}

int[,] array2D = GetArray(4, 4, -10, 10);

int minSumLine = 0;
int sumLine = SumLineElements(array2D);
for (int i = 1; i < array2D.GetLength(0); i++)
{
  int tempSumLine = SumLineElements(array2D);
  if (sumLine > tempSumLine)
  {
    sumLine = tempSumLine;
    minSumLine = i;
  }
}

Console.WriteLine($"\n{minSumLine+1} - строкa с наименьшей суммой ({sumLine}) элементов ");


Console.Clear();
// int[,] array2D = GetArray(row, col, -10, 10);
PrintArray(array2D);
SumLineElements(array2D);
Console.WriteLine();
PrintArray(array2D);