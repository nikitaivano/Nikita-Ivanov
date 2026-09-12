/*
Console.WriteLine("Напиши число 1-7");
if (int.TryParse(Console.ReadLine(), out int day))
{
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
}

Console.WriteLine("Напиши любой год");
if (int.TryParse(Console.ReadLine(), out int year))
{
    if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
        Console.WriteLine("Високосный");
    else
        Console.WriteLine("Невисокосный");
}


Console.Write("Введите первое число: ");
double.TryParse(Console.ReadLine(), out double a);

Console.Write("Введите второе число: ");
double.TryParse(Console.ReadLine(), out double b);

Console.Write("Введите операцию (+, -, *, /): ");
char.TryParse(Console.ReadLine(), out char op);

switch (op)
{
    case '+': Console.WriteLine($"Результат: {a + b}"); break;
    case '-': Console.WriteLine($"Результат: {a - b}"); break;
    case '*': Console.WriteLine($"Результат: {a * b}"); break;
    case '/': Console.WriteLine(b != 0 ? $"Результат: {a / b}" : "Ошибка: деление на ноль"); break;
    default: Console.WriteLine("Неизвестная операция"); break;
}

*/


Console.Write("Введите аргумент a: ");
double.TryParse(Console.ReadLine(), out double a);

if (a == 0)
{
	Console.WriteLine("Не квадратное уравнение");
}
else
{
	Console.Write("Введите аргумент b: ");
	double.TryParse(Console.ReadLine(), out double b);

	Console.Write("Введите аргумент c: ");
	double.TryParse(Console.ReadLine(), out double c);

	double D = b*b - 4*a*c ;


	if (D > 0)
		Console.WriteLine($"x1= {(-1*b + Math.Sqrt(D)) / (2*a)} x2 = {(-1*b - Math.Sqrt(D)) / (2*a)} ");
	else if (D == 0)
		Console.WriteLine($"x = {(-1*b + Math.Sqrt(D)) / (2*a)}");
	else 
		Console.WriteLine("Решения нет");
}