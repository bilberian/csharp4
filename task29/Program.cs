// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите количество элементов для массива: ");
int count = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int[] array = new int[count];
for(int i = 0; i < count; i++)
{
    array[i] = new Random().Next(0,1000);
}
Console.Write("[" + string.Join(", ", array) + "]");

//Не получается вернуть весь массив, только по индексу:

// int FormArray ()
// {
//     int[] array = new int[8];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0,100);
//     }
//     return array[7];
// }

// Console.WriteLine(FormArray());