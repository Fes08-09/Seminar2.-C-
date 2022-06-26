using System;
using static System.Console;

Clear();

// int number = new Random().Next(10, 100);
int number = 77;
WriteLine($"Случайное число = {number}"); // для подписи при выводе данных. $ - означает {} - служебные символы


string answer = number/10>number%10
?$"Максимальное число = {number/10}" //? - если условие выполняется выводи это действие
:number/10<number%10 // : - "иначе" проверь это выражение
    ?$"Максимальное число = {number%10}" // ? - если оно выполняется выведи это решение
    :"Числа равны"; // : - иначе выведи данное сообщение

Console.WriteLine(answer);