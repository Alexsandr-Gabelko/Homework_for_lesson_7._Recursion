// Задача 2: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 


int AckermannFunction(int m, int n)
{
  int res = 0;
  if (m == 0)
    return n + 1;
  else
      if (n == 0)
  {
    res = AckermannFunction(m - 1, 1);
    return res;
  }
  else
  {
    res = AckermannFunction(m - 1, AckermannFunction(m, n - 1));
    return res;
  }
}

void PrintResult(int m, int n, int res)
{
  Console.WriteLine($"A({m},{n}) = {res}");
  return;
}

int res;
int m = 2, n = 0;
PrintResult(m, n, res = AckermannFunction(m, n));
m = 0; n = 3;
PrintResult(m, n, res = AckermannFunction(m, n));
m = 2; n = 3;
PrintResult(m, n, res = AckermannFunction(m, n));


