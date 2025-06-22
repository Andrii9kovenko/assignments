/*
Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
Після отримання всіх значень програма має обчислити та вивести середній заробіток.
*/

Console.WriteLine("Введіть кількість працівників:");
string input = Console.ReadLine();

if (!int.TryParse(input, out int countEmoloyee))
{
    Console.WriteLine("Необхідно ввести ціле число");
}
else
{
    double allSalary = 0;
    for (int i = 1; i <= countEmoloyee; i++)
    {
        Console.WriteLine($"Введіть зарплату працівника {i} :");

        if (double.TryParse(Console.ReadLine(), out double salary))
            allSalary += salary;

        else
            Console.WriteLine("Некоректне значення зарплати");
    }

    var averageSalary = allSalary / countEmoloyee;
    Console.WriteLine($"Середня зарплата складає : {averageSalary}");

}

