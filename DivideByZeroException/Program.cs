/*
Напишіть програму, яка ділить два числа, введені користувачем.
Якщо користувач вводить 0 як дільник, виведіть повідомлення про помилку.
*/

using System.Text;
Console.OutputEncoding = Encoding.UTF8; // Щоб відображалася українська мова.

Console.WriteLine();
Console.WriteLine("Програма для ділення двох чисел");

Console.WriteLine("");

Console.WriteLine("Ввдедить перше число:");

try
{
    int firstOperand = int.Parse(Console.ReadLine());

    Console.WriteLine("Ввдедить друге число:");
    int secondOperand = int.Parse(Console.ReadLine());

    //double divideByZero = (double) firstOperand / secondOperand;
    // Результат ділення : ∞

    int divideByZero = firstOperand / secondOperand;
    Console.WriteLine($"Результат ділення : {divideByZero}");
}
catch (FormatException)
{
    Console.WriteLine("Введено не ціле число");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Ділення на 0");
}
finally
{
    Console.WriteLine("Програма завершала роботу");
}