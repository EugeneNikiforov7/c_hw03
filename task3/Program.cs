// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

void WriteTable(int number)
{
    for (int index = 1; index < number; index++)
    {
        Console.Write($"{Math.Pow(index, 3)}, ");
    }
    Console.Write(Math.Pow(number, 3));
}

int GetInfo(string message)
{
    Console.Write(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int number = GetInfo("Введите число: ");

Console.Write($"{number} -> ");
WriteTable(number);