﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num > 0)
    {
        Console.Write("{0} ", num);
        NaturalNumber(num - 1);
    }
}

NaturalNumber(number);

