// See https://aka.ms/new-console-template for more information
Console.WriteLine();
Console.WriteLine("Задача 52");
Console.WriteLine();

// Задача 52: Задайте двумерный массив из целых чисел.
// Найдите средне арифметическое элементов в каждом столбце.

Console.WriteLine("введите количество строк");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите количество столбцов");
int b = Convert.ToInt32(Console.ReadLine());

int[,] numbers = new int[a, b];
RandomNumbers(numbers);

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 6}");
        }
        Console.Write("  ]");
        Console.WriteLine("");
    }
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double meaning = 0; // meaning - значение
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            meaning = (meaning + numbers[i, j]);
        }
        meaning = meaning / a;
        Console.Write(meaning + "; ");
    }
}
PrintArray(numbers);
Console.WriteLine();
