// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[] GetArray(int m, int n, int b)
{
start:
    Random rand = new Random();
    int size = m * n * b;
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(10, 100);
    }

    // System.Console.WriteLine();
    int k = 0;
    while (k < size)
    {
        for (int i = 1 + k; i < size; i++)
        {
            if (arr[k] == arr[i])
            {
                // System.Console.WriteLine("Повтор значения " + arr[k]);
                goto start;
            }
        }
        k++;
    }
    return arr;
}

int[,,] GetCub(int[] arr, int m, int n, int b)
{
    int l = 0;
    var matr = new int[m, n, b];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                matr[i, j, k] = arr[l];
                l++;
            }
        }
    }
    return matr;
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                System.Console.Write($"{matr[i, j, k]}({i},{j},{k})" + "   ");
            }
            System.Console.WriteLine();
        }
    }
}

int[] array = GetArray(2, 2, 2);
int[,,] matrix3D = GetCub(array, 2, 2, 2);
PrintArray(matrix3D);


