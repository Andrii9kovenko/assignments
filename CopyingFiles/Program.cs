using System;
using System.IO;

Console.Clear();
Console.Write("Введіть шлях до файлу, який потрібно скопіювати: ");
string sourceFile = Console.ReadLine();

Console.Write("Введіть шлях до нового файлу: ");
string destinationFile = Console.ReadLine();

if (!File.Exists(sourceFile))
{
    Console.WriteLine("Файл не знайдено. Перевірте шлях.");
    return;
}

try
{
    string data = File.ReadAllText(sourceFile);
    File.WriteAllText(destinationFile, data);
    Console.WriteLine("Копіювання завершено успішно.");
}
catch (Exception e)
{
    Console.WriteLine("Сталася помилка при копіюванні:");
    Console.WriteLine(e.Message);
}
