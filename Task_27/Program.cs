// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int A;
Console.Write("Введите число, сумму значений которого Вы хотите узнать: ");
int.TryParse(Console.ReadLine()!, out A);
Console.Write($"Сумма всех значений введенного Вами числа равна {SumAllNumb(A)}");
int SumAllNumb(int _A)
{
    int Numb = 0;
    int NewNumb = _A;
    while (NewNumb > 0)
    {
        Numb += NewNumb % 10;
        NewNumb /= 10;
    }
    return Numb;
}