// Напишите программу, которая выводит третью
// цифру заданного числа или сообщает, 
// что третьей цифры нет. 

Console.Clear();

Console.Write("Введите число n ");
int n = int.Parse(Console.ReadLine()!);

if (n > 99)
{
    while (n > 999)
    {
        n /= 10;
    }
    int res = n % 10;
    Console.WriteLine(res);
}
else
{
    Console.WriteLine("Третьей цифры нет ");
}








