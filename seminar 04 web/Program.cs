// Задача 1. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// int FindSum(int num)
// {
//     int sum = 0;
//     for (int current = 1; current <= num; current++)
//     {
//         sum += current; // sum = sum + current;
//     }
//     return sum;
// }

// Console.Write("Input A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum numbers 1 to a -> {FindSum(a)}");



// ________________________________________________________________
// Задача 4.Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] newArray = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         newArray[i] = new Random().Next(minValue, maxValue + 1);
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

// Console.Write("Input array size: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input minimal value of array element: ");
// int minValue = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input maximal value of array element: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// ShowArray(CreateRandomArray(size, minValue, maxValue));

// ________________________________________________________________
// Напишите программу, которая на вход принимает число и выдает количество цифр в этом числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// double CountNum(double num)
// {
//     double count = 1;
//     for (count = 1; num > 10; count++)
//     {
//        num = num / 10;
//     }
//     return count;
// }


// Console.WriteLine("Enter a number: ");
// double number = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(CountNum(number));

// ________________________________________________________________
// Напишите программу, которая на вход принимает число N и выдает произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120


// int Factorial(int num)
// {
//     int result = 1;
//     for (int current = 1; current <= num; current++)
//     {
//         result *= current;
//     }
//     return result;
// }

// Console.WriteLine("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Factorial(number));