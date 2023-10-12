// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 46");
Console.WriteLine();

// Задача 47  Задайте двумерный массив размером m х n,
// заполненный случайными вещественными числами
// m = 3, n = 4.
// пример:
// 0,5   7.0  -2,0  -0,2
// 1,0  -3,3   8,0  -0,9
// 8,0   7,8   7,1   9,

// СОЗДАНИЕ МАТРИЦЫ ЗАПОЛНЕННАЯ 0 ми и подготовленная для дробных чисел.
 
Console.WriteLine("введите n - (количество строк)");
int rowsVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите m - (количество столбцов) ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

void RandomMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-50, 50)) / 10;
        }
    }
}

   // ЗАПОЛНЕНИЕ МАТРИЦЫ ЧИСЛАМИ.

void PrintMatrix(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 7}");        // можно и так  Console.Write(array[i, j] + "\t"); 
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}
double[,] numbers = new double[rowsVol, columnsVol];
RandomMatrix(numbers);

PrintMatrix(numbers);
Console.WriteLine();

 

























/*
// Задача 46 Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами п = 6, m = 8.


// CОЗДАНИЕ МАТРИЦЫ ДВУ МЕРНОГО МАССИВА заполненного 0 - ми

int[,] RandomNumbers(int rows, int columns, int min, int max)
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

// ЗАПОЛНЕНИЕ МАТРИЦЫ ЧИСЛАМИ

void PrintNambers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 5}");
        }
        Console.WriteLine("  ]");
    }
}

int[,] array2d = RandomNumbers(6, 8, -100, 100);
PrintNambers(array2d);
Console.WriteLine();


*/
