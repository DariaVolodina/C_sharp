﻿// КАК НЕ НУЖНО / НУЖНО ПИСАТЬ КОД 
//ВАЖНО:
//1. имя переменных
//


//показать числа от -N до N

//int af = -5;
//int uf = 5;
//Console.WriteLine($"{af}..{uf}");


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] Create2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2dArray (int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " "); 
        Console.WriteLine();
    }
    Console.WriteLine();
}

int [] Average (int[,] array, int size)
{
    int [] AverageArray = new int [size];
    

    for(int j = 0; j < size; j++) 
    {
        int sum = 0;
        for(int i = 0; i < array.GetLength(1); i++)
            {
                sum += array[i, j]; 
                
            }
        AverageArray[j] = sum / array.GetLength(1);  
    }    
    return AverageArray;
}

void ShowArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine();
}


Console.Write("Input numver of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int [,] array2d = Create2dArray(m, n, min, max);
Show2dArray(array2d);

int [] array = Average(array2d, n);
ShowArray(array);
