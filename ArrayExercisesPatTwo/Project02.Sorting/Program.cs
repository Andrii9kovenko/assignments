//Написати програму, що буде сортувати за зростанням елементи двовимірного масиву.

Console.Clear();

int[,] array = {
            { 5, 37, 9 },
            { 1, 20, 3 },
            { 15, 4, 7 }
        };

int rowsValue = array.GetLength(0);
int columnValue = array.GetLength(1);

Console.WriteLine("Масив для сортування:");
Console.WriteLine("");
for (int i = 0; i < rowsValue; i++)
{
    for (int j = 0; j < columnValue; j++)
    {
        //Console.Write($"{array[i, j],3}");
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}

int[] tempArray = new int[rowsValue * columnValue];
int index = 0;

for (int i = 0; i < rowsValue; i++)
    for (int j = 0; j < columnValue; j++)
        tempArray[index++] = array[i, j];

Array.Sort(tempArray);

index = 0;
for (int i = 0; i < rowsValue; i++)
    for (int j = 0; j < columnValue; j++)
        array[i, j] = tempArray[index++];

Console.WriteLine("");
Console.WriteLine("Вивід після сотрування:");
Console.WriteLine("");
for (int i = 0; i < rowsValue; i++)
{
    for (int j = 0; j < columnValue; j++)
    {
        //Console.Write($"{array[i, j],3}");
        Console.Write($"{array[i, j]}\t");
    }
    Console.WriteLine();
}
