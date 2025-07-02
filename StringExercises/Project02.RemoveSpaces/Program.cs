/*
Опис: Ви отримали рядок, який містить декілька слів, розділених комами.
 Ваша мета - видалити всі пробіли з цього рядка та вивести результат.
*/

using System.IO.Pipelines;
Console.Clear();
var stringName = @"Опис: Ви отримали рядок, який містить декілька слів, розділених комами. Ваша мета - видалити всі пробіли з цього рядка та вивести результат.";
var rusult = stringName.Replace(" ", "");

Console.WriteLine("Вивід строки без редагування:");
Console.WriteLine();

Console.Write($"{stringName}");
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Вивід строки без пробілів:");
Console.WriteLine();

Console.Write($"{rusult}");