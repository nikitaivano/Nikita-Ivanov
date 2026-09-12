string text = Console.ReadLine();
char symbol = char.Parse(Console.ReadLine());

int count = 0;

foreach (char c in text)
{
    if (char.ToLower(c) == char.ToLower(symbol))
        count++;
}

Console.WriteLine(count);