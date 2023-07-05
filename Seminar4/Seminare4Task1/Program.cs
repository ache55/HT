// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
//7 -> 28
//4 -> 10
//8 -> 36

int GetSum(int Limit)
{
    int sum = 0;
    for (int i = 1; i <= Limit; i++)
    {
        sum = sum + 1;
    }
    return sum;
}
 int sum = GetSum (Limit:5);
 Console.WriteLine(sum);