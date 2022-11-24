// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16


int PowerRaised (int numA, int numB)
{
    int power = numA;
    for (int i = 1; i < numB; i++)
    {
        power = power * numA;
    }
    return power;
}

Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int result = PowerRaised(numberA, numberB);
Console.WriteLine("Результат: " + result);