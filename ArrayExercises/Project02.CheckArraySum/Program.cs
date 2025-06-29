/*
Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.
*/
Console.Clear();

int[] arrayNums = new int[10];

var rand = new Random();

for (int i = 0; i < arrayNums.Length; i++)
{
    arrayNums[i] = rand.Next(-10, 10);
}


Console.WriteLine("Вивід на екран випадкових значень масиву");
Console.WriteLine();
foreach (var item in arrayNums)
{
    Console.Write(item + ";");
}
Console.WriteLine();
Console.WriteLine("Вивід на екран елементів масиву з парним індексом.");
Console.WriteLine();

var sumArrayNum = 0;
for (int i = 2; i < arrayNums.Length; i += 2)
{
    Console.Write(arrayNums[i] + ";");
    sumArrayNum += arrayNums[i];
}
Console.WriteLine();
//Console.WriteLine("Сума елементів масиву з парним індексом.");
//Console.WriteLine(sumArrayNum);

if (sumArrayNum > 1)
{
    Console.WriteLine( $"Cума елементів масиву з пункту 1 є невід'ємне число: {sumArrayNum}");
}
else if (sumArrayNum < 0)
{
    Console.WriteLine($"Cума елементів масиву з пункту 1 від'ємне число : {sumArrayNum}");
}
else
{
    Console.WriteLine($"Cума елементів масиву з пункту 1 = 0: {sumArrayNum}");
}




