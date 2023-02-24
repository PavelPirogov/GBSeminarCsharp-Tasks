// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            arr[i, j] = rand.Next(-50, 51);
        }
    }
    return arr;
}

void ChangeRowsToMinValue(int[,] arr)
{
    int max = 0;
    int colMax = 0;
    int count = 0;
    int temp;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        count = 0;
        while (count < arr.GetLength(1))
        {
            max = arr[i, count];
            colMax = count;
            for (int j = count; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] > max)
                {
                    max = arr[i, j];
                    colMax = j;
                }
            }
            temp = arr[i, colMax];
            arr[i, colMax] = arr[i, count];
            arr[i, count] = temp;
            count++;
        }
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
ChangeRowsToMinValue(matrix);
PrintArray(matrix);




