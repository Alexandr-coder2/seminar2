// Напишите программу, которая найдёт точку пересечения
// двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

Console.Clear();

double ResaltX(int b1, int k1, int b2, int k2)
{
    double x1 = b2 - b1;
    double x2 = k1 - k2;
    double x = x1 / x2;
    return x;
}

double ResaltY(int k1, int b1, double x)
{
    double y = (k1 * x) + b1;
    return y;
}

Console.Write("Введите число b1: ");
int b1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k1: ");
int k1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число b2: ");
int b2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число k2: ");
int k2 = int.Parse(Console.ReadLine()!);

double x = ResaltX(b1, k1, b2, k2);
double y = ResaltY(k1, b1,x);
Console.Write($"Координаты точки пересечения -> (x = {x}; y = {y}) ");


