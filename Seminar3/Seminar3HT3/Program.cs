// Напишите программу, которая принимает на вход пятизначное 
// число и проверяет, является ли оно палиндромом.

bool palindrom (int number)
{

    if (number<0)
    {
        return false;
    }
    int revNumber=0;
    int tempSourceNumber = number;
    while (tempSourceNumber !=0)
    {
        // крайняя правая цифра исходонго числа
        int temp = tempSourceNumber % 10; 
     
        // формирование нового числа
        revNumber = (revNumber *10) + temp;
        // уменьшение исходного числа
        tempSourceNumber=tempSourceNumber/10; 

    }
    if (revNumber == number)
   return true;

   return false;
}
Console.WriteLine(palindrom(123258));