﻿/*Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();
Console.WriteLine("Enter number N: ");
int N = int.Parse(Console.ReadLine());
int a = 2;
Console.Write($"{N} -> ");
    while (a <= N){
       Console.Write($"{a}, ");  
       a = a + 2;
    }
