// Написати програму, що буде видаляти з масиву елемент за вказаним індексом.
Console.Clear();
int[] inputArray = { 5, 32, 7, 40, 17, 45, 8 };

Console.WriteLine("Початковий масив:");
Console.WriteLine("");
for (int i = 0; i < inputArray.Length; i++)
{
    Console.Write(inputArray[i] + " ");
}
Console.WriteLine("");
Console.WriteLine("\nВкажить елемент, який потрібно видалити:");
Console.WriteLine("");
string input = Console.ReadLine();

if (int.TryParse(input, out int indexRemove) && indexRemove >= 0 && indexRemove < inputArray.Length)
{
    int[] newArray = new int[inputArray.Length - 1];

    int j = 0;
    for (int i = 0; i < inputArray.Length; i++)
    {
        if (i == indexRemove)
            continue;

        newArray[j] = inputArray[i];
        j++;
    }
    Console.WriteLine("");
    Console.WriteLine("Масив після видалення:");
    Console.WriteLine("");
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write(newArray[i] + " ");
    }
}
else
{
    Console.WriteLine("Невірний елемент для видалення.");
}

