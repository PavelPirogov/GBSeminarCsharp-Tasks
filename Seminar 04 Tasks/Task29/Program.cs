// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] getArray(int sz, int min, int max)
{
    int[] arr = new int[sz];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.Write("[" + string.Join(", ", arr) + "]");
}

int size = new Random().Next(3, 9);
int[] array = getArray(size, 0, 101);
PrintArray(array);