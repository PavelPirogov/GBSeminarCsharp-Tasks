// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] GetArray(int m, int n)
{
    int[,] arr = new int[m, n];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j + 1;
        }
    }

    int s = arr[arr.GetLength(0) - 1, arr.GetLength(1) - 1] + 1;
    for (int i = arr.GetLength(0) - 1; i > 0; i--)
    {
        for (int j = arr.GetLength(1) - 2; j > -1; j--)
        {
            arr[i, j] = s;
            s++;
        }
    }

    for (int i = 1; i < arr.GetLength(0) - 1; i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            arr[i, j] = i + j + arr[arr.GetLength(0) - 1, arr.GetLength(1) - 4] + 1;
        }
    }

    s = arr[arr.GetLength(0) - 2, arr.GetLength(1) - 2] + 1;
    int k;
    for (int j = arr.GetLength(1) - 3; j > -1; j--)
    {
        k = arr.GetLength(0) - 2;
        arr[k, j] = s;
        s -= 5;
    }
    return arr;
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

int[,] matrix = GetArray(4, 4);
PrintArray(matrix);


// Решение после семинара №9
int[,] SpiralMatrix(int n)
{
    var spiral = new int[n, n];
    int item = 0; int i = 0; int j = 0;
    while (item < n * n)
    {
        spiral[i, j] = item + 1;
        if (i <= j + 1 && i + j < spiral.GetLength(1) - 1) j++;
        else if (j > i && i + j >= spiral.GetLength(0) - 1) i++;
        else if (i >= j && i + j > spiral.GetLength(1) - 1) j--;
        else i--;
        item++;
    }
    return spiral;
}

System.Console.WriteLine();
PrintArray(SpiralMatrix(8));


