using System.Text;
Console.OutputEncoding = Encoding.UTF8; // Щоб відображалася українська мова.

Console.WriteLine();

Console.WriteLine("Для отримання назви дня необхідно вказати номер з 1-7");

Console.WriteLine($"Введить номер дня:");

string dayNumber = Console.ReadLine();

switch (dayNumber)
{
    case "1":
        Console.WriteLine("Понеділок");
        break;
    case "2":
        Console.WriteLine("Вівторок");
        break;
    case "3":
        Console.WriteLine("Середа");
        break;
    case "4":
        Console.WriteLine("Четвер");
        break;
    case "5":
        Console.WriteLine("П’ятниця");
        break;
    case "6":
        Console.WriteLine("Субота");
        break;
    case "7":
        Console.WriteLine("Неділя");
        break;
    default:
        Console.WriteLine("Необхідно вказувати лише додатні цілі числа з 1-7");
        break;
} 