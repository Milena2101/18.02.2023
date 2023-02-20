/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

Console.Clear();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}


int x1 = ReadInt("Координата x первой точки: ");
int y1 = ReadInt("Координата y первой точки: ");
int m1 = ReadInt("Координата m первой точки: ");
int x2 = ReadInt("Координата x второй точки: ");
int y2 = ReadInt("Координата y второй точки: ");
int m2 = ReadInt("Координата m второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = m1 - m2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Расстояние между ними {length}");