// Урок 6. Одномерные массивы. Продолжение

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3







// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void CrossPoint(int k1, int b1, int k2, int b2)
{
    double x = Convert.ToDouble(b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    System.Console.WriteLine($"({x}; {y})");
}

int InputData(string input)
{
    Console.Write($"Enter value {input}: ");
    return Convert.ToInt32(Console.ReadLine());
}

int k1Value = InputData("k1");
int b1Value = InputData("b1");
int k2Value = InputData("k2");
int b2Value = InputData("b2");

Console.Write($"Coordinates of cross point: ");
CrossPoint(k1Value, b1Value, k2Value, b2Value);