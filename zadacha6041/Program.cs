// Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }

    return result;
}

int countPositiveNumbers(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            result ++;
        }
    }
    return result;
}
Console.WriteLine("Введите количество чисел M : ");
int M = int.Parse(Console.ReadLine()!);
int[] array = GetArray(M, -99, 99);

Console.Write(String.Join(", ", array));
Console.Write(" -> ");
Console.Write(String.Join(", ", countPositiveNumbers(array)));

