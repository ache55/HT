// Напишите программу, которая выводит случайное
// число из отрезка [10, 99] и показывает наибольшую цифру числа.

int randomNumber = new Random().Next(10,100);
Console.WriteLine ($"Случайное число: {randomNumber}");

int a = randomNumber / 10;

int b = randomNumber %10;
if (a>b)
{
    Console.Write ($"Наибольшее число {a}");
}
else 
{
  Console.Write ($"Наибольшее число {b}"); 
}