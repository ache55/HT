// Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

Console.WriteLine("Напишите первое число: ");
int a = int.Parse (Console.ReadLine());
Console.WriteLine("Напишите второе число: ");
int b = int.Parse (Console.ReadLine());
Console.WriteLine("Напишите третье число: ");
int c = int.Parse (Console.ReadLine());
int max = a ;
if (b>max)
{
    max = b;
}
if (c>max)
{
    max = c;
}
Console.WriteLine ($"наибольшее значение:  {max}");
