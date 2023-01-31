// Напишите программу, которая выводит случайное трёхзначное
// число и удаляет второе число. 

Console.Clear();

int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = num % 10;

Console.WriteLine($"Дано число {num}  {a1}{a2} ");



