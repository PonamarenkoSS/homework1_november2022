﻿/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.WriteLine("Первое число больше второго");
}
else 
Console.WriteLine("Второе число больше первого");
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);
int max = a;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine(max);
*/

/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/* Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()!);
if (a%2==0)
{
     Console.WriteLine("Введённое число является чётным");
}
else 
Console.WriteLine("Введённое число не является чётным");
*/

/* Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/* Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int n = 2;
while (n<=N)
    {
        Console.Write($"{n} ");
        n+=2;
    }
*/
