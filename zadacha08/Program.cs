//  Напишите программу, котораяпринимает на вход
//  цифру, обозначающую день недели, и проверяет,
//  является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите цифру дня недели a ");
int a = int.Parse(Console.ReadLine()!);
int b = 6;
int c = 7;
if(a == b || a == c)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}


 
