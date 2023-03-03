// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

// START // ————————————————————————————————————————————————————————————————————————

int BiggestNumber(int number)
{
    int firstDigit = number % 10;
    int secondDigit = number / 10;

    if (firstDigit > secondDigit) return firstDigit;
    else return secondDigit;
}

int number = new Random().Next(10, 100);
Console.WriteLine(number);
Console.WriteLine(BiggestNumber(number));

// ————————————————————————————————————————————————————————————————————————// END //