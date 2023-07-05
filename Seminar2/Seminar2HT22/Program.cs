// Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

Console.WriteLine ("Введите любое целое число  ");
int number = int.Parse(Console.ReadLine());

string userNumberStr = Math.Abs (number).ToString();
if (userNumberStr.Length < 3)
{
    Console.WriteLine ("В вашем числе нет 3 цифры ");
}
Console.WriteLine ($"Третья цифра числа { userNumberStr[2]} ");