﻿// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно

int a = int.Parse (Console.ReadLine());
int b = int.Parse (Console.ReadLine());

if (a % b == 0)
{
      Console.Write ("Кратно");
}
else
{
     Console.Write ("Не кратно");
}
