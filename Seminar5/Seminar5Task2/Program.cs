//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int [] PrintArray (int[] mas) // создали массив
{
    Console.WriteLine (" Исходный массив:  "); // выводим
    for (int i  = 0; i<mas.Length; i++) // заполняем
    {
         mas [i] = new Random().Next(-9,10); // говорим что этот массив в диапазон чисел от -9 до 10
         Console.Write("  " + mas[i]); // вывести массив на экран 
    }
    return mas;
}
    void ChangeNum (int [] mas)  
{
         Console.Write (" Новый массив  ");
        for (int i  = 0; i<mas.Length; i++)
        {
        mas [i] *= -1;
         Console.Write("  " + mas[i]);
        }
}
int [] mas = new int [9];
PrintArray (mas);
ChangeNum (mas);
