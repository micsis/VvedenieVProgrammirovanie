//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

int numb;
string usernumb;
Console.Write("Введите число от 1 до 7: ");
usernumb = Console.ReadLine()!;
numb = int.Parse(usernumb);
Console.Write("Является введенное число (день недели) выходным днем? Ответ: ");
if(numb>5)
{
   Console.Write("да");
}
else
Console.Write("нет");