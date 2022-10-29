// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Numbers;
Console.WriteLine("Введите некоторое количество чисел через кнопку Enter: ");
int.TryParse(Console.ReadLine()!, out Numbers);
int Numb=0;
for (int i=0; i<Numbers; i++)
{
    int Count;
    int.TryParse(Console.ReadLine()!, out Count);
    if (Count>0)
        Numb++;
}
Console.Write($"Количество положительных чисел, среди введнных пользователем, равно {Numb}");