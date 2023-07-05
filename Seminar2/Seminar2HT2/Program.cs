// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine ("Введите любое целое число  ");
int number = int.Parse(Console.ReadLine());

int tempAbsUserNumber = Math.Abs(number);
while (number >=1000)
{
    number = number /1000;
}
int number1 = number %10;
Console.WriteLine ($"Третья цифра числа { number1} ");