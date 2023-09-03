﻿/*
**Задача 2:** Задайте значения M и N. Напишите программу, 
которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 5, 6, 7, 8"
*/

Console.Write("Введите число, которое является началом числового промежутка: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число, которое является концом числовго промежутка: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Числовой промежуто от {m} до {n}:  {PrintNum(m,n)}");

string PrintNum(int m, int n)
{
    if (m == n) return m.ToString();
    return (m + " " + PrintNum(m+1, n));

}