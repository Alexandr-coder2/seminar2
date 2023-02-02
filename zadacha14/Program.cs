//  Напишите программу, которая принимает на вход два
// числа и проверяет, является ли одно число квадратом
// другого.
// ● 5, 25 -> да
// ● -4, 16 -> да
// ● 25, 5 -> да
// ● 8,9 -> нет 


Console.Clear();

Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine()!);

if(b * b == a || a * a == b)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
