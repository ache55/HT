// Напишите программу, которая на вход принимает число (больше 10) и выдает 
// его квадрат (число умноженное на само себя).
Console.Write ("Введите число  ");
int number = int.Parse(Console.ReadLine());
if (number <= 10) 
{
    Console.WriteLine ("Ваше число не соответсвует условию: число менше или равно 10");
}
else
{

int result = number * number;
Console.WriteLine ($"Квадрат вашего чила = {result} ");
}
Console.Write ("THE END");