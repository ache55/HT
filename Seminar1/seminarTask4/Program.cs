// Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает последнюю цифру этого числа.

Console.WriteLine ("Введите трехзначное число  ");
int number = int.Parse(Console.ReadLine());
if (number > 99 && number<1000)
{
    int number2 = number % 10;
    Console.WriteLine ($"последняя цифра числа = {number2}");

}
else Console.WriteLine ("число не трехзначное ");