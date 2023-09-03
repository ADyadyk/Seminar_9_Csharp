/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120

M = 4; N = 8. -> 30
*/

//Метод, который ищет сумму чисел в промежутке от M до N:

int FindSumMN(int numM, int numN)
{
    if (numM == numN) return numN;
    return (numM + FindSumMN(numM+1, numN));
}

// Сама программа:

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Сумма натуральны чисел в промежутке от {m} до {n} равна: {FindSumMN(m,n)}");