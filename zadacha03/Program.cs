//  Напишите программу которая будет принимать на вход два числа
// и выводить, является ли второе число кратным первому. Если не
// является выводит остаток от деления.


Console.Clear();

Console.WriteLine("Введите число a ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число b ");
int b = int.Parse(Console.ReadLine()!);
int c = a % b;
if(c == 0 )
{
    Console.Write("Кратно");
}
else
{
    Console.WriteLine($"Не кратно, остаток {c} ");
}


