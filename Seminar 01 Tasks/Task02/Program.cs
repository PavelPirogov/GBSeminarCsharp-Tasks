// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.Write("Введите первое число: ");
int numberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int numberB = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите третье число: ");
int numberC = Convert.ToInt32(System.Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{
    System.Console.WriteLine("max = " + numberA);
}
else if (numberB > numberC)
{
    System.Console.WriteLine("max = " + numberB);
}
else
{
    System.Console.WriteLine("max = " + numberC);
}