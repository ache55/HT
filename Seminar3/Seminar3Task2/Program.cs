// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

string GetAreaNumber(int x)
{
    string s="0";
    if (x == 1)
    {
        s = "x > 0, y > 0";
    }
     if (x == 2)
    {
        s = "x > 0, y < 0";
    }
     if (x == 3)
    {
        s = "x < 0, y < 0";
    }
     if (x == 4)
    {
        s = "x > 0, y < 0";
    }
    return s;
}

Console.WriteLine("Введите вашу четверть");
int x = int.Parse(Console.ReadLine());


if (1 <= x && x <= 4)
{
    Console.WriteLine($"Ваш числовой диапазаон значений {GetAreaNumber(x)}");
}
else
{
    Console.WriteLine("Цифра не является номером четверти");
}