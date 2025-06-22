/*
Напишіть програму, яка перевіряє пароль користувача.
 Пароль вважається прийнятним, якщо він містить принаймні 8 символів, 
 з яких принаймні один символ - це цифра, а також принаймні один символ - 
 це спеціальний символ (наприклад, !, @, # тощо).
*/

using System.ComponentModel;

Console.Write("Введіть пароль: ");
string inputPassword = Console.ReadLine();

bool checkUpper = false;
bool checkLower = false;
bool checkDigit = false;
bool checkSpecial = false;
bool isValid = true;

if (inputPassword.Length < 8)
{
    Console.WriteLine("Мінімальна довжина паролю повинна складати не менше 8 символів.");
    return;
}

for (int i = 0; i < inputPassword.Length; i++)
{
    char c = inputPassword[i];
    if (char.IsUpper(c))
        checkUpper = true;
    else if (char.IsLower(c))
        checkLower = true;
    else if (char.IsDigit(c))
        checkDigit = true;
    else if (!char.IsLetterOrDigit(c))
        checkSpecial = true;
}
if (!checkUpper)
{
    Console.WriteLine("Пароль має містити велику літеру");
    isValid = false;
}

if (!checkLower)
{
    Console.WriteLine("Пароль має містити маленьку літеру");
    isValid = false;
}
if (!checkDigit)
{
    Console.WriteLine("Пароль має містити цифу літеру");
    isValid = false;
}

if (!checkSpecial)
{
    Console.WriteLine("Пароль має містити спец.символ: !, @, # тощо");
    isValid = false;
}
if (isValid)
{
    Console.WriteLine("Пароль відповідає вимогам");
}
