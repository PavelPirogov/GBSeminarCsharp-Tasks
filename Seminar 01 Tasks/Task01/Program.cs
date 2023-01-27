// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

System.Console.Write("Введите первое число: ");
int nmberA = Convert.ToInt32(System.Console.ReadLine());
System.Console.Write("Введите второе число: ");
int nmberB = Convert.ToInt32(System.Console.ReadLine());

if (nmberA > nmberB)
{
    System.Console.WriteLine("max = " + nmberA);
}
else if (nmberA < nmberB)
{
    System.Console.WriteLine("max = " + nmberB);
}
else
{
    System.Console.WriteLine("Числа равны");
}