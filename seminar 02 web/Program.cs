// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// START // ————————————————————————————————————————————————————————————————————————

// int BiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;

//     if (dec > ed) return dec;
//     else return ed;
// }

// int randomnum = new Random().Next(10, 100); //or 99+1
// int result = BiggestDigit(randomnum);
// Console.WriteLine($"Biggest digit of {randomnum} -> {result}");

// ————————————————————————————————————————————————————————————————————————// END //




// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// START // ————————————————————————————————————————————————————————————————————————

// int DeletDigit(int num)
// {
//     int sot = num / 100;
//     int ed = num % 10;
//     return sot * 10 + ed;
// }

// int rndmnmbr = new Random().Next(100, 1000); //or 99+1

// Console.WriteLine(rndmnmbr);
// Console.WriteLine(DeletDigit(rndmnmbr));

// ————————————————————————————————————————————————————————————————————————// END //


//3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
//14  ->  нет
//46  ->  нет
//161 ->  да

// START // ————————————————————————————————————————————————————————————————————————

// bool KratNum(int num)
// {
//     return num % 7 == 0 && num % 23 == 0;
// }

// int randomnumber = new Random().Next(1, 1000);
// randomnumber = 161;
// Console.WriteLine(randomnumber);
// Console.WriteLine(KratNum(randomnumber));

// ————————————————————————————————————————————————————————————————————————// END //





//4. Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// START // ————————————————————————————————————————————————————————————————————————

// bool Quad(int num1, int num2)
// {
//     return num1 * num1 == num2 | num2 * num2 == num1;
// }

// int randomnum1 = new Random().Next(1, 1000);
// int randomnum2 = new Random().Next(1, 1000);

// // randomnum1 = 25;
// // randomnum2 = 5;
// Console.WriteLine(randomnum1);
// Console.WriteLine(randomnum2);
// Console.WriteLine(Quad(randomnum1, randomnum2));

// ————————————————————————————————————————————————————————————————————————// END //





// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
// Если второе число не кратно числу первому, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// START // ———————————————————————————————————————————————————————————————————————— 1

// int Krat(int num1, int num2)
// {
//     int res = num1 % num2;
//     return res;
// }   
   
// int randomnum1 = new Random().Next(1, 1000);
// int randomnum2 = new Random().Next(1, 1000);

// //randomnum1 = 16;
// //randomnum2 = 4;
// Console.WriteLine(randomnum1);
// Console.WriteLine(randomnum2);
// //Console.WriteLine(Krat(randomnum1, randomnum2));

// if (Krat(randomnum1, randomnum2) == 0) Console.WriteLine($"Кратно");
// else Console.WriteLine($"не кратно, {Krat(randomnum1, randomnum2)}");


// START // ———————————————————————————————————————————————————————————————————————— 2


// void Krat(int num1, int num2)
// {
//     int res = num1 % num2;
//     if (res == 0) Console.WriteLine($"Кратно");
//     else Console.WriteLine($"не кратно, {res}");
// }   

// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// Krat(num1, num2);

// ————————————————————————————————————————————————————————————————————————// END //
