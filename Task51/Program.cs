// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 51");
Console.WriteLine();


/* Задача 51: Задайте двумерный массив. Найдите сумму
элементов, находящихся на главной диагонали (с индексами
(0,0); (1;1) 2;2  3;3    и т.д.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12   */
/*
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)  // Great - большой
{
    //                        0       1
    int[,] matrix = new int[rows, columns];  // rows = 3 - строка columns = 4 - столбец
    Random rnd = new Random();   // создаем объект Random

                            // GetLength - переводится как "получить длину"

    for (int i = 0; i < matrix.GetLength(0); i++)  // строка всегда начинается от 0 элемента. GetLength - получить длину массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++)  // столбец от элемента 1
        {
            matrix[i, j] = rnd.Next(min, max + 1);  //  matrix[i, j] - адрес ячейки присваеваем ей значение случайного числа.
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

int SumOnDiagonal(int[,]arr)   // метод возвращает значение и сумму по диаглнали и принимает на себя массив
{
    int size = arr.GetLength(0);  //  Определяем размер, сколько чисел нам нужно посчитать.
    if (arr.GetLength(0) < arr.GetLength(1)) size = arr.GetLength(0);  // определяем что меньше строк или столбцов т.е i иди j. Работа с наименьшим
    int sum = 0;
    for (int i = 0; i < size; i++)   // без второго цикла for, т.е оптимизированый вариант.
    {
        sum += arr[i,i];  // i = 0 одинаково для i т j
    }
    return sum;
}

int[,]rndMatrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(rndMatrix);
int sumOnDiagonal = SumOnDiagonal(rndMatrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на главной диагонале равна - {sumOnDiagonal}");
Console.WriteLine();
*/
//    ВТОРОЙ ВАРИАНТ НЕ ОПТИМИЗИРОВАННЫЙ с ДВУМЯ ЦИКЛАМИ (for)


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max) // Great - большой
{
    //                        0       1
    int[,] matrix = new int[rows, columns]; // rows = 3 - строка columns = 4 - столбец
    Random rnd = new Random(); // создаем объект Random

    // GetLength - переводится как "получить длину"

    for (int i = 0; i < matrix.GetLength(0); i++) // строка всегда начинается от 0 элемента. GetLength - получить длину массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбец от элемента 1
        {
            matrix[i, j] = rnd.Next(min, max + 1); //  matrix[i, j] - адрес ячейки присваеваем ей значение случайного числа.
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
            Console.Write($"{matrix[i, j], 5}"); // 5 это отступ, ради форматирования, можно любую цифру.
        }
        Console.WriteLine("  ]");
    }
}

int SumOnDiagonal(int[,] arr) // метод возвращает значение и сумму по диаглнали и принимает на себя массив
{
    //int size = arr.GetLength(0);  //  Определяем размер, сколько чисел нам нужно посчитать.
    //if (arr.GetLength(0) < arr.GetLength(1)) size = arr.GetLength(0);  // определяем что меньше строк или столбцов т.е i иди j. Работа с наименьшим
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++) // без второго цикла for, т.е оптимизированый вариант.
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j)   // если индексы равны т.е  0:8,  1:1, 2:2 и т. то отсчет идет по диагонали
            {
                sum += arr[i, j];    // соответсвенно считается числа диагонали. 
            }
        }
    }
    return sum;
}

int[,] rndMatrix = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(rndMatrix);
int sumOnDiagonal = SumOnDiagonal(rndMatrix);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на главной диагонале равна - {sumOnDiagonal}");
Console.WriteLine();
