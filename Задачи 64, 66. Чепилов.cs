﻿// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// НАЧАЛО КОДА ЗАДАЧИ 64

void SortFromNTo1 (int n)
{
   if (n > 1)
    {
        Console.Write($"{n}, ");
        SortFromNTo1 (n - 1);
    }
    if (n == 1)
            Console.Write($"{n}.");
    
}

Console.Write("наше N -> ");
int N = Convert.ToInt32(Console.ReadLine());
while (N < 1)
{
    Console.Write("N должно быть больше 1 или больше! вводи занов -> ");
    N = Convert.ToInt32(Console.ReadLine());
}
SortFromNTo1 (N);

// КОНЕЦ КОДА ЗАДАЧИ 64

//----------------------------------------------

﻿// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// НАЧАЛО КОДА ЗАДАЧИ 66

// int Summa (int m, int n)
// {
//     int summElem = m;
//     if (m-1 == n || n-1 == m)
//         summElem = m+n;
//     else if (m < n)
//         summElem = m + Summa (m+1, n);
//     else if (m > n)
//         summElem = m + Summa (m-1, n);
//     else
//         summElem = m;
//     return summElem;
// }

// Console.Write("наше M-> ");
// int usM = Convert.ToInt32(Console.ReadLine());

// Console.Write("наше N-> ");
// int usN = Convert.ToInt32(Console.ReadLine());

// int usSum = Summa(usM, usN);
// Console.Write($"сумма натуральных элементов в промежутке от M={usM} и N={usN} равна {usSum}.");

// КОНЕЦ КОДА ЗАДАЧИ 66

// наконец-то узнал о существовании "ctrl+K + ctrl+C" и "ctrl+K + ctrl+U"