// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeletDigit(int num)
{
    int sot = num / 100;
    int ed = num % 10;
    return sot * 10 + ed;
}

int randomnum = new Random().Next(100, 1000); //or 99+1

Console.WriteLine(randomnum);
Console.WriteLine(DeletDigit(randomnum));