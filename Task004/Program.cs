/*
**Задача 3:** Напишите программу, которая на вход принимает два числа A и B,
 и возводит число А в целую степень B с помощью рекурсии.

A = 3; B = 5 -> 243 (3⁵)

A = 2; B = 3 -> 8
*/

Console.Write("Введите число для возведения в степень: ");
int number = int.Parse(Console.ReadLine()!);

Console.Write("Введите степень, в которую надо возвести число: ");
int range = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {number} в степени {range} равно: {Pow(number, range)}");

int Pow(int number, int range)
{
    if (range == 0) return 1;
    if (range == 1) return number;
    return (number * Pow(number, range - 1));
}