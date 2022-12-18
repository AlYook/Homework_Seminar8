// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int[,] array1 = GetArrayMatrix(4, 5, 0, 10);
PrintArray(array1);
Console.WriteLine();
SumMartix(array1);
int[,] array2 = GetArrayMatrix(4, 5, 0, 10);
PrintArray(array2);
Console.WriteLine();
SumMartix(array2);
ProductMatrix(array1, array2);


int[,] GetArrayMatrix(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
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

int SumMartix(int[,] inArray)
{
    int sum = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i,j];
        }       
    }
    return sum;
}

void ProductMatrix(int[,] array1, int[,] array2)
{
    int prod = SumMartix(array1) * SumMartix(array2);
    Console.WriteLine($"произведение = {prod}");
}