/*
перевіряє, чи є задане користувачем число простим. Число вважається простим, якщо воно ділиться лише на 1 і на себе.

*/

Console.Write("Введіть число від 1: ");

int inputNumber = int.Parse(Console.ReadLine());

Console.WriteLine($"Перевірка числа");

bool isPrime = true;

if ( inputNumber >= 2 ) 
{

    for (int i =2 ; i < inputNumber; i++)
    if (inputNumber % i == 0)
    {
        isPrime = false;
        break;
    }

}

if (isPrime)
{
   Console.WriteLine("Це просте число"); 
}

else 
{
   Console.WriteLine("Це не просте число"); 
}
