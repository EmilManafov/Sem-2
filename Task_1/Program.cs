﻿/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. (Если решаете математически через рандом, то проверка не нужна на трехзначность. Если через строки, то она обязательна)
456 -> 5
782 -> 8
918 -> 1*/

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine());
string str = num.ToString();

if (str.Length == 3) Console.WriteLine($"Вторая цифра числа равна {str[1]}");
else Console.WriteLine("Введено не трёхзначное число! ");
  