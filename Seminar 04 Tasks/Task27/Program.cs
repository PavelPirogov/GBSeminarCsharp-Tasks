// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

string? getNum(string text)
{
    System.Console.Write(text);
    return Console.ReadLine();
}

int getSumElements(string number)
{
    int result = 0;
    int temp;
    for (int i = 0; i < number.Length; i++)
    {
        temp = Convert.ToInt32(Convert.ToString(number[i]));
        result = result + temp;
    }
    return result;
}

int getSumElements2(int number)
{
    int result = 0;
    while (number > 10)
    {
        result = result + number % 10;
        number = number / 10;
    }
    result = result + number;
    return result;
}

string? num = getNum("Введите число: ");

if (int.TryParse(num, out int numnum))
{
    int sum = getSumElements(num!);
    System.Console.WriteLine("Сумма цифр числа " + num + " = " + sum);
    int sum2 = getSumElements2(numnum);
    System.Console.WriteLine("Сумма цифр числа " + num + " = " + sum2);
}
else
{
    System.Console.WriteLine("Введено не число");
}

// С отрицательными числами не работает