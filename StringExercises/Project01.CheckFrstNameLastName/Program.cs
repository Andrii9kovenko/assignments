/*
Опис: Ви отримали рядок, який містить ім’я та прізвище користувача. 
Ваша мета - перевірити, чи починається прізвище на ту ж літеру, що й ім’я.
 Якщо так, вивести повідомлення “Прізвище починається 
на ту ж літеру, що і ім’я”, інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.
*/

Console.Clear();
Console.WriteLine("Введить ім’я:");
string firstName = Console.ReadLine();

Console.WriteLine();
Console.WriteLine("Введить прізвище:");
string lastName = Console.ReadLine();

Console.WriteLine();

var fullName = string.Concat(firstName, " ", lastName);

Console.WriteLine($"Користувач: {fullName}");

var inputFullname = fullName.Split(' ');

if (inputFullname.Length >= 2)
{
    char firstLetter = char.ToUpper(inputFullname[0][0]);
    char secondLetter = char.ToUpper(inputFullname[1][0]);
    if (firstLetter == secondLetter)
    {
        Console.WriteLine($"Прізвище починається на ту ж літеру: {secondLetter} , що і ім’я: {firstLetter} ");
    }
    else
    {
        Console.WriteLine($"Прізвище не починається на ту ж літеру: {secondLetter} , що і ім’я: {firstLetter} ");
    }
}




