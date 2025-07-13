// треба вгадати посимвольно зашифроване слово. Нехай слово вже буде відомо програмі. 
// Користувач може вводити по одній літері та має обмежену кількість невірних спроб. 


Console.Clear();


string guessWord = "собака";
guessWord = guessWord.ToLower();

char[] search = new char[guessWord.Length];
for (int i = 0; i < search.Length; i++)
    search[i] = '*';
//собака -6 
int maxTries = guessWord.Length; 
int wrongTries = 0;

Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
Console.WriteLine("Кількість літер у слові: " + guessWord.Length);
Console.WriteLine("Кількість можливих невірних спроб: " + maxTries);
Console.WriteLine();

while (wrongTries < maxTries)
{
    Console.Write("Введіть вашу літеру: ");
    string input = Console.ReadLine().ToLower();

    if (input == null || input.Trim() == "" || input.Length != 1)
    {
        Console.WriteLine("Введіть лише одну літеру.");
        continue;
    }

    char letter = input[0];
    bool found = false;
    string positions = "";

    for (int i = 0; i < guessWord.Length; i++)
    {
        if (guessWord[i] == letter && search[i] == '*')
        {
            search[i] = letter;
            found = true;
            positions += (i + 1) + ",";
        }
    }

    if (found)
    {
        positions = positions.TrimEnd(',');
        Console.WriteLine($" Така літера є у слові! Позиція літери: {positions}");
    }
    else
    {
        wrongTries++;
        Console.WriteLine($"Такої літери немає! Залишилось спроб: {maxTries - wrongTries}");
    }

    Console.Write("Поточне слово: ");
    for (int i = 0; i < search.Length; i++)
    {
        if (search[i] != '*')
            Console.Write(search[i]);
        else
            Console.Write('*');
    }
    Console.WriteLine("\n");

    bool isGuessed = true;
    foreach (char c in search)
    {
        if (c == '*')
        {
            isGuessed = false;
            break;
        }
    }

    if (isGuessed)
    {
        Console.WriteLine($"Вітаємо, ви вгадали слово! Зашифроване слово: {guessWord}.");
        Console.WriteLine("Дякуємо за гру.");
        return;
    }
}

Console.WriteLine($"Ви програли. Загадане слово було: {guessWord}.");