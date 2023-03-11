// —————————————————— Урок 5. Функции и одномерные массивы ——————————————————

// _______________________________________________________________________________________________________
//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray(int size, int start, int end)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(start, end + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void FindSum(int[] array)
// {
//     int sumPos = 0;
//     int sumNeg = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] >= 0) sumPos += array[i];
//         else sumNeg += array[i];
//     }
//     Console.WriteLine($"Sum of positive digits is: {sumPos}");
//     Console.WriteLine($"Sum of negative digits is: {sumNeg}");
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// FindSum(myArray);

// _______________________________________________________________________________________________________
//Задача 2. Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

// int[] CreateRandomArray(int size, int start, int end)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(start, end + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ChangeElementsOfArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] *= (-1);
//     }
//     return array;
// }

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());


// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// ShowArray(myArray);
// myArray = ChangeElementsOfArray(myArray);
// ShowArray(myArray);

// _______________________________________________________________________________________________________
//Задача 3.Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.



// _______________________________________________________________________________________________________

//Задача 4.****Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
