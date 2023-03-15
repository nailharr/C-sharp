﻿// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Request(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Enter number {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

int CountOfPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int sizeArray = Request("Enter count of numbers: ");
int[] array = FillArray(sizeArray);
int result = CountOfPositiveNumbers(array);

Console.WriteLine($"You have entered {result} digits greather than zero.");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void CrossPoint(int k1, int b1, int k2, int b2)
// {
//     double x = Convert.ToDouble(b2 - b1) / (k1 - k2);
//     double y = k1 * x + b1;
//     System.Console.WriteLine($"({x}; {y})");
// }

// int InputData(string input)
// {
//     Console.Write($"Enter value {input}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int k1Value = InputData("k1");
// int b1Value = InputData("b1");
// int k2Value = InputData("k2");
// int b2Value = InputData("b2");

// Console.Write($"Coordinates of cross point: ");
// CrossPoint(k1Value, b1Value, k2Value, b2Value);