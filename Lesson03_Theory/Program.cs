// Методы


// // Вид 1 ________________________________________________________________
// // Не принимают и не возвращают
// void Method1()
// {
//     Console.WriteLine("Подпись, например");
// }
// Method1();


// // Вид 2 ________________________________________________________________
// // Принимают и не возвращают
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// Method2("Текст сообщения");

// //С несколькими аргументами:

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while (i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }

// }
// Method21(msg: "Текст", count: 4); //Явное указание аргументов, можно писать не по порядку


// // Вид 3 ________________________________________________________________
// // Не принимают и что-либо возвращают

// int Method3()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year);


// // Вид 4 ________________________________________________________________
// // Принимают и возвращают

// string Method4(int count, string c)
// {
//     int i = 0;
//     string result = String.Empty; // string result = "";
//     while (i < count)
//     {
//         result = result + c;
//         i++;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty / ");
// Console.WriteLine(res);



// Цикл FOR ________________________________________________________________
// 

// string Method4(int count, string text)
// {
//     int i = 0;
//     string result = String.Empty; // string result = "";
//     for (int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "qwerty / ");
// Console.WriteLine(res);


// ПРИМЕР: ВЫВОД ТАБЛИЦЫ УМНОЖЕНИЯ________________________________________________________________

// for (int u = 2; u < 10; u++)
// {
//     for (int q = 2; q < 10; q++)
//     {
//         Console.WriteLine($"{u} * {q} = {u * q} ");
//     }
//     Console.WriteLine();
// }


// ПРИМЕР: ПРОГРАММЫ ОБРАБОТКИ ТЕКСТА________________________________________________________________
// 1 Заменить:
// пробелы дефисами
// к -> К
// о -> О

// string text = "— Я думаю, — сказал князь, улыбаясь, — что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля"
//             + "Вы так красноречивы. Вы дадите мене чаю?";

// // string s = "q w e r t y";
// //             0 1 2 3 4 5
// // s[3 // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result = result + newValue;
//         else result = result + text[i];
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();

// newText = Replace(newText, 'о', 'О');
// Console.WriteLine(newText);
// Console.WriteLine();




// ПРИМЕР: МАССИВЫ. УПОРЯДОЧИВАНИЕ ДАННЫХ ВНУТРИ МАССИВА________________________________________________________________
// АЛГОРИТМ СОРТИРОВКИ МЕТОДОМ ВЫБОРА (МИНИМАКСА)

int[] arr = { 2, 4, 7, 8, 5, 2, 2, 56, 74, 3 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) 
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);