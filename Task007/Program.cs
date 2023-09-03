/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9

m = 3, n = 2 -> A(m,n) = 29
*/

//Метод, вычисляющий функцию Аккермана:

int GetAckermann(int m, int n)
{
    if (m == 0) return n + 1;
    if (m > 0 && n == 0) return (GetAckermann(m-1, 1));
    else return(GetAckermann(m-1, GetAckermann(m, n-1)));
}

// Сама программа:

Console.Write("Введите число m: ");
int numM = int.Parse(Console.ReadLine()!);

Console.Write("Введите число n: ");
int numN = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Значение Функцмм Аккермана А({numM},{numN}) равно: {GetAckermann(numM,numN)}");