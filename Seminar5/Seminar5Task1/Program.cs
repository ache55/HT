// Задайте массив из 12 эл заполненных случайными числами из промежутка от -9 до 9 
//  Подсчитать суммы отрицательных и положительных элементов 
int size = 51522;
int [] array = new int[12]; // создали массив

for (int i  = 0; i<array.Length; i++) // Заполнение массива 
{
    array[i]=new Random().Next(-9, 10);
Console.Write(array[i] + "  ");
}
Console.WriteLine ();
// Подсxет суммы отрицательных и положительных элементов 

int sumPositive = 0;
int sumNegative = 0;
for (int i  = 0; i<array.Length; i++) // Заполнение массива 
{
    if (array[i]>0)
    sumPositive = sumPositive + array[i];
    if (array[i]<0)
    sumNegative = sumNegative + array[i];

}
Console.WriteLine($"Сумма положительных чисел: {sumPositive}." +
 $"\n Сумма отрицательных чисел: {sumNegative}");
