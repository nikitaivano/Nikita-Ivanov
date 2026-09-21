Console.Write("Выберите номер задачи (1-4): ");
if (int.TryParse(Console.ReadLine(), out int zadacha))
{
    switch (zadacha)
    {
        case 1:
            Console.Write("Напишите целое число и поменяю десятки с единицами: ");
            if (int.TryParse(Console.ReadLine(), out int chislo))
            {
                int des = Math.Abs(chislo % 100 / 10);
                int ed = Math.Abs(chislo % 10);

                int ch = chislo / 100 * 100 + ed * 10 + des;
                Console.WriteLine("Результат: " + ch);
            }
            else
            {
                Console.WriteLine("Ошибка: это не число");
            }
            break;

        case 2:
            Console.Write("Напишите первое число: ");
            if (int.TryParse(Console.ReadLine(), out int ch1))
            {
                Console.Write("Напишите второе число: ");
                if (int.TryParse(Console.ReadLine(), out int ch2))
                {
                    long sum = (long)ch1 + ch2;
                    if (sum > int.MaxValue || sum < int.MinValue)
                    {
                        Console.WriteLine("Ошибка переполнение INT");
                    }
                    else
                    {
                        Console.WriteLine("Сумма: " + sum);
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: это не число");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: это не число");
            }
            break;

        case 3:
            Console.Write("Напишите номер месяца (1-12): ");
            if (int.TryParse(Console.ReadLine(), out int month))
            {
                if (month == 12 || month == 1 || month == 2)
                {
                    Console.WriteLine("Зима");
                }
                else if (month >= 3 && month <= 5)
                {
                    Console.WriteLine("Весна");
                }
                else if (month >= 6 && month <= 8)
                {
                    Console.WriteLine("Лето");
                }
                else if (month >= 9 && month <= 11)
                {
                    Console.WriteLine("Осень");
                }
                else
                {
                    Console.WriteLine("Ошибка: такого месяца нет");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: это не число");
            }
            break;

        case 4:
            Console.Write("Сторона A треугольника: ");
            if (int.TryParse(Console.ReadLine(), out int stA))
            {
                Console.Write("Сторона B треугольника: ");
                if (int.TryParse(Console.ReadLine(), out int stB))
                {
                    Console.Write("Сторона C треугольника: ");
                    if (int.TryParse(Console.ReadLine(), out int stC))
                    {
                        if ((stA + stB > stC) && (stA + stC > stB) && (stB + stC > stA))
                        {
                            Console.WriteLine("Такой треугольник существует");
                        }
                        else
                        {
                            Console.WriteLine("Такой треугольник НЕ существует");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: это не число");
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка: это не число");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: это не число");
            }
            break;

        default:
            Console.WriteLine("Ошибка: задачи с таким номером нет");
            break;
    }
}
else
{
    Console.WriteLine("Ошибка: это не число");
}