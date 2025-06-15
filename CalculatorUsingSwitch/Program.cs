/*
реалізуйте функціонал обчислення значення двох чисел. 
Користувач вводить два цiлих числа та математичну дію: + - * або /
Залежно від введеної математичної дії вивести результат в консоль.
Необхідно використати конструкцію switch у цьому завданні.
*/

using System.Text;
Console.OutputEncoding = Encoding.UTF8; // Щоб відображалася українська мова.

Console.WriteLine();
Console.WriteLine("Обчислення значення двох цiлих чисел");

Console.WriteLine("");

//в умові зазначено два цілих числа , можна було використати зміну типу int
Console.WriteLine("Ввдедить перше число:");

decimal firstOperand = decimal.Parse(Console.ReadLine());

Console.WriteLine("Ввдедить дію яку необхідно виконати: + - * /");
// сhar [0] перевірка на введений символ
char operatorOfAction = Console.ReadLine()[0];

Console.WriteLine("Ввдедить друге число:");
decimal secondOperand = decimal.Parse(Console.ReadLine());


switch (operatorOfAction)
{
    case '+':
        Console.WriteLine($"Результат операціі: {firstOperand+secondOperand}");
        break;
    case '-':
        Console.WriteLine($"Результат операціі: {firstOperand-secondOperand}");
        break;    
    case '*':
        Console.WriteLine($" Результат операціі: {firstOperand*secondOperand}");
        break;
    case '/':
    //спробував тернарний опереатор , if напевно більш наглядний 
        string result = secondOperand != 0 ? $"Результат операціі: {firstOperand / secondOperand}" : $"Не коректна операція ділення на 0";
        Console.WriteLine(result);
    /*
                if (secondOperand == 0)
                {
                    Console.WriteLine($"Не коректна операція ділення на 0");
                }
                else
                {
                    Console.WriteLine($"Результат операціі: {firstOperand / secondOperand}");
                }

            */
        break;

    default:
        Console.WriteLine("необхідно ввести коректну операцію: + - * /");
        break;
} 