// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец),
// проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том,
// что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

Console.Write("Введите индекс строки: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите индекс столбца: ");
int colums = int.Parse(Console.ReadLine()!);

int[,] numbers = new int[6, 8];
GetArray(numbers);
PrintArray(numbers);



if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) 
{
    Console.Write("Такой элемент есть: ");
    Console.WriteLine(numbers[rows, colums]);
}
else Console.WriteLine($"{rows} {colums} -> такого числа в массиве нет");


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