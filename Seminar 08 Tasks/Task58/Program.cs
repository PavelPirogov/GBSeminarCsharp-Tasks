// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] matr1, int[,] matr2)
{
    var multiMatr = new int[matr1.GetLength(0), matr1.GetLength(1)];

    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr2.GetLength(1); j++)
        {
            for (int k = 0; k < matr2.GetLength(0); k++)
            {
                multiMatr[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return multiMatr;
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

void PrintArray2(int[,] arr, int[,] arr2)
{
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + "  ");
        }
        System.Console.Write("|\t ");
        for (int j = 0; j < arr2.GetLength(1); j++)
        {
            System.Console.Write(arr2[i, j] + "  ");
        }
        System.Console.WriteLine();
    }
}

int[,] matrix1 = GetArray(2, 2);
int[,] matrix2 = GetArray(2, 2);
int[,] multi = MatrixMultiplication(matrix1, matrix2);
PrintArray2(matrix1, matrix2);
System.Console.WriteLine("Результирующия матрица:");
PrintArray(multi);

// Решение взято из интернета





