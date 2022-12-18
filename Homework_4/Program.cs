// Сформируйте трёхмерный массив из неповторяющихся
// двузначных чисел. Напишите программу, которая будет построчно выводить
// массив, добавляя индексы каждого элемента.

int[,,] array = GetArrayMatrix(4, 4, 4, 10, 100);
PrintArray(array);
Console.WriteLine();



int[,,] GetArrayMatrix(int rows, int columns, int depth, int minValue, int maxValue)
{
    int[,,] result = new int[rows, columns, depth];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                result[i, j, k] = minValue;
                minValue++;
            }
            
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
            Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine();
    }
}