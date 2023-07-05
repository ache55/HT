//Напишите программу, которая выводит случайное 
// трехзначное число и удаляет вторую цифру этого числа.

int randomNumber = new Random().Next(10,1000);
Console.WriteLine ($"Случайное число: {randomNumber}");
Console.WriteLine ($"Случайное число: {randomNumber/100}");
Console.WriteLine ($"Результат: {((randomNumber/100)*10)+(randomNumber%10)}");