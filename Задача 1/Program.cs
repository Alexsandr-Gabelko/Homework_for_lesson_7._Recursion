/// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void OutputNaturalNumbers(int first, int second, string result)
{
    if (first == second)
    {
        Console.Write($"\"{result += first}\"");
        return;
    }
    else
    {
        result += first + ", ";
        first += 1;
        OutputNaturalNumbers(first, second, result);
    }
}

string result = String.Empty;
Console.WriteLine("Введите значение M: ");
int mValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N: ");
int nValue = int.Parse(Console.ReadLine()!);
if (mValue > nValue)
{
    int temp = mValue;
    mValue = nValue;
    nValue = temp;
}
OutputNaturalNumbers(mValue, nValue, result);
