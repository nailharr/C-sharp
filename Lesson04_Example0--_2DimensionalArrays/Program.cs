﻿// string.Empty
// table[0,0]   table[0,1]  table[0,2]  table[0,3]  table[0,4]
// table[1,0]   table[1,1]  table[1,2]  table[1,3]  table[1,4]



// string[,] table = new string[2, 5];
// table[1, 2] = "word";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }


// Заполнение и вывод двумерного массива__________________________________

void PrintArray(int[,] matr)
{
    // for (int i = 0; i < 3; i++)
    for (int i = 0; i < matr.GetLength(0); i++) //Имя массива.GetLength(0) возвращает количество строк в вашем массиве.
    {
        // for (int j = 0; j < 4; j++)
        for (int j = 0; j < matr.GetLength(1); j++) //Имя массива.GetLength(1) — возвращает количество столбцов в вашем массиве.
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j]= new Random().Next(1,10);// [1;10)
        }
    }
}

int[,] matrix = new int[3, 4];

PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
// __________________________________________________________________________



