//  Напишите программу, которая будет выдавать название дня недели по заданному номеру.

Console.WriteLine ("Введите первое число  ");
int number1 = int.Parse(Console.ReadLine());
if ((number1 <= 7) && (number1>=1)){

    if (number1  == 1 ) {
        Console.WriteLine ("Понедельник");
        }
   else if (number1  == 2 ) {
        Console.WriteLine ("Вторник");
        }
    else if (number1  == 3 ) {
        Console.WriteLine ("среда");
        }
   else if (number1  == 4 ) {
        Console.WriteLine ("четверг");
        }
        else if (number1  == 5 ) {
        Console.WriteLine ("Пятница");
        }
        else if (number1  == 6 ) {
        Console.WriteLine ("Суббота");
        }
        else  (number1  == 7 ) {
        Console.WriteLine ("Воскресенье");
        }
}        
else 
   Console.WriteLine ("Число не в допуске");

Console.WriteLine ("Конец");