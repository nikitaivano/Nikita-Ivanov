/*
Console.WriteLine("Напиши число 1-7");
int day = int.Parse(Console.ReadLine());

switch (day)
{
    case 1: Console.WriteLine("Понедельник"); break;
    case 2: Console.WriteLine("Вторник"); break;
    case 3: Console.WriteLine("Среда"); break;
    case 4: Console.WriteLine("Четверг"); break;
    case 5: Console.WriteLine("Пятница"); break;
    case 6: Console.WriteLine("Суббота"); break;
    case 7: Console.WriteLine("Воскресенье"); break;
    default: Console.WriteLine("Ошибка: введите число от 1 до 7"); break;
}
*/

Console.WriteLine("Напиши любой год");
int year = int.Parse(Console.ReadLine());

if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
    Console.WriteLine("Високосный");
else
    Console.WriteLine("Невисокосный");