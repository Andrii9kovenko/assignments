/*
Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення 
(у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – 
на 2, ..., в останньому – на 9). Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.
*/

Console.Clear();
Console.WriteLine("Масив розміру 9х9 з результатами таблиці множення");
Console.WriteLine();

int[,] arrayNineOnNine = new int[9, 9];


for (int i = 0; i < arrayNineOnNine.GetLength(0); i++)
{
    for (int j = 0; j < arrayNineOnNine.GetLongLength(1); j++)
    {
        arrayNineOnNine[i, j] = (i +1) * (j+1);
    }
}

for (int i = 0; i < arrayNineOnNine.GetLength(0); i++)
{
    for (int j = 0; j < arrayNineOnNine.GetLongLength(1); j++)
    {
       // Console.Write(arrayNineOnNine[i, j] + "   ");
        Console.Write($"{arrayNineOnNine[i,j] ,3 }");
    }
     Console.WriteLine();
}
