int chislo;
chislo=int.Parse(Console.ReadLine());
if (chislo == 7)
	Console.WriteLine("Ты угадал");
else if (chislo > 7)
	Console.WriteLine("Число меньше");
else 
	Console.WriteLine("Число больше");