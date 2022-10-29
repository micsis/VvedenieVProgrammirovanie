﻿// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] array = new double[new Random().Next(20, 20)];
for (int Numb=0; Numb<array.Length; Numb++)
{
    array[Numb] = (double)new Random().Next(0, 10*10)/10;
    Console.Write($"{array[Numb]}   ");
}
double min=array[0];
double max=array[0];
foreach (var Number in array)
{
    if (min>Number)
        min=Number;
    if (max<Number)
        max=Number;
}
Console.WriteLine();
Console.Write($"В произвольно заданном массиве минимальным значением является: {min}; максимальным значением является: {max}; а разница между ними составляет {max - min} значений");