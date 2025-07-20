Console.Clear();

const int maxTasks = 10;
string[] tasks = new string[maxTasks];
bool[] isDone = new bool[maxTasks];
int taskCount = 0;

bool isRunning = true;
while (isRunning)
{

    Console.WriteLine("Додаток справ:");
    Console.WriteLine("");
    Console.WriteLine("1. Додати справу");
    Console.WriteLine("2. Видалити справу");
    Console.WriteLine("3. Позначити справу як виконану");
    Console.WriteLine("4. Показати всі справи");
    Console.WriteLine("5. Вийти");
    Console.Write("Оберіть номер діі з переліку: ");

    string inputList = Console.ReadLine();

    if (inputList == "5")
    {
        Console.WriteLine("Роботу додатку завершено");
        isRunning = false;
    }

    else
    {
        switch (inputList)
        {
            case "1":
                AddTask();
                break;
            case "2":
                DeleteTask();
                break;
            case "3":
                CheckTaskAsDone();
                break;
            case "4":
                ShowTasks();
                break;
            default:
                Console.WriteLine("Невідома команда.");
                break;
        }
    }
}

void AddTask()
{
    if (taskCount >= maxTasks)
    {
        Console.WriteLine("Досягнуто максимуму задач.");
        return;
    }

    Console.Write("Введіть назву справи: ");
    string task = Console.ReadLine();

    if (!string.IsNullOrEmpty(task.Trim()))
    {
        tasks[taskCount] = task;
        isDone[taskCount] = false;
        taskCount++;
        Console.WriteLine("Справу додано.");
    }
    else
    {
        Console.WriteLine("Порожній ввід. Справу не додано.");
    }
}

void ShowTasks()
{
    if (taskCount == 0)
    {
        Console.WriteLine("Список справ порожній.");
        return;
    }

    Console.WriteLine("\nСписок справ:");
    for (int i = 0; i < taskCount; i++)
    {
        string status = isDone[i] ? "(+)" : "( )";
        Console.WriteLine($"{i + 1}. {status} {tasks[i]}");
    }
}

void CheckTaskAsDone()
{
    ShowTasks();
    Console.Write("Введіть номер справи, яку хочете позначити як виконану: ");
    if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= taskCount)
    {
        isDone[index - 1] = true;
        Console.WriteLine("Справу позначено як виконану.");
    }
    else
    {
        Console.WriteLine("Невірний номер.");
    }
}

void DeleteTask()
{
    ShowTasks();
    Console.Write("Введіть номер справи для видалення: ");
    if (int.TryParse(Console.ReadLine(), out int index) && index >= 1 && index <= taskCount)
    {
        for (int i = index - 1; i < taskCount - 1; i++)
        {
            tasks[i] = tasks[i + 1];
            isDone[i] = isDone[i + 1];
        }

        taskCount--;
        Console.WriteLine("Справу видалено.");
    }
    else
    {
        Console.WriteLine("Невірний номер.");
    }
}
