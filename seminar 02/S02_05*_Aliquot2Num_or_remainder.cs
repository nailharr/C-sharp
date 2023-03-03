// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно


int Krat(int num1, int num2)
{
    int res = num1 % num2;
    return res;
}

int randomnum1 = new Random().Next(1, 1000);
int randomnum2 = new Random().Next(1, 1000);

//randomnum1 = 16;
//randomnum2 = 4;
//Console.WriteLine(randomnum1);
//Console.WriteLine(randomnum2);
//Console.WriteLine(Krat(randomnum1, randomnum2));

if (Krat(randomnum1, randomnum2) == 0) Console.WriteLine($"Кратно");
else Console.WriteLine($"не кратно, {Krat(randomnum1, randomnum2)}");




void Krat(int num1, int num2)
{
    int res = num1 % num2;
    if (res == 0) Console.WriteLine($"Кратно");
    else Console.WriteLine($"не кратно, {res}");
}

int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());

Krat(num1, num2);