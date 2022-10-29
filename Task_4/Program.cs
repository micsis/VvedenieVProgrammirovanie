//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

int a=2;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out a);
int b=3;
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out b);
int c=7;
Console.Write("Введите третье число: ");
int.TryParse(Console.ReadLine()!, out c);
int max=a;
int min=a;
if(a>b) 
{
    if(a>c)
    {
        max=a;
    }
    else
    {
        max=c;
    }
}
else if(b>a)
{
    if(b>c)
    {
        max=b;
    }
else
    max=c;
}
Console.WriteLine($"Максимальным числом из трех введенных является: {max}");