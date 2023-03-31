// **Задача 51:** Задайте двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();
Console.Write($"Cумма элементов по диагонали -> {sum(array)}");
// изменения массива

int sum (int[,] array)

{
int summ = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
for (int j = 0; j < array.GetLength(1); j++)
{
if (i == j)
{
summ = summ + array[i,j];
}
}
}
return summ;
}

// ----------------Заполнение массива
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
int[,] res = new int[m,n];

for (int i = 0; i < m; i++)
{
for(int j = 0; j < n; j++){
res[i, j] = new Random().Next(minValue, maxValue + 1);
}
}
return res;
}
// -----------------Вывод массива-----------------
void PrintArray(int[,] array){
for(int i = 0; i < array.GetLength(0); i++){
for(int j = 0; j < array.GetLength(1); j++){
Console.Write($"{array[i,j]} ");
}
Console.WriteLine();
}
}