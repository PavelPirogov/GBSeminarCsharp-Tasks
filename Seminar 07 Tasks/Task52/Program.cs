// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetArray(int m, int n)
{
    int[,] arr = new int[m, n];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rand.Next(0, 10);
        }
    }
    return arr;
}

void AverageCols(int[,] arr)
{
    System.Console.Write("Среднее арифметическое каждого столбца: ");
    double sum = 0;
    double aver = 0;
    int j = 0;

    while (j < arr.GetLength(1))
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        aver = Math.Round(sum / arr.GetLength(0), 1);   // Почему работает с длинной строки, а не столбца?
        if (j < arr.GetLength(1) - 1)
        {
            System.Console.Write(aver + "; ");
        }
        else
        {
            System.Console.Write(aver + ".");
        }
        j++;
        sum = 0;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");
int[,] matrix = GetArray(rows, cols);
System.Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
AverageCols(matrix);
