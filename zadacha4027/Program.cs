// Напишите функцию и запустите ее, которая
// принимает на вход число и выдаёт сумму цифр в числе. 



Console.Clear();

 int Sum(int n)
{
    int sum = 0;

    for (int i = 0; i <= n; i++)
    {
        sum += i;
    }
    return sum;   
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма чисел от 1 до {N} равно {Sum(N)} ");