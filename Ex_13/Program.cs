﻿// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.

Console.WriteLine("Введите число ");


int num = int.Parse(Console.ReadLine());

while (num > 999)
{
 num /=10;
}

if (num<1000 & num>99)
{
        Console.WriteLine(num%10);
}
else
{
        Console.WriteLine("Третьего нет");        
}