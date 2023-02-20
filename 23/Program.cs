/*
Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.Clear();
int ReadInt(string input)
{
    Console.Write(input);
    return Convert.ToInt32(Console.ReadLine());
}

int x = ReadInt("Введите число N: ");

for (int i = 1; i <= x; i++)
{ 
    Console.Write($"{i*i*i} ");
}
