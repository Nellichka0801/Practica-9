﻿// Задайте значение N. Напишите программу, которая выведет 
//все натуральные числа в промежутке от N до 1. Выполнить с 
//помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
// Console.WriteLine("Hello, World!");

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
NumbersFromNumberToOne(number);


void NumbersFromNumberToOne(int n)
{
    if (n >= 1)
    {
        Console.Write(n);
        if(n !=1){
            Console.Write(", ");
        }
        
        NumbersFromNumberToOne(n - 1);
    }
}
