// 2.Створіть окремий статичний клас. До нього треба додати рекурсивну функцію для обчислення числа Фібоначчі певного порядку. 
// Метод приймає номер числа і повертає число Фібоначчі вказаного номеру. Вважати першим числом послідовності 0, другим — 1. 

Console.Clear();

Console.Write("Введіть номер для числа Фібоначчі: ");
string input = Console.ReadLine();

if (int.TryParse(input, out int j) && j > 0)
{
    int result = Fibonacci(j);
    Console.WriteLine($"Число Фібоначчі :{result}");
}
else
{
    Console.WriteLine("Введіть число більше 0");
}

static int Fibonacci(int j)
{
    if (j == 1)
        return 0;
    if (j == 2)
        return 1;

    return Fibonacci(j - 1) + Fibonacci(j - 2);
}