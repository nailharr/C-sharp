// Напишите программу, которая выводит случайное число из отрезка [10, 99]
//  и показывает наибольшую цифру числа.

// 78 -> 8
// 12-> 2
// 85 -> 8


int BiggestDigit(int num)
{
    int ed = num % 10;
    int dec = num / 10;

    if (dec > ed) return dec;
    else return ed;
}

int randomnum = new Random().Next(10, 100); //or 99+1
int result = BiggestDigit(randomnum);
Console.WriteLine($"Biggest digit of {randomnum} -> {result}");