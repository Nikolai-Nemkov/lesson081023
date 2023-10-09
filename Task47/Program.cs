// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 47");
Console.WriteLine();

// Задача 47  Задайте двумерный массив размером m x n,
// заполненный случайными вещественными числами
// m = 3, n = 4.
// пример:
// 0,5   7.0  -2,0  -0,2
// 1,0  -3,3   8,0  -0,9
// 8,0   7,8   7,1   9,0

Console.WriteLine("введите n - (количество строк)");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите m - (количество столбцов) ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

void GreateRandomMatrix(double[,] array) // ArrayRandomNumbers
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
            Console.Write(array[i, j] + "\t"); //  можно и так: Console.Write($"{array[i, j], 5}");
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}
double[,] numbers = new double[linesVol, columnsVol];
GreateRandomMatrix(numbers);

PrintArray(numbers);
Console.WriteLine();




      // Введите свое решение ниже
    
Console.WriteLine("введите n - (количество строк)");
int linesVol = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите m - (количество столбцов) ");
int columnsVol = Convert.ToInt32(Console.ReadLine());

void GreateRandomMatrix(double[,] array) 
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
            Console.Write(array[i, j] + "\t"); 
        }
        Console.Write(" ]");
        Console.WriteLine("");
    }
}
double[,] numbers = new double[linesVol, columnsVol];
GreateRandomMatrix(numbers);

PrintArray(numbers);
Console.WriteLine();


/*

  public static void PrintArray(double[, ] matrix) {
      // Введите свое решение ниже

   
  }

  // Не удаляйте и не меняйте метод Main! 
  public static void Main(string[] args) 
{
    int m, n, minLimitRandom, maxLimitRandom;

    if (args.Length >= 4) {
      m = int.Parse(args[0]);
      n = int.Parse(args[1]);
      minLimitRandom = int.Parse(args[2]);
      maxLimitRandom = int.Parse(args[3]);

      double[,] array = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);

        // Выберем случайные индексы трех элементов матрицы array
        int row1 = new Random().Next(0, m);
        int col1 = new Random().Next(0, n);
        int row2 = new Random().Next(0, m);
        int col2 = new Random().Next(0, n);
        int row3 = new Random().Next(0, m);
        int col3 = new Random().Next(0, n);

        // Проверяем, являются ли выбранные элементы дробными числами
        bool isFractional1 = (array[row1, col1] % 1) != 0;
        bool isFractional2 = (array[row2, col2] % 1) != 0;
        bool isFractional3 = (array[row3, col3] % 1) != 0;

        // Если два из трех элементов не являются дробными числами, то бросаем исключение
        if ((isFractional1 && isFractional2) || (isFractional1 && isFractional3) || (isFractional2 && isFractional3))
        {
            Console.WriteLine("Все ок!");
        }
        else
        {
            throw new Exception("Выбранные элементы не содержат по крайней мере два дробных числа.");
        }
    } else {
      m = 3;
      n = 4;
      minLimitRandom = -10;
      maxLimitRandom = 10;
      
      double[, ] result = CreateRandomMatrix(m, n, minLimitRandom, maxLimitRandom);
      PrintArray(result);
    }
  }
} 

Проверяем решение

*/