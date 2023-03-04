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

bool MultipleAB(int number)
{
    return number % 7 == 0 && number % 23 == 0;
}

Console.WriteLine("Input a number: ");
int inputnum = Convert.ToInt32(Console.ReadLine());
if (MultipleAB(inputnum) == true)
{
    Console.WriteLine($"{inputnum} is a multiple 7 and 23. It's all right!");
}
else
    Console.WriteLine($"{inputnum} not a multiple 7 and 23. :((");

Console.WriteLine(MultipleAB(inputnum));

// START // ———————————————————————————————————————————————————————————————————————— 2



// ————————————————————————————————————————————————————————————————————————// END //
