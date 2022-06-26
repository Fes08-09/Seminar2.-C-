using System;
using static System.Console;

Clear();

int number = new Random().Next(10, 100);
WriteLine($"Случайное число = {number}"); // для подписи при выводе данных. $ - означает {} - служебные символы

int a1 = number/10;
int a2 = number%10;

if(a1 > a2)
{
    WriteLine($"Максимальное число = {a1}");
}
else
{
    WriteLine($"Максимальное число = {a2}");
}


