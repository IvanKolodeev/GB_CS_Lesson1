﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine ("Enter Number 1");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter Number 2");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("Enter Number 3");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num2>max)
{
    max = num2;
}
if (num3>max)
{
    max = num3;
}

Console.WriteLine("The maximum number is: " + max);