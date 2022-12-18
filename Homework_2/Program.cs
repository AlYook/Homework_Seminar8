// Задайте прямоугольный двумерный массив. Напишите
// программу, которая будет находить строку с наименьшей суммой элементов.


int[,] array = GetArrayMatrix(4, 5, 0, 10);
PrintArray(array);
Console.WriteLine();
MinSumRows(array);


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

void MinSumRows(int[,] inArray)
{
    int minRow = 0;
    int minSum = int.MaxValue;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum = sum + inArray[i,j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой {minSum} под индексом: {minRow}; ");
}
