// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 50");
Console.WriteLine();

// Задача 50: Напищите программу, которая на вход принимает позицию
// элемента в двумерном массиве и взвращает значение элемента или
// указания, что токлго элемента нет.
// например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4   1, 7 -> такого элемента в массиве нет/


Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[5, 6];

RandomNumbers(matrix);

if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение {n} строки и {m} столбца равно {matrix[n - 1, m - 1]}");
}

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5}");
        }
        Console.Write("  ]");
        Console.WriteLine("");
    }
}
PrintArray(matrix);

Console.WriteLine();







/*


Console.WriteLine("введите номер строки");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите номер столбца");
int m = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[5, 6];

RandomNumbers(numbers);

if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение {n} строки и {m} столбца равно {numbers[n - 1, m - 1]}");
}

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100); 
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5}");
        }
        Console.Write("  ]");
        Console.WriteLine("");
    }
}
PrintArray(numbers);

Console.WriteLine();



 /*
using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
        for (int i=0; i<matrix.GetLength(0); i++)
        {
            for (int j=0; j<matrix.GetLength(1);j++)
            {
                Console.Write($"{matrix[i,j]}"+"\t");
            }
            Console.WriteLine();
        }
    }

    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
        int[,] newMatrix = new int[n,m];
        int currentValue = 1;
        for (int i=0; i<n; i++)
        {
            for (int j=0; j<m; j++)
            {
                newMatrix[i,j] = currentValue;
                currentValue += k;
            }
        }
        return newMatrix;
    }

    public static int[] FindNumberByPosition (int [,] matrix, int rowPosition, int columnPosition)
    {  
        int [] number={0,-1};
        if ((rowPosition-1) > 0 && (rowPosition-1)<=matrix.GetLength(0) && (columnPosition-1) > 0 && (columnPosition-1)<=matrix.GetLength(1) )
        {
            number[1]=0;
            number[0]=matrix[rowPosition-1,columnPosition-1];
            return number;
        }
        return number;
    }

    public static void PrintCheckIfError (int[] results, int X, int Y)
    {
        if (results[1]==-1){Console.WriteLine("There is no such index")
        }
        else {Console.WriteLine($"The number in [{X}, {Y}] is {results[0]}");
        }
         
    }
     

     Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) 
    {
        int n, m, k, x, y;

        if (args.Length >= 5) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
           x = int.Parse(args[3]);
           y = int.Parse(args[4]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 3;
           m = 4;
           k = 2;
           x = 2;
           y = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintCheckIfError(FindNumberByPosition(result, x, y), x, y);
    }
}

 
*/

