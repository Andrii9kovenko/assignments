/*
Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. 
Після введення значень програма має обчислити та вивести оплату за день.
*/

Console.WriteLine("Введіть кількість відпрацьованих днів:");
string input = Console.ReadLine();

if (!int.TryParse(input, out int countDay))
{
    Console.WriteLine("Необхідно ввести ціле число");
}
else
{
    double allSalary = 0;
    const int workHours = 8;
    for (int i = 1; i <= countDay; i++)
    {
        Console.WriteLine($"Введіть розмір годинної ставки в день {i} :");

        if (double.TryParse(Console.ReadLine(), out double salaryHours))
        {
            double salaryDay = workHours * salaryHours;
            allSalary += salaryDay;
        }
        else
            Console.WriteLine("Некоректне значення зарплати");
    }
    Console.WriteLine($"Зарплата за {input} днів складає : {allSalary}");
}

