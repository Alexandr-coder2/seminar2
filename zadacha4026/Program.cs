//   Напишите программу, которая принимает
// на вход число и выдаёт количество цифр в числе.
//   456 -> 3
//   78 -> 2
//   89126 -> 5

int DigitCount(int A)
{
    int count = 0;
    while (A!=0)
    {
        A /= 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(DigitCount(N));
