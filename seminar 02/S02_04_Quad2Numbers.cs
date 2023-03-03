//4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

bool Quad(int num1, int num2)
{
    return num1 * num1 == num2 | num2 * num2 == num1;
}

int randomnum1 = new Random().Next(1, 1000);
int randomnum2 = new Random().Next(1, 1000);

// randomnum1 = 25;
// randomnum2 = 5;
Console.WriteLine(randomnum1);
Console.WriteLine(randomnum2);
Console.WriteLine(Quad(randomnum1, randomnum2));