// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 49");
Console.WriteLine();

// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// kвадраты.    новый массив
// 1 4 7 2     1  4  49  2
// 5 9 2 3     5  9  2   3
// 8 4 2 4    64  4  4   4

int[,] GreateMatrixRndInt(int rows, int columns, int min, int max)
{ //    0      1
    int[,] matrix = new int[rows, columns];
    Random num = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = num.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("   ]");
    }
}

/*      Вариант работы с нечтныыми индексами

void ReplaceCurrentElementsOnSguare(int[,] matrix)   // перевод: Заменить текущие элементы на квадрат.
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];    // умножается само на себя
            }
        }
    }
}
*/
void ReplaceCurrentElementsOnSguareVer2(int[,] matrix) // перевод: Заменить текущие элементы на квадрат Версия2.
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) //  i += 2     -отсчет начинается сразу с четного индекса
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2) //   j += 2    -отсчет начинается сразу с четного индекса
        {
            {
                matrix[i, j] *= matrix[i, j]; // умножается само на себя
            }
        }
    }
}

int[,] array2d = GreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

//ReplaceCurrentElementsOnSguare(array2d);
//PrintMatrix(array2d);

//Console.WriteLine();
//Console.WriteLine("-------------------");
//Console.WriteLine();

ReplaceCurrentElementsOnSguareVer2(array2d);
PrintMatrix(array2d);

Console.WriteLine();






/*

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{ //    0      1
    int[,] matrix = new int[rows, columns];
    Random num = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = num.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[  ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.Write("   ]");
    }
}

void ReplaceCurrentElementsOnSguare(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }
    }
}

void ReplaceCurrentElementsOnSguareVer2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2)
    {
        for (int j = 0; j < matrix.GetLength(1); j +=2)
        {
            {
                matrix[i,j] *= matrix[i,j];
            }
        }
    }
}

int[,] array2d = CreateMatrixRndInt(5, 5, -10, 10);
PrintMatrix(array2d);

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

ReplaceCurrentElementsOnSguare(array2d);
PrintMatrix(array2d);

Console.WriteLine();
Console.WriteLine("-------------------");
Console.WriteLine();

ReplaceCurrentElementsOnSguareVer2(array2d);
PrintMatrix(array2d);

Console.WriteLine();
*/
