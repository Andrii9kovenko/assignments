/*
Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число, 
а потім генерує таблицю множення для цього числа від 1 до 10.
*/

Console.WriteLine("Введить число для множення:");
string input = Console.ReadLine();

if (!int.TryParse(input, out int numberInput))
{
    Console.WriteLine("Необхідно ввести ціле число");
}

else
{
    Console.WriteLine($"Таблиця множення для числа {numberInput}: ");
    for (int i = 1; i <= 10; i++)

    Console.WriteLine($"{numberInput} * {i} = " + i * numberInput);
}
