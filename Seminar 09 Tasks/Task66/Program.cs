// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSum(int m, int n)
{
    if (m == n) return m;
    return m + GetSum(m + 1, n);
}

int M = GetNumber("Введите число от: ");
int N = GetNumber("Введите число до: ");
int temp;
if (M > N)
{
    temp = N;
    N = M;
    M = temp;
}
System.Console.WriteLine(GetSum(M, N));


