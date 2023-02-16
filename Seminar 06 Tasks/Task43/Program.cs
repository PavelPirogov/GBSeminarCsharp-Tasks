// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int GetCoff(string text)
{
    Console.Write(text);
    int coff = Convert.ToInt32(Console.ReadLine());
    return coff;
}

void CeckCrossLines(double coffB1, double coffK1, double coffB2, double coffK2)
{
    if (coffB1 == coffB2 && coffK1 == coffK2)
    {
        System.Console.WriteLine("Прямые совпадают");
    }
    else if (coffK1 == coffK2)
    {
        System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
        double x = Math.Round((coffB2 - coffB1) / (coffK1 - coffK2), 1);
        double y = Math.Round(coffK1 * x + coffB1, 1);
        System.Console.WriteLine($"Координаты точки пересечения прямых ({x}; {y})");
    }
}

int b1 = GetCoff("Прямая №1. Введите коэффициент b1: ");
int k1 = GetCoff("Прямая №1. Введите коэффициент k1: ");
int b2 = GetCoff("Прямая №2. Введите коэффициент b2: ");
int k2 = GetCoff("Прямая №2. Введите коэффициент k2: ");

CeckCrossLines(b1, k1, b2, k2);
