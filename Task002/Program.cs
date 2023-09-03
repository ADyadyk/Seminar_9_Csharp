/*
**Задача 1:** Задайте значение N. Напишите программу, 
которая выведет все натуральные числа в промежутке от 1 до N.

N = 5 -> "1, 2, 3, 4, 5"

N = 6 -> "1, 2, 3, 4, 5, 6"
*/

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(Answer(1, number));

//Метод

string Answer(int alpha, int numbers)
{
    if (alpha == numbers) return alpha.ToString();
    return (alpha + " " + Answer(alpha+1, numbers));
}