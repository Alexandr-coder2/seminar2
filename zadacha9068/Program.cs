// Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// n = 2, m = 3 -> A(n,m) = 9

int Ackerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Ackerman(n - 1, 1);
    else
      return Ackerman(n - 1, Ackerman(n, m - 1));
}


Console.Clear();

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.WriteLine(Ackerman(n, m));