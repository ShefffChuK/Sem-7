// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] numbers = new int[3, 4];
GetArray(numbers);
PrintArray(numbers);



for (int j = 0; j < numbers.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        sum += numbers[i, j];
    }
    Console.Write($"{ sum / numbers.GetLength(0)} ");
}
Console.ReadLine();



// ----------------Заполнение массива-------------------------
void GetArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(1, 10);
    }
}
}
// -----------------Вывод массива-----------------
void PrintArray(int[,] array)
{
for(int i = 0; i < array.GetLength(0); i++)
{
for(int j = 0; j < array.GetLength(1); j++)
{
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}