// Написати програму, що буде знаходити суму елементів по діагоналі у двовимірному масиві.

Console.Clear();
int[,] arrayInt = new int[4, 4];

var rand = new Random();

Console.WriteLine();
Console.WriteLine("Створення масиву :");
Console.WriteLine();
for (int i = 0; i < arrayInt.GetLongLength(0); i++)
{
    for (int j = 0; j < arrayInt.GetLength(1); j++)
    {
        arrayInt[i, j] = rand.Next(1, 10);
        Console.Write($"{arrayInt[i, j],4}");

    }
    Console.WriteLine();
}
Console.WriteLine();

int rowsArr = arrayInt.GetLength(0);
int columnsArr = arrayInt.GetLength(1);

int sumEL = 0;

for (int i = 0; i < rowsArr; i++)
{
    for (int j = 0; j < columnsArr; j++)
    {
        if (i == j)
        {
            sumEL = sumEL + arrayInt[i, j];
        }
    }
}

Console.WriteLine($"Сума елементів по діагоналі: {sumEL}");