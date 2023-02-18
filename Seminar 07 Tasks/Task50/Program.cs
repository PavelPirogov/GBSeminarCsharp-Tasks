// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

double[,] GetArray(int m, int n)
{
    double[,] arr = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = Math.Round(rand.Next(-9, 9) + rand.NextDouble(), 1);
        }
    }
    return arr;
}

void PrintArray(double[,] arr)
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

void FindElement(double[,] arr, int m, int n)
{
    if (arr.GetLength(0) >= m && arr.GetLength(1) >= n)
    {

        Console.WriteLine($"Значение элемента в матрице по заданным координатам = {arr[m - 1, n - 1]}");

    }
    else
    {
        Console.WriteLine("Индекс элемента вне матрицы");
    }
}
int rows = new Random().Next(3, 6);
int cols = new Random().Next(3, 11);
int findrow = ReadInt("Введите номер строки: ");
int findcol = ReadInt("Введите номер столбца: ");
double[,] matrix = GetArray(rows, cols);  // Для проверки GetArray(5, 10);
System.Console.WriteLine();
PrintArray(matrix);
System.Console.WriteLine();
FindElement(matrix, findrow, findcol);
