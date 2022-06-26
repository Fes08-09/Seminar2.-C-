// Задача. Написать программу, которая принимает 2 числа и проверяет является ли одно квадратом другого и наоборот

using System;
using static System.Console;

Clear();

WriteLine("Введите первое число а");
int a = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число b");
int b = Convert.ToInt32(ReadLine());

string result = a*a == b
? $"второе число является квадратом первого"
: b*b == a
    ? $"первое число является квадратом второго"
    : $"числа не являются квадратами друг друга";

WriteLine(result);