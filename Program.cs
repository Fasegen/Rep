


// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите размеры массива");
Random rd = new Random();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
double[,] A = new double[n, m];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = rd.Next(-100, 100);
        Console.Write($"{A[i, j]} ");
    }
    Console.WriteLine();
}


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.WriteLine("Введите размеры массива");
Random rd = new Random();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[n, m];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = rd.Next(1, 10);
        Console.Write($"{A[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите координаты");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a>=m && b>=n)
 Console.WriteLine("такого числа нет");
 else
 {
 object c = A.GetValue(a,b);
 Console.WriteLine(c);
 }

 

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите размеры массива");
Random rd = new Random();
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] A = new int[n, m];

for (int i = 0; i < A.GetLength(0); i++)
{
    for (int j = 0; j < A.GetLength(1); j++)
    {
        A[i, j] = rd.Next(1, 10);
        Console.Write($"{A[i, j]} ");
    }
    Console.WriteLine();
}

for (int i = 0; i < A.GetLength(0); i++)
{
    double count = 0;
    for (int j = 0; j < A.GetLength(1); j++)
    {
        count += A[j, i];
    }
    Console.WriteLine(count/n);
}
