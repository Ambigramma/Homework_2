// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.WriteLine("Введите день недели от 1 до 7 ");

int days = int.Parse(Console.ReadLine());

if (days <= 5 && days >= 1)
{
    Console.WriteLine("нет, иди работать");
}
if (days == 6 || days == 7)
{
    Console.WriteLine("да, отдыхай");
}
else
{
    Console.WriteLine("попробуй снова");
}