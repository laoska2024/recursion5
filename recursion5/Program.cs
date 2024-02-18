// Домашнее задание по теме "Рекурсия"

// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.
// start = 13 (M); end = 25 (N);

// void ShowNumbers(int start, int end)
// {
//     if (start == end)
//     {
//         Console.Write(start);
//         return;
//     }
//     Console.Write(start + " ");
//     ShowNumbers(start + 1, end);
// }
// Console.Write("Введите число M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N: ");
// int N = Convert.ToInt32(Console.ReadLine());
// ShowNumbers(M, N);


// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// int Akkerman(int m, int n)
// {
//     if (m == 0)
//     {
//         return n + 1;
//     }
//     else
//     {
//         if (n == 0)
//         {
//             return Akkerman(m - 1, 1);
//         }
//         else
//         {
//             return Akkerman(m - 1, Akkerman(m, n - 1));
//         }
//     }
// }

// Console.Write("Введите число m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(Akkerman(m, n));


// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// int[] firstArray = { 1, 2, 5, 0, 10, 34 };
// int j = firstArray.Length - 1;
// PrintReverseArray(firstArray);

// void PrintReverseArray(int[] array)
// {
//     if (j == 0)
//     {
//         Console.Write(array[j]);
//         return;
//     }
//     Console.Write(array[j] + " ");
//     j = j - 1;
//     PrintReverseArray(array);
// }


