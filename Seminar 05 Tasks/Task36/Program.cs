// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int min, int max)
{
    var arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }
    return arr;
}

int GetTheSumOfTheNumbersStandingInOddPlacesInTheArray(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i + 1) % 2 == 0)
        {
            result += arr[i];
        }
    }
    return result;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int[] array = GetArray(4, -99, 100);
PrintArray(array);
System.Console.WriteLine("Сумма элементов стоящих на нечётных позициях: " + GetTheSumOfTheNumbersStandingInOddPlacesInTheArray(array));
