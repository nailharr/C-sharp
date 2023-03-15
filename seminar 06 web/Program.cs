// ______________________________________________________________________________________
//Задача 1. Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]

// int[] CreateRandomArray(int size, int start, int end)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < newArray.Length; i++)
//     {
//         newArray[i] = new Random().Next(start, end + 1);
//     }
//     return newArray;
// }

// void ShowArray(int[] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         System.Console.Write(arrayToShow[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// int[] ReverseArray(int[] arrayReverse)
// {
//     for (int i = 0; i < arrayReverse.Length / 2; i++)
//     {
//         int tempBox = arrayReverse[i];
//         arrayReverse[i] = arrayReverse[arrayReverse.Length - i - 1];
//         arrayReverse[arrayReverse.Length - i - 1] = tempBox;
//     }
//     return arrayReverse;
// }

// int sizeOfArray = new Random().Next(5, 11);
// int startOfArray = new Random().Next(0, 11);
// int endOfArray = new Random().Next(50, 101);
// int[] randomArray = CreateRandomArray(sizeOfArray, startOfArray, endOfArray);

// ShowArray(randomArray);
// ReverseArray(randomArray);
// ShowArray(randomArray);

// ______________________________________________________________________________________
//Задача 2.Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//самое важное знать правило, какждая сторона должна быть меньше(строго) суммы двух других сторон

// bool CheckTriangle(int aSide, int bSide, int cSide)
// {
//     if (aSide + bSide > cSide && aSide + cSide > bSide && bSide + cSide > aSide)
//     {
//         return true;
//     }
//     else
//     {
//         return false;
//     }
// }

// int DataRequest(string inputData)
// {
//     System.Console.Write($"Input {inputData}: ");
//     return Convert.ToInt32(Console.ReadLine());
// }

// int aSide = DataRequest("length of first side of triangle");
// int bSide = DataRequest("length of second side of triangle");
// int cSide = DataRequest("length of third side of triangle");

// if (CheckTriangle(aSide, bSide, cSide) == true)
// {
//     Console.WriteLine($"Figure is triangle!");
// }
// else
// {
//     Console.WriteLine($"Figure is not triangle!");
// }

// ______________________________________________________________________________________
//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: a и b.
//числа фибоначчи последовательность чисел в которой первые 2 числа это 0 и 1, а последубщие это сумма двух передыдущих
// [0, 1, 1, 2, 3, 5, 8, 13, ... ]

// ________v1

// Console.Write($"Enter count of Fibonacci numbers: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = 0, b = 1, c;

// Console.Write($"{a} {b} ");
// for (int i = 2; i < n; i++)
// {
//     c = a + b;
//     Console.Write(c + " ");
//     a = b;
//     b = c;
// }
// Console.WriteLine();

// ________v2

// int[] FibonacciFirstN(int countNum)
// {
//     const int a = 0;
//     const int b = 1;
//     int[] fibonacciArray = new int[countNum];
//     fibonacciArray[0] = a;
//     fibonacciArray[1] = b;
//     for (int i = 2; i < countNum; i++)
//     {
//         fibonacciArray[i] = fibonacciArray[i - 1] + fibonacciArray[i - 2];
//     }
//     return fibonacciArray;
// }

// void ShowArray(int[] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         System.Console.Write(arrayToShow[i] + " ");
//     }
//     System.Console.WriteLine();
// }

// System.Console.WriteLine($"Enter required count of Fibonacci numbers: ");
// int countOfFibonacciNumbers = Convert.ToInt32(Console.ReadLine());
// ShowArray(FibonacciFirstN(countOfFibonacciNumbers));

// ______________________________________________________________________________________
//Задача 4. ****Напишите программу, которая будет преобразовывать десятичное число в двоичное.
//45 -> 101101
//3 -> 11
//2 -> 10

// int decimalNumber, quotient;
// string binaryNumber = String.Empty;

// Console.Write("Enter a decimal number: ");
// decimalNumber = Convert.ToInt32(Console.ReadLine());

// while (decimalNumber >= 1)
// {
//     quotient = decimalNumber / 2;
//     binaryNumber = decimalNumber % 2 + binaryNumber;
//     decimalNumber = quotient;
// }

// System.Console.WriteLine($"Binary number is: {binaryNumber}");