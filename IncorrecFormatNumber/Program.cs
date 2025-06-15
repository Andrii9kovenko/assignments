/*
Напишіть програму, яка зчитує число з рядка. Якщо введене значення не є числом, виведіть повідомлення про помилку.
*/

Console.WriteLine("Verification of number input from the console");
Console.WriteLine("");

Console.WriteLine("Enter a number");
string inputValue = Console.ReadLine();
Console.WriteLine("");
try
{
    int inputNumber = int.Parse(inputValue);
    Console.WriteLine($"Result: {inputNumber}");
    Console.WriteLine("");
}
catch (System.Exception)
{
    Console.WriteLine($"The entered value is not a number.");
}
finally
{
    Console.WriteLine("Program ended");
}




