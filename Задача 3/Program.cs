// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void PrintFromEnd(int[] numbers, int index)
{ 
    if (index == 0)
        {
        System.Console.Write(numbers[index]);
        return ;
        }
    System.Console.Write(numbers[index] + " ");
    index --; 
    PrintFromEnd(numbers, index);
    return;
}

Random rnd = new Random();
int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
    {
    array[i] = rnd.Next(0, 101);
    }
Console.Write(string.Join(" ", array)); 
Console.Write("  =>  ");
PrintFromEnd(array, array.Length - 1);