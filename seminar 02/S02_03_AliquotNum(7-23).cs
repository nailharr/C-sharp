//3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14  ->  нет
//46  ->  нет
//161 ->  да

bool KratNum(int num)
{
    return num % 7 == 0 && num % 23 == 0;
}

int randomnum = new Random().Next(1, 1000);
randomnum = 161;
Console.WriteLine(randomnum);
Console.WriteLine(KratNum(randomnum));