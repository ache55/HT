// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// (Math.Pow(2, 3)) - квадрат числа
// (Math.Sqrt(9)) - квадратный корень

Console.WriteLine("Введите координаты первой точки");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Math.Abs(Math.Abs(x1)-Math.Abs(x2)), 2)+Math.Pow(Math.Abs(Math.Abs(y1)-Math.Abs(y2)), 2));
Console.WriteLine(result);
