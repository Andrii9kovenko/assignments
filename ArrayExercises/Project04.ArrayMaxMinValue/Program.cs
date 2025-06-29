/*
. Створити двовимірний масив 5х5. Заповнити його будь-якими числами. Визначити та вивести на екран:
 а) максимальний елемент масиву;
  б) мінімальний елемент масиву; 
в) координати мінімального елемента масиву. 
г) координати максимального елемента масиву.
*/

Console.Clear();
int[,] arrayInt = new int[5, 5];

var rand = new Random();

Console.WriteLine();
Console.WriteLine("Створення масиву 5х5:");
Console.WriteLine();
for (int i = 0; i < arrayInt.GetLongLength(0); i++)
{
    for (int j = 0; j < arrayInt.GetLength(1); j++)
    {
        arrayInt[i, j] = rand.Next(1, 50);
        Console.Write($"{arrayInt[i, j],4}");

    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("Максимальний елемент масиву:");

Console.WriteLine();

// Знаходимо максимальний елемент
int maxValue = arrayInt[0, 0];
int minValue = arrayInt[0, 0];
int rowPositionMax = 0;
int colPositionMax = 0;
int rowPositionMin = 0;
int colPositionMin = 0;

for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (arrayInt[i, j] > maxValue)
        {
            maxValue = arrayInt[i, j];
            rowPositionMax = i;
            colPositionMax = j;
        }
    }
}

Console.WriteLine(maxValue);
Console.WriteLine();
Console.WriteLine("Коордінати максимального елементу:");

Console.WriteLine($"{rowPositionMax} : {colPositionMax}");

Console.WriteLine();

Console.WriteLine("Мінімальний елемент масиву:");

Console.WriteLine();


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (arrayInt[i, j] < minValue)
        {
            minValue = arrayInt[i, j];
            rowPositionMin = i;
            colPositionMin = j;
        }
    }
}

Console.WriteLine(minValue);
Console.WriteLine();
Console.WriteLine("Коордінати максимального елементу:");

Console.WriteLine($"{rowPositionMin} : {colPositionMin}");