// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача");
Console.WriteLine();


// Задача 46 Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами
// m = 3, n = 4.
//    Пример

//  i     0  1  2  3

//  0     1  4  8  19
//  1     5 -2 33  -2
//  2    77  3  8   1


 // CОЗДАНИЕ МАТРИЦЫ ДВУ МЕРНОГО МАССИВА заполненного 0 - ми

int[,] RandomNumbers(int rows, int columns, int min, int max)
{                       //    0      1
    int[,] matrix = new int [rows, columns];
    Random num = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = num.Next(min, max + 1);
        }
    }
    return matrix;

     // ЗАПОЛНЕНИЕ МАТРИЦЫ ЧИСЛАМИ.
}
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

int[,] array2d = RandomNumbers(3, 4, -100, 100);   // array2d - названье матрицы в объеме 3,4, -100, 100.
PrintNambers(array2d);    // выводим на экран матрицу
Console.WriteLine();




          //      Вариант  №2

 // Задача 46 Задайте двумерный массив размером m x n,
// заполненный случайными целыми числами
// m = 3, n = 4.         
/*

Console.WriteLine("введите n - (количество строк)");
int linesVol = Convert.ToInt32(Console.ReadLine());   // linesVol - линии Объем, можно Vоlume - объем.

Console.WriteLine("введите m - (количество столбцов) ");
int columnsVol = Convert.ToInt32(Console.ReadLine());    // columnsVol - столбцы Объем

//     RandomMatrix -  Создание матрицы заполненной нулями 

void RandomMatrix(int[,] array)             // вместо int double и будут дробные числа
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToInt32(new Random().Next(-50, 50));  // Добавляем  / 10;  и вместо ToInt32 ставим ToDouble
        }
    }
}
 
               // PrintArray  - ЗАПОЛНЕНИЕ МАТРИЦЫ ЧИСЛАМИ.

void PrintArray(int[,] array)    // вместо int double и будут дробные числа
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t"); //  можно и так: Console.Write($"{array[i, j], 5}");
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}
int[,] numbers = new int[linesVol, columnsVol];     // 2 раза вместо int double и будут дробные числа
RandomMatrix(numbers);

PrintArray(numbers);
Console.WriteLine();
*/

