// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// START // ————————————————————————————————————————————————————————————————————————

// int BiggestNumber(int number)
// {
//     int firstDigit = number / 10;
//     int secondDigit = number % 10;

//     if (firstDigit > secondDigit) return firstDigit;
//     else return secondDigit;
// }

// int number = new Random().Next(10, 100);
// Console.WriteLine(number);
// Console.WriteLine(BiggestNumber(number));

// ————————————————————————————————————————————————————————————————————————// END //





// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// START // ————————————————————————————————————————————————————————————————————————

// int Delete2Digit(int num3Digit)
// {
//     int hundred = num3Digit / 100;      // Finding the hundred digits (782 / 100 = 7.82 == 7)
//     int unit = num3Digit % 10;          // Finding the remainder of division (782 / 10 = 78.2 => 2 [% == 2])
//     return hundred * 10 + unit;         // Calculate and return result (7*10 + 2 == 70 + 2)
// }

// int number3Digit = new Random().Next(100, 1000);    // Generating the number of 3 digits

// Console.WriteLine(number3Digit);
// Console.WriteLine(Delete2Digit(number3Digit));

// ————————————————————————————————————————————————————————————————————————// END //




//3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14  ->  нет
//46  ->  нет
//161 ->  да

// START // ———————————————————————————————————————————————————————————————————————— 1

// bool MultipleAB(int number)
// {
//     return number % 7 == 0 && number % 23 == 0;
// }

// Console.WriteLine("Input a number: ");
// int inputnum = Convert.ToInt32(Console.ReadLine());
// if (MultipleAB(inputnum) == true)
// {
//     Console.WriteLine($"{inputnum} is a multiple 7 and 23. Well done!");
// }
// else
//     Console.WriteLine($"{inputnum} not a multiple 7 and 23. :( Try again");

// Console.WriteLine(MultipleAB(inputnum));

// START // ———————————————————————————————————————————————————————————————————————— 2


// bool MultipleAB(int number, int numA, int numB)
// {
//     return number % numA == 0 && number % numB == 0;
// }

// Console.WriteLine("Input a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a number A: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input a number B: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int num = number;
// if (MultipleAB(number, numA, numB) == true)
// {
//     Console.WriteLine($"{number} is a multiple {numA} and {numB}. 🥳 Well done! 🥳");
// }
// else
//     Console.WriteLine($"{number} 💩 not a multiple {numA} and {numB}. 🤪 Don't worry and try again.");

// // Console.WriteLine(MultipleAB(number, numA, numB));

// ————————————————————————————————————————————————————————————————————————// END //



//4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// START // ————————————————————————————————————————————————————————————————————————

// bool QuadNumbers(int number1, int number2)
// {
//     return number1 == Math.Pow(number2, 2) || number2 == Math.Pow(number1, 2);
// }
// Console.WriteLine("Enter first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(QuadNumbers(num1, num2));

// ————————————————————————————————————————————————————————————————————————// END //





// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// START // ————————————————————————————————————————————————————————————————————————

// void Multiple2Num(int num1, int num2)
// {
//     int res = num2 % num1;
//     if (num2 == 0) Console.WriteLine("Enter a number more than zero, please!");
//     else if (res == 0)
//     {
//         Console.WriteLine($"Congratulations! Number {num2} is multiple {num1}.");
//     }
//     else if (num1 < num2)
//         Console.WriteLine($"Number {num2} is NOT multiple {num1}. Remainder -> {res}");
//         else Console.WriteLine("First number must be less than the second and not equal to zero");
// }


// Console.WriteLine("Enter first number: ");
// int number01 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int number02 = Convert.ToInt32(Console.ReadLine());

// Multiple2Num(number01, number02);

// ————————————————————————————————————————————————————————————————————————// END











// ЭТАЛОННОЕ РЕШЕНИЕ
// --------------------------------------------------------------------------------------------------------------------


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// 
// 
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int number = Prompt("Enter a 3 digit number > ");
// if (number < 100 || number > 1000)
// {
//     Console.WriteLine("You enter NOT a 3 digit nuumber");
//     return;
// }
// Console.WriteLine($"Entered number is `{number}`");
// int secondRank = number / 10 % 10;
// Console.WriteLine($"Second digit is `{secondRank}`");




// / Задача 2: Напишите программу, которая выводит претью цифру заданного // числа или сообщает, что третьей цифры нет.
// 1/ 645 -> 5
// 1) 78 -> третьей цифры нет
// 32679 -> 6
// 
// 
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// int GetThirdRank(int number)
// {
//     while (number > 999)
//     {
//         number /= 10;
//     }
//     return number % 10;
// }
// bool ValidateNumber(int number)
// {
//     if (number < 100)
//     {
//         Console.WriteLine("Третьей цифры нет");
//         return false;
//     }
//     return true;
// }
// int number = Prompt("Введите число > ");
// if (ValidateNumber(number))
// {
//     Console.WriteLine(GetThirdRank(number));
// }




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
// 
// 
// int Prompt(string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;
// }
// bool IsWeekend(int weekDay)
// {
//     if (weekDay>5)
//     {
//         return true;
//     }
//     return false;
// }
// bool ValidateWeekday(int number)
// {
//     if (number>0 && number <=7)
//     {
//         return true;
//     }
//     Console.WriteLine("It's a not day of week");
//     return false;
// }
// int weekDay = Prompt("Enter a number weekday > ");
// if (ValidateWeekday(weekDay))
// {
//     if (IsWeekend(weekDay))
//     {
//         Console.WriteLine("HOLIDAY!");
//     }
//     else
//     {
//         Console.WriteLine("GO WORK!");
//     }
// }