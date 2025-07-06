/*
Написати програму, що знаходить другий найбільший елемент масиву.
*/
Console.Clear();


int[] arrayInt = {4, 35, 8, 7, 9, 12,12,25};

int maxValue = int.MinValue;
int secondMaxValue = int.MinValue;

for (int i = 0; i < arrayInt.Length; i++)
{
    if (arrayInt[i] > maxValue)
    {
        secondMaxValue = maxValue;
        maxValue = arrayInt[i];
    }
    else if (arrayInt[i] > secondMaxValue && arrayInt[i] != maxValue)
    {
        secondMaxValue = arrayInt[i];
    }
}


Console.WriteLine($"Другий найбільший елемент: {secondMaxValue}");


