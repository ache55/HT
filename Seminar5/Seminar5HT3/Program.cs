﻿// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива

//Methods////////////////////////
double[] GetRandomDoubleArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
       {
        array[i] = Math.Round(new Random().NextDouble () * new Random().Next(1,12),2);
       } 
        return array;
}
    void PrintDoubleArrayToConsole (double[]array)
{
    string str = string.Join(' ', array);
    Console.WriteLine($"Массив: {str}");
}
    
double [] array = GetRandomDoubleArray(size:10);
PrintDoubleArrayToConsole(array);

double max = array [0];
double min = array [0];
for (int i = 0; i < array.Length; i++)
{
    if (array [i]>max)
    max = array [i];

    if (array [i] < min)
    min = array [i];
}
Console.WriteLine ($"Разница между макс.{max} и мин. {min} элементом {max-min}");


   