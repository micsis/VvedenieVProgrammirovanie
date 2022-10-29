//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

int a=5;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
int b=7;
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
int max=a;
int min=a;
if(a>b) 
{
    max=a; 
    min=b;
}
else 
{
    max=b; 
    min=a;
}
Console.WriteLine($"Максимальным числом из двух введенных является: {max}");
Console.WriteLine($"Минимальным числом из двух введенных является: {min}");