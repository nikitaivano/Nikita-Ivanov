//Задание 1. Таблица умножения

//for (int i1 = 1; i1 <= 10; i1++)
//{
//    Console.WriteLine("Таблица умножений на " + i1);
//    for (int i2 = 1; i2 <= 10; i2++)
//        {
//        Console.WriteLine($"{i1} x {i2} = {i1 * i2}");
//        }
//}


//Задание 2. Сумма от 1 до N

//Console.Write("Введите число: ");
//if (int.TryParse(Console.ReadLine(), out int N))
//{
//    int sum = 0;
//    for (int i = 1; i <= N; i++)
//    {
//        sum += i;
//    }
//    Console.Write($"Сумма чисел: {sum}");
//}


//Задание 3. Треугольник из звездочек

//Console.Write("Кол-во ступеней пирамиды: ");
//if (int.TryParse(Console.ReadLine(), out int St))
//{
//    for (int i = 1; i <= St; i++)
//    {
//        for (int k = 0; k < i; k++)
//        {
//            Console.Write("*"); 
//        }
//        Console.WriteLine();
//    }
//}



//Задание 4. Простое число

//Console.Write("Число: ");
//if (int.TryParse(Console.ReadLine(), out int num))
//{
//    for (int i = 2; i <= num - 1; i++)
//    {
//        if (num % i == 0)
//        {
//            Console.WriteLine("Не простое число");
//            return;
//        }
//    }
//    Console.WriteLine("Число простое");
//}



//Задание 6. Перевернуть массив

//int[] numbers = { 1, 2, 3, 4, 5 };
//Console.WriteLine(numbers);
//for (int i = 0; i < numbers.Length / 2; i++)
//{
//    int a = numbers[i];
//    int b = numbers[numbers.Length - i - 1];
//    numbers[i] = b; numbers[numbers.Length - i - 1]=a;
//}
//
//for (int i = 0; i < numbers.Length; i++) 
//{
//    Console.Write($"{numbers[i]} ");
//}


//Задание 7. Сортировка пузырьком


//int[] nums = {2,4,5,1,6,3};
//int i = 1;
//while (i == 1)
//{
//    for (int i2 = 0; i2 < nums.Length - 1; i2++)
//    {
//        if (nums[i2] > nums[i2+1])
//        {
//            int a = nums[i2];
//            int b = nums[i2+1];
//            nums[i2+1] = a; nums[i2] = b;
//            i = 1;
//            break;
//        }
//        else
//        {
//            i = 0;
//        }
//    }
//}
//for (int isa = 0; isa < nums.Length; isa++) 
//{
//    Console.Write($"{nums[isa]} ");
//}




//Задание 8. Сумма главной диагонали

//int[,] matrix = {
//    { 1, 2, 3 },
//    { 4, 5, 6 },
//    { 7, 8, 9 }
//};
//
//int sum = 0;
//for (int i = 0; i < matrix.GetLength(0); i++)
//{
//    sum += matrix[i, i];
//}
//
//Console.WriteLine($"Сумма элементов главной диагонали: {sum}");




// Заключителньое задание
int[] nums = new int[10]; 
Random random = new Random(); 

for (int i = 0; i < 10; i++) {
    nums[i] = random.Next(0, 10); 
}

int minNum = 10;
int maxNum = 0;
int sum = 0;
int count = 0;

Console.WriteLine("Начальный массив:");
for (int i = 0; i < 10; i++) {
    Console.Write($"{nums[i]} ");

    if (nums[i] < minNum) {
        minNum = nums[i];
    }

    if (nums[i] > maxNum) {
        maxNum = nums[i];
    }

    sum = sum + nums[i];

    if (nums[i] % 2 == 0) {
        count++;
    }
}

Console.WriteLine();
Console.WriteLine($"Минимальное число массива: {minNum}");
Console.WriteLine($"Максимальное число массива: {maxNum}");
Console.WriteLine($"Сумма всех чисел массива: {sum}");
Console.WriteLine($"Количество четных чисел в массиве: {count}");

int num = 0;

for (int i = 0; i < (nums.Length / 2); i++) {
    num = nums[i];
    nums[i] = nums[nums.Length - i - 1];
    nums[nums.Length - i - 1] = num;  
}

Console.WriteLine("Перевернутый массив:");

for (int i = 0; i < 10; i++) {
    Console.Write($"{nums[i]} ");
}

for (int i = 0; i < nums.Length - 1; i++) {
    for (int f = i + 1; f < nums.Length; f++) {
        if (nums[i] > nums[f]) {  
            num = nums[i];
            nums[i] = nums[f];
            nums[f] = num;
        }
    } 
}

Console.WriteLine();
Console.WriteLine("Отсортированный массив:");

for (int i = 0; i < 10; i++) {
    Console.Write($"{nums[i]} ");
}