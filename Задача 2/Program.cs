// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


//int AckermannFunction(int n, int m)
int Ack(int n, int m)
{
   int res = 0;
if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
        {
        res = Ack(n - 1, 1);
        return  res;
        }
    else
        {
        res = Ack(n - 1, Ack(n, m - 1));
        return  res;
        }
}


int m = 2, n = 2; 
int res = Ack(n, m);
Console.WriteLine(res);