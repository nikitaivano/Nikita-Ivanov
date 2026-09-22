Console.WriteLine("1. Таблица умножения");
Console.WriteLine("2. Сумма от 1 до N");
Console.WriteLine("3. Треугольник из звездочек");
Console.WriteLine("4. Простое число");
Console.WriteLine("5. Переворот массива");
Console.WriteLine("6. Сортировка пузырьком");
Console.WriteLine("7. Сумма главной диагонали");
Console.WriteLine("8. Финальное задание");
Console.Write("\nВыбор: ");
if (int.TryParse(Console.ReadLine(), out int choice) == false)
{
    Console.WriteLine("Неверный ввод. Введите число!");
    return;
}

switch (choice)
{
    case 1:

        //Задание 1. Таблица умножения

        for (int i1 = 1; i1 <= 10; i1++)
        {
            Console.WriteLine("Таблица умножений на " + i1);
            for (int i2 = 1; i2 <= 10; i2++)
            {
                Console.WriteLine($"{i1} x {i2} = {i1 * i2}");
            }
        }
        break;

    case 2:
        {
            //Задание 2. Сумма от 1 до N

            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out int N))
            {
                int sum = 0;
                for (int i = 1; i <= N; i++)
                {
                    sum += i;
                }
                Console.Write($"Сумма чисел: {sum}");
            }
        }
        break;

    case 3:
        //Задание 3. Треугольник из звездочек

        Console.Write("Кол-во ступеней пирамиды: ");
        if (int.TryParse(Console.ReadLine(), out int St))
        {
            for (int i = 1; i <= St; i++)
            {
                for (int k = 0; k < i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        break;

    case 4:
        //Задание 4. Простое число

        Console.Write("Число: ");
        if (int.TryParse(Console.ReadLine(), out int num))
        {
            for (int i = 2; i <= num - 1; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("Не простое число");
                    return;
                }
            }
            Console.WriteLine("Число простое");
        }
        break;

    case 5:
        {
            //Задание 5. Перевернуть массив

            int[] numbers = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < numbers.Length / 2; i++)
            {
                int a = numbers[i];
                int b = numbers[numbers.Length - i - 1];
                numbers[i] = b; numbers[numbers.Length - i - 1] = a;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
        break;

    case 6:
        {
            //Задание 6. Сортировка пузырьком

            int[] nums = { 2, 4, 5, 1, 6, 3 };
            int i = 1;
            while (i == 1)
            {
                bool swapped = false;
                for (int i2 = 0; i2 < nums.Length - 1; i2++)
                {
                    if (nums[i2] > nums[i2 + 1])
                    {
                        int a = nums[i2];
                        int b = nums[i2 + 1];
                        nums[i2 + 1] = a; nums[i2] = b;
                        swapped = true;
                    }
                }

                if (!swapped)
                {
                    i = 0;
                }
            }
            for (int isa = 0; isa < nums.Length; isa++)
            {
                Console.Write($"{nums[isa]} ");
            }
        }
        break;

    case 7:
        {
            //Задание 7. Сумма главной диагонали
            int[,] matrix = {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            };
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine($"Сумма элементов главной диагонали: {sum}");
        }
        break;

    case 8:
        {
            // 8 Заключительное задание

            int[] numbers = new int[10];

            Console.WriteLine("--- Ввод массива вручную (10 чисел) ---");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Введите число {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Неверный ввод. Введите целое число: ");
                }
            }

            Console.WriteLine("\nВыберите действие:");
            Console.WriteLine("1. Вывести введенный массив");
            Console.WriteLine("2. Найти min, max, сумму и четные");
            Console.WriteLine("3. Перевернуть массив");
            Console.WriteLine("4. Отсортировать пузырьком");
            Console.Write("Ваш выбор: ");

            int subChoice;
            while (!int.TryParse(Console.ReadLine(), out subChoice))
            {
                Console.Write("Ошибка! Введите число (1-4): ");
            }

            switch (subChoice)
            {
                case 1:
                    Console.Write("\nВведённый массив: ");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                    Console.WriteLine();
                    break;

                case 2:
                    {
                        int min = numbers[0];
                        int max = numbers[0];
                        int sum = 0;
                        int evenCount = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            if (numbers[i] < min) min = numbers[i];
                            if (numbers[i] > max) max = numbers[i];
                            sum += numbers[i];
                            if (numbers[i] % 2 == 0) evenCount++;
                        }

                        Console.WriteLine($"\nMin: {min}");
                        Console.WriteLine($"Max: {max}");
                        Console.WriteLine($"Сумма: {sum}");
                        Console.WriteLine($"Четных чисел: {evenCount}");
                    }
                    break;

                case 3:
                    for (int i = 0; i < numbers.Length / 2; i++)
                    {
                        int a = numbers[i];
                        int b = numbers[numbers.Length - i - 1];
                        numbers[i] = b;
                        numbers[numbers.Length - i - 1] = a;
                    }

                    Console.Write("\nПеревернутый массив: ");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                    Console.WriteLine();
                    break;

                case 4:
                    for (int i = 0; i < numbers.Length - 1; i++)
                    {
                        for (int j = 0; j < numbers.Length - 1 - i; j++)
                        {
                            if (numbers[j] > numbers[j + 1])
                            {
                                int temp = numbers[j];
                                numbers[j] = numbers[j + 1];
                                numbers[j + 1] = temp;
                            }
                        }
                    }

                    Console.Write("\nОтсортированный массив: ");
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        Console.Write($"{numbers[i]} ");
                    }
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Неверный пункт меню.");
                    break;
            }
        }
        break;
}