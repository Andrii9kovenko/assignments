// Ви розробляєте програму для генерації текстового звіту.
//  Ваше завдання - створити текстовий звіт, який містить заголовок, дату та список подій.
//   Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків. 
//   Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder .


using System.Text;
Console.Clear();

StringBuilder report = new StringBuilder();
report.AppendLine("Перелік подій:");
report.AppendLine();

while (true)
{
    Console.WriteLine("Для формавання звіту необхідно додати подію (для завершення натисніть Enter):");
    string inputAction = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(inputAction))
    {
        break;
    }

    report.AppendLine("\t - " + inputAction);
}
report.AppendLine();
report.AppendLine("Дата формування звіту: " + DateTime.Now.ToString("yyyy.MM.dd"));

Console.WriteLine("\t \t \t \t  Звіт");
Console.WriteLine(report.ToString());
