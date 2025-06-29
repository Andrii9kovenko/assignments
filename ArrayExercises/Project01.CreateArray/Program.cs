/*
1. Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, 
використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
//  Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)
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

for (int i =2; i <arrayNums.Length; i+=2)

Console.Write(arrayNums[i]+ ";");