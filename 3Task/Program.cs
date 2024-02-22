void ReversArray(int[] array, int first = 0)
{
    if(first != array.Length) {
        ReversArray(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}

int[] array  = {1, 5, 0, 10, 34 };
ReversArray(array);
