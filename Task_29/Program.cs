// Напишите функцию, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
CreateArray(ref array);
Console.WriteLine();
foreach (var item in array)
Console.Write($"{item} ");
void CreateArray(ref int[] _array)
{
    _array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        _array[i] = new Random().Next(10);
        Console.Write($"{_array[i]} ");
    }
}