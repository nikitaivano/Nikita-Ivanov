Console.WriteLine("1 — День недели\n2 — Проверка года\n3 — Калькулятор\n4 — Квадратное уравнение");
Console.Write("Выберите пункт меню (1-4): ");
int.TryParse(Console.ReadLine(), out int mode);

switch (mode)
{
    case 1:
        Console.Write("Напиши число 1-7: ");
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
        else Console.WriteLine("Ошибка: введено не число");
        break;

    case 2:
        Console.Write("Напиши любой год: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                Console.WriteLine("Високосный");
            else
                Console.WriteLine("Невисокосный");
        }
        else Console.WriteLine("Ошибка: введено не число");
        break;

    case 3:
        Console.Write("Введите первое число: ");
        double.TryParse(Console.ReadLine(), out double num1);
        Console.Write("Введите второе число: ");
        double.TryParse(Console.ReadLine(), out double num2);
        Console.Write("Введите операцию (+, -, *, /): ");
        char.TryParse(Console.ReadLine(), out char op);

        switch (op)
        {
            case '+': Console.WriteLine($"Результат: {num1 + num2}"); break;
            case '-': Console.WriteLine($"Результат: {num1 - num2}"); break;
            case '*': Console.WriteLine($"Результат: {num1 * num2}"); break;
            case '/': Console.WriteLine(num2 != 0 ? $"Результат: {num1 / num2}" : "Ошибка: деление на ноль"); break;
            default: Console.WriteLine("Ошибка: неизвестная операция"); break;
        }
        break;

    case 4:
        Console.Write("Введите аргумент a: ");
        double.TryParse(Console.ReadLine(), out double a);

        if (a == 0)
        {
            Console.WriteLine("Не квадратное уравнение (a не должно быть равно 0)");
        }
        else
        {
            Console.Write("Введите аргумент b: ");
            double.TryParse(Console.ReadLine(), out double b);
            Console.Write("Введите аргумент c: ");
            double.TryParse(Console.ReadLine(), out double c);

            double D = b * b - 4 * a * c;

            if (D > 0)
            {
                double x1 = (-b + Math.Sqrt(D)) / (2 * a);
                double x2 = (-b - Math.Sqrt(D)) / (2 * a);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            else if (D == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"x = {x}");
            }
            else
            {
                Console.WriteLine("Решений нет (D < 0)");
            }
        }
        break;

    default:
        Console.WriteLine("Ошибка: неверный пункт меню");
        break;
}