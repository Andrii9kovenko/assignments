/*
енерує прості числа від 1 до заданого користувачем числа. 
Просте число - це число, яке ділиться лише на 1 і на себе.
*/

Console.Write("Введіть число від 1: ");

int inputNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"Вивод простих чисіл від 1 до {inputNumber}");

for (int i = 2; i <= inputNumber; i++)
{
    bool isPrime = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;
        }
    }
    if (isPrime)
    {
    Console.WriteLine(i);
    }
}