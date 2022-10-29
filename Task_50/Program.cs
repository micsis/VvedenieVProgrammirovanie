// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int m;
Console.Write("Введите количество строк для создания двумерного массива: ");
int.TryParse(Console.ReadLine()!, out m);
int n;
Console.Write("Введите количество столбцов для создания двумерного массива: ");
int.TryParse(Console.ReadLine()!, out n);
int[,] array = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = new Random().Next(20);
        Console.Write($"{array[i, j]}     ");
    }
    Console.WriteLine();
}
int a, b;
Console.Write("Введите координату для поиска значения в заданном массиве: ");
int.TryParse(Console.ReadLine()!, out a);
b = a % 10;
a /= 10;
if (a >= array.GetLength(0) || b >= array.GetLength(1) || a < 0)
Console.Write($"Данное значение отсутствует, так как введенная координата находится за границами созданного массива");
else
{
Console.Write($"Согласно введенной координате в массиве находится значение: {array[a, b]}");
}