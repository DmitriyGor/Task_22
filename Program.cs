﻿/*
Задача 22
Напишите программу, которая принимает на входе число (N) и выдает таблицу квадратов
чисел от 1 до N
5 -> 1, 4, 9, 16, 25
2 -> 1, 4
*/

Console.Write("Введите число N: "); // Введите число N
int N = Convert.ToInt32(Console.ReadLine());
// (точка входа)
Console.WriteLine($"таблица квадратов чисел от 1 до {N}:  ");
/*for (int i = 1; i <= N; i++)
{
   Console.Write(Math.Pow(i, 2) + "\t"); // i*i
   // \t = Tab (1    2    3) - литерал, который ставит 4 пробела между цифрами
}
*/
int i = 1;
while (i <= N)
{
   Console.Write(Math.Pow(i, 2) + "\t"); // i*i
   i++;
}