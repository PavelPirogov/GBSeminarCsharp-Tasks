// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] GetArray(int size, int min, int max)
{
    var arr = new double[size];
    for (int i = 0; i < arr.Length; i++)
    {
        int randInt = new Random().Next(min, max + 1);      // Получаем целое число
        int randDouble = new Random().Next(1, 100);     // Получаем дробную часть
        string randString = Convert.ToString(randInt) + "," + Convert.ToString(randDouble);     // Соединяем целую и дробную части числа в строке
        double rand = Convert.ToDouble(randString);     // Переводим строку в дробное число
        arr[i] = rand;
    }
    return arr;
}

double GetTheDifferenceBetweenTheMinAndMaxElementArray(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
        }
        else if (min > arr[i])
        {
            min = arr[i];
        }
    }
    System.Console.WriteLine("Максимальное число в массиве: " + max);
    System.Console.WriteLine("Минимальное число в массиве: " + min);
    double result = Math.Round((max - min), 2);
    return result;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double[] array = GetArray(10, 0, 100);
PrintArray(array);
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива: " + GetTheDifferenceBetweenTheMinAndMaxElementArray(array));

