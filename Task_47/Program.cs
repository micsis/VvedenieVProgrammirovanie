// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int m;
Console.Write("Введите количество строк для создания двумерного массива: ");
int.TryParse(Console.ReadLine()!, out m);
int n;
Console.Write("Введите количество столбцов для создания двумерного массива: ");
int.TryParse(Console.ReadLine()!, out n);
double[,] array = new double[m, n];
int k=10;
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
    {
        array[i, j] = new Random().Next(-10*k, 10*k)/(double)k;
    }
}
Console.WriteLine();
Console.WriteLine("Вашему вниманию представлен получившийся двумерный массив, заполненный случайными вещественными числами");
for (int i=0; i<m; i++)
{
    for (int j=0; j<n; j++)
        Console.Write($"{array[i, j]}        ");
    Console.WriteLine();
}