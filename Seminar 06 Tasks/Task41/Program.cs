// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] GetArray(string text)
{
    Console.Write(text);
    var numbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    return numbers;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

int CountPositiveNumbers(int[] arr)
{
    int result = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            result += 1;
        }
    }
    return result;
}

int[] arrNumbers = GetArray("Введите несколько чисел через пробел: ");
PrintArray(arrNumbers);
System.Console.WriteLine("Количество положительных чисел в массиве = " + CountPositiveNumbers(arrNumbers));
