﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число");
int numberA=Convert.ToInt32(Console.ReadLine());
int numberB=0;
for (int i=1; i<=numberA; i++)
{
 numberB=i*i*i;
 System.Console.WriteLine(numberB);
}

