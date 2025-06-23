/*
апишіть програму, яка генерує перші N чисел Фібоначчі. 
Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.
*/

Console.WriteLine("Enter the limit number:");

string inputlimitNumber = Console.ReadLine();

if (!int.TryParse(inputlimitNumber, out int result))
{
    Console.WriteLine("It is necessary to enter an integer.");
}

else
{
    Console.WriteLine();
    Console.WriteLine("Fibonacci Sequence:");
    int firstNuber = 0;
    int secondNumber = 1;

    for (int i = 0; i < result; i++)
    {

        var nextNuber = firstNuber + secondNumber;
        firstNuber = secondNumber;
        secondNumber = nextNuber;
        Console.WriteLine(nextNuber);

    }

}
