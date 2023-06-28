// Напишите программу, которая на вход принимает число (N), а на выходе 
// показывает все чётные числа от 1 до N.

Console.WriteLine("Напишите число: ");
int a = int.Parse (Console.ReadLine());

int chislo = 0;

while (chislo <= a )
{
    Console.Write(chislo);
    chislo = chislo + 2;
} 