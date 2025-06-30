/*
розробити консольну гру "Хрестики Нолики" з використанням мови програмування C#. Створіть ігрове поле, 
де два гравці будуть робити ходи і ставити свої знаки ("X" або "O") в вільні клітинки. 
Гра повинна тривати до тих пір, поки один із гравців не виграє, заповнивши вертикалі, горизонталі а
бо діагоналі трьома своїми знаками підряд, або до настання нічиєї.

Вимоги:

Використовуйте мову програмування C# для реалізації гри.
Створіть ігрове поле розміром 3x3, де кожна клітинка позначена числом від 1 до 9.
Реалізуйте механізм чергових ходів двох гравців. Перший гравець розміщує "X", другий - "O".
Перевірте кожен хід на наявність виграшної комбінації або наступ нічиєї.
Після кожного ходу виведіть поточний стан ігрового поля на консоль.
*/

Console.Clear();
string field1 = "1";
string field2 = "2";
string field3 = "3";
string field4 = "4";
string field5 = "5";
string field6 = "6";
string field7 = "7";
string field8 = "8";
string field9 = "9";

string player1 = "X";
string player2 = "O";
string currentPlayer = player1;

int count = 0;
bool endGame = false;

while (endGame == false)
{
    Console.Clear();

    Console.WriteLine();
    Console.WriteLine(field1 + " | " + field2 + " | " + field3);
    Console.WriteLine("-- --- --");
    Console.WriteLine(field4 + " | " + field5 + " | " + field6);
    Console.WriteLine("-- --- --");
    Console.WriteLine(field7 + " | " + field8 + " | " + field9);
    Console.WriteLine();

    Console.WriteLine($"Гравець {currentPlayer} вибери клітинку:");
    string input = Console.ReadLine();

    bool correct = false;

    if (input == "1" && field1 != "X" && field1 != "O") { field1 = currentPlayer; correct = true; }
    if (input == "2" && field2 != "X" && field2 != "O") { field2 = currentPlayer; correct = true; }
    if (input == "3" && field3 != "X" && field3 != "O") { field3 = currentPlayer; correct = true; }
    if (input == "4" && field4 != "X" && field4 != "O") { field4 = currentPlayer; correct = true; }
    if (input == "5" && field5 != "X" && field5 != "O") { field5 = currentPlayer; correct = true; }
    if (input == "6" && field6 != "X" && field6 != "O") { field6 = currentPlayer; correct = true; }
    if (input == "7" && field7 != "X" && field7 != "O") { field7 = currentPlayer; correct = true; }
    if (input == "8" && field8 != "X" && field8 != "O") { field8 = currentPlayer; correct = true; }
    if (input == "9" && field9 != "X" && field9 != "O") { field9 = currentPlayer; correct = true; }

    if (correct == true)
    {
        count++;

        if ((field1 == currentPlayer && field2 == currentPlayer && field3 == currentPlayer) ||
            (field4 == currentPlayer && field5 == currentPlayer && field6 == currentPlayer) ||
            (field7 == currentPlayer && field8 == currentPlayer && field9 == currentPlayer) ||
            (field1 == currentPlayer && field4 == currentPlayer && field7 == currentPlayer) ||
            (field2 == currentPlayer && field5 == currentPlayer && field8 == currentPlayer) ||
            (field3 == currentPlayer && field6 == currentPlayer && field9 == currentPlayer) ||
            (field1 == currentPlayer && field5 == currentPlayer && field9 == currentPlayer) ||
            (field3 == currentPlayer && field5 == currentPlayer && field7 == currentPlayer))
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(field1 + " | " + field2 + " | " + field3);
            Console.WriteLine("-- --- --");
            Console.WriteLine(field4 + " | " + field5 + " | " + field6);
            Console.WriteLine("-- --- --");
            Console.WriteLine(field7 + " | " + field8 + " | " + field9);
            Console.WriteLine();
            Console.WriteLine($"Гравець  {currentPlayer} переміг!");
            endGame = true;
        }
        else if (count == 9)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(field1 + " | " + field2 + " | " + field3);
            Console.WriteLine("-- --- --");
            Console.WriteLine(field4 + " | " + field5 + " | " + field6);
            Console.WriteLine("-- --- --");
            Console.WriteLine(field7 + " | " + field8 + " | " + field9);
            Console.WriteLine();
            Console.WriteLine("Нічия!");
            endGame = true;
        }
        else
        {
            if (currentPlayer == player1) 
                currentPlayer = player2;
            else currentPlayer = player1;
        }
    }
    else
    {
        Console.WriteLine("Некоректне значення спробуй ще раз.");
        Console.ReadLine();
    }
}

Console.WriteLine("Гра завершена!");
Console.ReadLine();
