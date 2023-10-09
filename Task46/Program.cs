// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 46");
Console.WriteLine();

// Задача 46 Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами
// m = 3, n = 4.
//    Пример

//  i     0  1  2  3

//  0     1  4  8  19
//  1     5 -2 33  -2
//  2    77  3  8   1

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    //                        0       1
    int[,] matrix = new int[rows, columns];  // rows = 3? columns = 4
    Random rnd = new Random();

                            // GetLength - переводится как "получить длину"

    for (int j = 0; j < matrix.GetLength(1); j++)  // строка всегда начинается от 0 элемента
    {
        for (int i = 0; i < matrix.GetLength(0); i++)  // столбец от элемента 1
        {
            matrix[i, j] = rnd.Next(min, max + 1);
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
            Console.Write($"{matrix[i, j], 5}");  // 5 это отступ, ради форматирования, можно любую цифру.
        }
        Console.WriteLine("  ]");
    }
}

int[,] array2d = CreateMatrixRndInt(3, 4, -10,  10);
PrintMatrix(array2d);
Console.WriteLine();



/*   получение вещественных чисел.

Console.WriteLine("введите количество строк");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int columnsVol = Convert.ToInt32(Console.ReadLine());

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-50, 50)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 6}");
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}
double[,] numbers = new double[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
Console.WriteLine();

*/