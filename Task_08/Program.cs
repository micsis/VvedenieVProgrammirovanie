//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

int usernumb;
Console.Write("Введите произвольное число: "); // от 0 до N
int.TryParse(Console.ReadLine()!, out usernumb);
int a=2;
while (a<=usernumb)
{
    Console.Write($"{a} ");
    a+=2;
}