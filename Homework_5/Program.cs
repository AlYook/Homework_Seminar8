//Заполните спирально массив 4 на 4

int[,] array = GetHelixMatrix(4);
PrintArray(array);




int[,] GetHelixMatrix(int size)
{
    int n = 0;
    int[,] helix = new int[size, size];
    int j0 = 0;
    int jn = size - 1;
    int k0 = 0;
    int kn = size - 1;
    while (n < size * size)
    {
        for (int j = j0; j <= jn; j++)
        {
            helix[k0, j] = ++n;
        }

        k0++;

        for (int k = k0; k <= kn; k++)
        {
            helix[k, jn] = ++n;
        }

        jn--;

        for (int j = jn; j >= j0; j--)
        {
            helix[kn, j] = ++n;
        }

        kn--;

        for (int k = kn; k >= k0; k--)
        {
            helix[k, j0] = ++n;
        }

        j0++;
    }
    return helix;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}