// Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.

Console.WriteLine ("Введите трехзначное число  ");
int number = int.Parse(Console.ReadLine());

 int number2 = number % 100;
    Console.WriteLine ($"вторая цифра числа = {number2/10}");
