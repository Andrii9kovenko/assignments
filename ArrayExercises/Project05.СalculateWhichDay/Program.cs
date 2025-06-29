/*
За допомогою enum створити програму, що буде запитувати у користувача кількість днів,
 а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат.
*/

Console.Clear();

Console.WriteLine("Введіть кількість днів:");
var inputDay = Console.ReadLine();

if (int.TryParse(inputDay, out int searchDay))
{
    var firstDay = (int)DayOfWeek.Monday;  // Починаємо від Monday = 0

    // Обчислюємо день тижня через введену кількість днів
    var resultDay = (firstDay + searchDay) % 7;

    DayOfWeek result = (DayOfWeek)resultDay;

    Console.WriteLine($"День: {result}");
}
else
{
    Console.WriteLine("Ви ввели некоректне число.");
}

Console.WriteLine();

enum WeekDays
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}

