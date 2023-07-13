// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5
void kol (int n)
{int k = 0;
while (n>0)
{
    n=n/10;
    k++;
}
Console.WriteLine(k);
}
Console.WriteLine("Введите ваше число:  ");
int n = int.Parse(Console.ReadLine());

kol(n);