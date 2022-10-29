// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

int a = 0;
Console.Write($"Введите число: ");
int.TryParse(Console.ReadLine()!, out a);
for (int i = 0; i <= a; i++)
Console.Write($"{i * i * i} ");