// Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.

int[,] array1 = GetArrayMatrix(4, 4, 1, 5);
PrintArray(array1);
Console.WriteLine();
int[,] array2 = GetArrayMatrix(4, 4, 1, 5);
PrintArray(array2);
Console.WriteLine();
PrintArray(ProductMatrix(array1, array2, 4, 4));


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

int[,] ProductMatrix(int[,] array1, int[,] array2, int rows, int columns)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int k = 0; k < array2.GetLength(0); k++)
            {
                result[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return result;
}