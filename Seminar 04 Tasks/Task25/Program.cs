// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNam(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int numA = GetNam("Введите число A: ");
int numB = Math.Abs(GetNam("Введите число B: "));

int Rank(int A, int B)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result *= numA;
    }
    return result;
}
// 8 в степени 12 выдаёт 0 ????
System.Console.WriteLine($"Число {numA} в степени {numB} = {Rank(numA, numB)}");

System.Console.WriteLine($"Число {numA} в степени {numB} = {Math.Pow(numA, numB)}");