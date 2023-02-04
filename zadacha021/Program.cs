// Напишите программу, которая принимает на
// вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//  3 -> 1, 8, 27
//  5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите x1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z1: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите x2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите z2: ");
int z2 = int.Parse(Console.ReadLine()!);

double n = Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2);
double c = Math.Sqrt(n);

Console.WriteLine($"{c:f2}");

