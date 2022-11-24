// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum (int num)
{
    int sum = 0;
    for (int i = num; i > 1; i /= 10)
    {
        sum = sum + i % 10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int result = Sum(number);
Console.WriteLine("Сумма цифр в введенном числе равна: " + result);
