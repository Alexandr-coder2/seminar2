// Напишите программу, которая выводит случайное трёхзначное
// число и удаляет второе число. 

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;

Console.WriteLine($"{num}");

int res = a1 * 10 + a2;

Console.Write($"{res}");



