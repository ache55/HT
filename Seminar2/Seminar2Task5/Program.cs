﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

int a = int.Parse (Console.ReadLine());
int b = int.Parse (Console.ReadLine());

if ((a*a==b)||(b*b==a))
{
    Console.WriteLine ("Является");
}
else 
{
    Console.WriteLine ("Не является");
}