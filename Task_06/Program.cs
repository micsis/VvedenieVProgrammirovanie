﻿//Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет

Console.WriteLine("Введите число: ");
int usernumb = Console.Read();
if (usernumb%2==0)
{
    Console.Write("Введенное число является четным");
}
else
{
    Console.Write("Введенное число не является четным");
}