// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// START // ———————————————————————————————————————————————————————————————————————— 1 variant

// int CutTails(int num)
// {
//     int result = num % 100;
//     int result2 = result / 10;
//     return result2;
// }

// Console.WriteLine("Enter the three-digit number");
// int number = Convert.ToInt32(Console.ReadLine());

// if ((number > -1000 && number < -99) || (number > 99 && number < 1000))
// {
//     Console.WriteLine(CutTails(number));
// }
// else Console.WriteLine("Invalid number");


// START // ———————————————————————————————————————————————————————————————————————— 2 variant

int CutTails(int num)
{
    int result = num % 100;
    int result2 = result / 10;

    if (num > -1000 && num < -99)
    {
        return result2 * (-1);
    }
    else if (num > 99 && num < 1000)
    {
        return result2;
    }
    else
    {
        return -1;
    }
}

Console.WriteLine("Enter the three-digit number");
int number = Convert.ToInt32(Console.ReadLine());
if (CutTails(number) > 0)
{
    Console.WriteLine(CutTails(number));
}
else
{
    Console.WriteLine("Invalid number");
}

// ————————————————————————————————————————————————————————————————————————// END




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// START // ————————————————————————————————————————————————————————————————————————



// ————————————————————————————————————————————————————————————————————————// END




// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// START // ————————————————————————————————————————————————————————————————————————



// ————————————————————————————————————————————————————————————————————————// END