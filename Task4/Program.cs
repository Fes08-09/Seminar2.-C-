// // Напишите программу, которая принимает на
// вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.

using System;
using static System.Console;

Clear();

int number = new Random().Next(100, 1000);
WriteLine(number);

int a = number/10;
int a1 = a%10;
WriteLine(a1);

