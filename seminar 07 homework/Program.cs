// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] Create2DArray(int m, int n)
{
    double[,] empty2DArray = new double[m, n];
    return empty2DArray;
}

double[,] Fill2DArray(double[,] newArray, int minValue, int maxValue)
{
    double[,] fill2DArray = new double[newArray.GetLength(0), newArray.GetLength(1)];
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            fill2DArray[i, j] = Math.Round(
                new Random().Next(minValue, maxValue + 1)
                + new Random().NextDouble()
                , 2);
        }
    }
    return fill2DArray;
}

void Show2DArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int rows = 5;
int cols = 6;
int minValue = -100;
int maxValue = 100;

Show2DArray(Fill2DArray(Create2DArray(rows, cols), minValue, maxValue));


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


