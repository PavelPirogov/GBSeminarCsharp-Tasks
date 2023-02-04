// Задача 19: 

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Ведите пятизначное число ");
string numText = Console.ReadLine();
int num = Convert.ToInt32(numText);

if (num < 100000 && num > 9999)
{
    if (numText[0] == numText[4] && numText[1] == numText[3])
    {
        Console.WriteLine("Это число палиндром");
    }
    else
    {
        Console.WriteLine("Это не палиндром");
    }
}
else
{
    Console.WriteLine("Это не пятизначное число");
}




// void inputArray(int[] N)
// {
//     for (int i = 0; i < N.Length; i++)
//     {
//         Console.Write("Введите цифру " + (i + 1) + "   ");
//         N[i] = Convert.ToInt32(Console.ReadLine());
//     }
// }

// int[] array = new int[5];
// inputArray(array);

// if (array[0] == array[4] && array[1] == array[3])
// {
//     Console.WriteLine("Это число палиндром");
// }
// else
// {
//     Console.WriteLine("Это НЕ палиндром");
// }