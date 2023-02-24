// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GetMatrix(int m, int n)
{
    Random rand = new Random();
    if (m == n) n = n + 1;
    var matr = new int[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = rand.Next(0, 10);
        }
    }
    return matr;
}

void GetNumberMinRows(int[,] matr)
{
    int count;
    int min = 0;
    int minRow = 0;
    for (int k = 0; k < matr.GetLength(1); k++)
    {
        min += matr[0, k];
    }
    // System.Console.Write(min + " ");
    for (int i = 1; i < matr.GetLength(0); i++)
    {
        count = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            count += matr[i, j];
        }
        if (count < min)
        {
            min = count;
            minRow = i;
        }
        // System.Console.Write(count + " ");
    }
    System.Console.WriteLine();
    System.Console.WriteLine($"У строки № {minRow + 1} наименьшая сумма элементов");
}

void PrintMatrix(int[,] arr)
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

int rows = GetNumber("Введите количество строк: ");
int cols = GetNumber("Введите количество столб: ");
int[,] matrix = GetMatrix(rows, cols);
PrintMatrix(matrix);
System.Console.WriteLine();
GetNumberMinRows(matrix);


