﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1)
{
   Console.WriteLine("Операция невыполнима");
} 
for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"{i*i*i}");
}
