void ChangeNumbers(int m, int n)
{
if(n == m)
    {
        Console.Write(m);
        return;
    }
    Console.Write(m  + " ");
    ChangeNumbers(m + 1, n);
}

int n = 16;
int m = 5;
ChangeNumbers(m, n);