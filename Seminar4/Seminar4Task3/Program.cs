// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int multiply (int numUS)
{
    int temp=1;
    for (int i =1; i<=numUS; i++)
    {
        
        temp = temp *i;
    }
    return temp;
}
int result = (multiply(5));
System.Console.WriteLine(result);
