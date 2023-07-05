//
     //   Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2, 1, -7), -> 15.84
// A(7, -5, 0); B(1, -1, 9)-> 11.5

Console.WriteLine("Введите координаты первой точки");
int x1 = int.Parse(Console.ReadLine());
int y1 = int.Parse(Console.ReadLine());
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
int x2 = int.Parse(Console.ReadLine());
int y2 = int.Parse(Console.ReadLine());
int z2 = int.Parse(Console.ReadLine());


double result = Math.Sqrt((Math.Pow(Math.Abs(Math.Abs(x1)-Math.Abs(x2)), 2))+Math.Pow(Math.Abs(Math.Abs(y1)-Math.Abs(y2)), 2)+Math.Pow(Math.Abs(Math.Abs(z1)-Math.Abs(z2)), 2));
Console.WriteLine(result);
