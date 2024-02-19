// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


int AckermannFunction(int n, int m)
{
   int res = 0;
if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
        {
        res = AckermannFunction(n - 1, 1);
        return  res;
        }
    else
        {
        res = AckermannFunction(n - 1, AckermannFunction(n, m - 1));
        return  res;
        }
}

void PrintResult (int m, int n, int res)
{
Console.WriteLine($"Значение функции Аккермана при m = {m} и n = {n} будет = {res}");
return;
}

int res;
int m = 2, n = 0; 
PrintResult (m, n, res = AckermannFunction(n, m));
m = 0; n = 3; 
PrintResult (m, n, res = AckermannFunction(n, m));
m = 2; n = 3; 
PrintResult (m, n, res = AckermannFunction(n, m));


