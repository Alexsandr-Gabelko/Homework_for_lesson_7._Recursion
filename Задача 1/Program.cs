/// Задача 1: Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.

void OutputNaturalNumbers(int first, int second)
{
   if (first > second) return;    
   else 
   {
    Console.Write(first + " "); 
    first += 1;
    OutputNaturalNumbers(first, second);
   } 
}

Console.WriteLine("Введите значение M: ");
int mValue = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите значение N: ");
int nValue = int.Parse(Console.ReadLine()!);
OutputNaturalNumbers(mValue, nValue);
