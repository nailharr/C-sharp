// Урок 3. Базовые алгоритмы. Продолжение
//
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// START // ————————————————————————————————————————————————————————————————————————

// void Palindrome5d(int num)
// {
//     int fraction1 = num / 1000;
//     int fraction2 = num % 100;
//     if (num > 9999 && num < 100000)
//     {
//         if ((num % 10 == num / 10000) && (fraction1 % 10 == fraction2 / 10))
//         {
//             Console.WriteLine($"Number {num} is a Palindrome");
//         }
//         else
//         {
//             Console.WriteLine($"Number {num} is NOT a Palindrome");
//         }
//     }
//     else
//     {
//         Console.WriteLine("Enter a valid 5 digit number!");
//     }
// }

// Console.Write("Enter a 5 digit number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Palindrome5d(number);

// ————————————————————————————————————————————————————————————————————————// END //




// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// START // ———————————————————————————————————————————————————————————————————————— 1 variant

// Console.WriteLine("Enter the coordinates of the first point x, y, z in order:");
// double xA = Convert.ToDouble(Console.ReadLine());
// double yA = Convert.ToDouble(Console.ReadLine());
// double zA = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine("Enter the coordinates of the second point x, y, z in order:");
// double xB = Convert.ToDouble(Console.ReadLine());
// double yB = Convert.ToDouble(Console.ReadLine());
// double zB = Convert.ToDouble(Console.ReadLine());

// double distance = Math.Round(Math.Sqrt(Math.Pow(xA - xB, 2) + Math.Pow(yA - yB, 2) + Math.Pow(zA - zB, 2)),4);

// Console.WriteLine($"Distance between two points: {distance} units.");

// START // ———————————————————————————————————————————————————————————————————————— 2 variant

// double CoordinateInput(string axis, string point)
// {
//     Console.Write($"Enter the {axis} coordinate of point {point}: ");
//     return Convert.ToDouble(Console.ReadLine());
// }

// double Dist2Points3D(double x1, double y1, double z1,double x2, double y2, double z2)
// {
//     double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) +
//                                 Math.Pow(y1 - y2, 2) +
//                                 Math.Pow(z1 - z2, 2));
//     return distance;
// }

// double xA = CoordinateInput("x", "A");
// double yA = CoordinateInput("y", "A");
// double zA = CoordinateInput("z", "A");
// double xB = CoordinateInput("x", "B");
// double yB = CoordinateInput("y", "B");
// double zB = CoordinateInput("z", "B");

// double length = Math.Round(Dist2Points3D(xA, yA, zA, xB, yB, zB), 4);

// Console.WriteLine($"Distance between two points: {length} units.");


// ————————————————————————————————————————————————————————————————————————// END //




// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// START // ————————————————————————————————————————————————————————————————————————

// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void CubeNumbers(int num)
// {
//     for (int i = 1; i <= num; i++)
//     {
//         Console.Write(Math.Pow(i, 3) + ", ");
//     }

// }
// Console.Write($"{number} -> ");
// CubeNumbers(number);
// ————————————————————————————————————————————————————————————————————————// END //