﻿// **Задача 65:**Задайте значения M и N.
//  Напишите программу, которая выведет все
//   натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 5, 6, 7, 8"

using System;
using static System.Console;
Clear();
Write("Введите первое число N: ");
int n=int.Parse(ReadLine());

Write("Введите второе число M: ");
int m=int.Parse(ReadLine());

WriteLine(PrintNumbers(n,m));

string PrintNumbers(int n, int m)
{
    if (m==n)
    {
        return n.ToString();
    }
    string s = PrintNumbers(n, m-1) + ", "+ m.ToString();
    return s;
}
