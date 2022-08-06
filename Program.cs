// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("***Задача 34:***");
int[] arr = new int[10];
int count = 0;
Random rnd = new Random();
Console.WriteLine("Исходный массив");
for (int i = 0; i < 10; i++)
{
    arr[i] = rnd.Next(100, 1000);
    Console.Write($" {arr[i]}");
}
Console.WriteLine();
foreach (int element in arr)
{
    if (element % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine($"Количество четных элементов: {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("***Задача 36:***");
int[] array = new int[10];
int sum = 0;
Random rand = new Random();
Console.WriteLine("Исходный массив");
for (int i = 0; i < 10; i++)
{
    array[i] = rand.Next(-99, 100);
    Console.Write($" {array[i]}");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    if (i % 2 != 0)
        sum = sum + array[i];
   }
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


Console.WriteLine("***Задача 38:***");
double[] array2 = new double[10];
Random random = new Random();
for (int i = 0; i < array2.Length; i++)
array2[i] = random.NextDouble()+random.Next(-99, 100);
double max = 0, min = 100;
Console.WriteLine("Исходный массив");
for (int i = 0; i < 10; i++)
{
       Console.Write($" {array2[i]}");
}
Console.WriteLine();
for (int i = 0; i < 10; i++)
{
    if (array2[i]> max)
      max = array2 [i];
    if (array2[i] < min)
    min = array2 [i];
   }
Console.WriteLine ($"Максимальный элемент: {max}");
Console.WriteLine ($"Минимальный элемент: {min}");
Console.WriteLine ($"Разница между максимальным и минимальным элементом: {max-min}");

   