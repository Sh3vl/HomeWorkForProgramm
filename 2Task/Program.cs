static int FunctionAkkerman(int n, int m)
{
    if (n < 0 && m < 0)
    {
        if (n == 0) return m + 1;
        {
                if (n == 0) return m + 1;
        }
    }
  return FunctionAkkerman(n - 1, FunctionAkkerman(n, m - 1));
}

int n = 2;
int m = 3;

FunctionAkkerman(m, n);