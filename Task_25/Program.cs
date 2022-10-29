// Напишите функцию, используя цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int A;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine()!, out A);
int B;
Console.Write("Введите второе число: ");
int.TryParse(Console.ReadLine()!, out B);
Console.Write($"Результатом возведения первого числа в натуральную степень значения второго числа, будет являться: {Exp(A,B)}");
int Exp(int A, int B)
{
int Numb = A;
for (int i = 1; i < B; i++)
Numb = Numb*A;
return Numb;

}