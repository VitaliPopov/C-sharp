﻿// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).



Console.Clear();
Console.WriteLine("Enter quarter: ");
int N = int.Parse(Console.ReadLine());
if (N==1){
    Console.WriteLine("X>0 and Y>0");
} else if (N==2){
    Console.WriteLine("X>0 and Y<0");
} else if (N==3){
   Console.WriteLine("X<0 and Y<0"); 
} else if (N==4){
    Console.WriteLine("X<0 and Y>0");
} else Console.WriteLine("Вне плоскости");
Console.WriteLine();

switch (N)
{
    case 1:{
    Console.WriteLine("X>0 and Y>0");
    break;
    }
    case 2:{
    Console.WriteLine("X>0 and Y<0");
    break;
    }
    case 3:{
    Console.WriteLine("X<0 and Y<0");
    break;
    }
    case 4:{
    Console.WriteLine("X<0 and Y>0");
    break;
    }
    default:{
        Console.WriteLine("Введена неправильная четверть");
        break;
        }
}       
