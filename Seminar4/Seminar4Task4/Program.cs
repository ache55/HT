﻿// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

int [] Array = new int [8];

int [] Random (int [] array)
{

for (int i=0; i<array.Length; i++)
{
array [i]= new Random().Next(0,2);
System.Console.WriteLine(array[i]);
}
return array;
}
int[] Array2= Random(Array);
System.Console.WriteLine();
