// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа.

Console.WriteLine("Введите трехзначное число ");

int GetSecondNumber(int number)
{
    return number/10%10;   
}

int number = int.Parse(Console.ReadLine());

Console.WriteLine(GetSecondNumber(number));