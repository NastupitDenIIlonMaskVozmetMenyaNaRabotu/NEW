// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
using System;
Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[m, n];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

void FillArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите размеры массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i,j] = new Random().Next (10, 100);
        Console.Write (array[i,j] +"\t  ");
    }
    Console.WriteLine();
}

Console.WriteLine ("Введите строку элемента: ");
int row = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите столбец элемента: ");
int column = Convert.ToInt32 (Console.ReadLine());
if (row > m && column > n) 
{
    Console.WriteLine ("Такого элемента нет в массиве");
    
}
else
{
    Console.WriteLine ("Элемент массива существует: "+ array[row,column]);
}
//  и еще вариант:
// using System;
// Console.WriteLine("Введите размеры массива");
// int m = Convert.ToInt32(Console.ReadLine());
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] array = new int [m,n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i,j] = new Random().Next (10, 100);
//         Console.Write (array[i,j] +"\t  ");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine ("Введитt элемент: ");
// int row = Convert.ToInt32 (Console.ReadLine());
// int a = 999;
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if(array[i,j] == row)
//         {
//             a = array[i,j];
//             break;
//         }
//     }
// }
// if(a != 999)
// {
//     Console.WriteLine("такое число есть");
// }else{
//     Console.WriteLine("такое число не существует");
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine ("Введите количество строк: ");
int m = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine ("Введите количество столбцов: ");
int n = Convert.ToInt32 (Console.ReadLine());
int[,] array  = new int [m,n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array [i,j] = new Random().Next (0, 10);
        Console.Write(array [i,j]+" ");
    }
    Console.WriteLine();
}

for (int j = 0; j < n; j++)
{
    Console.WriteLine("Среднее арифметическое каждого столбца: " + Average(j));
}

double Average(int column)
{
    double average = 0;
    double x = 0;
    for (int i = 0; i < m; i++)
{
    average += array [i, column];
}
x = average / m;
return x;
}
