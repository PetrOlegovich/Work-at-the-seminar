﻿// Надо написать программу которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.

Console.WriteLine("Введите перве число : ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число : ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == numberB * numberB)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else 
    Console.WriteLine($"Число {numberA}  НЕ ЯВЛЯЕТСЯ квадратом числа {numberB}");
