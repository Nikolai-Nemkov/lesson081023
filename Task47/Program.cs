// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 47");
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

 