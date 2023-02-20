/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int n = number.Length;

if (n == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($" Да: {number}");
    }
    else
    {
        Console.WriteLine($"Нет: {number}");
    }
}
else
{
    Console.WriteLine($"Число не пятизначное: {number}");
}