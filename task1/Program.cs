// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void IsPalindrom(int arg)
{
    if (arg < 10000 || arg > 99999)
    {
        Console.Write("неверное число!");
        return;
    }

    if (arg / 10000 == arg % 10 && (arg / 1000) % 10 == (arg / 10) % 10)
    {
        Console.Write($"{arg} -> да");
    }
    else
    {
        Console.Write($"{arg} -> нет");
    }
}

int GetInfo(string message)
{
    Console.Write(message);
    int res = Convert.ToInt32(Console.ReadLine());
    return res;
}

int number = GetInfo("Введите 5-значное число: ");
IsPalindrom(number);
