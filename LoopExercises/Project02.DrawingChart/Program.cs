/*
Користувач повинен ввести кількість рядків графіка. 
Кожен рядок графіка має містити відповідну кількість зірочок.
*/

Console.WriteLine("Введіть кількість рядків:");

string inputValue = Console.ReadLine();

Console.WriteLine("Результат:");

for (int i = 1; i <= Convert.ToInt16(inputValue); i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }

    Console.WriteLine();
}