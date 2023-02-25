// Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbr(int M, int N)
{
    if (M == N) return M;
    return N + SumNumbr(M, N - 1);
}

Console.Clear();

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(SumNumbr(M, N));
