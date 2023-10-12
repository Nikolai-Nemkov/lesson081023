// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 48");
Console.WriteLine();

// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n. (это сумма индексов)
// т.е каждый элемент равен сумме индексов.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3  
// 1 2 3 4    
// 2 3 4 5    

int[,] MatrixSumIndexes(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = i + j;
        }
    }

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($" {matrix[i, j], 6}");
        }
        Console.WriteLine("    ]");
    }
}

int[,] array2d = MatrixSumIndexes(8, 8);
PrintMatrix(array2d);

Console.WriteLine();



 