// Напишите программу которая определяет из двух чисел кратно ли 
// одно другому.

Console.Clear();

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine()!);
int b = 7;
int c = 23;
int res1 = a % b;
int res2 = a % c;
if(res1 == 0 && res2 == 0)
{
    Console.WriteLine("Кратно ");
}
else
{
    Console.WriteLine("Нет ");
}

