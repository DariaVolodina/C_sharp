// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
double[,] CreateArray (int rows, int columns, int minValue, int maxValue)
{
    double [,] newArray= new double [rows, columns];

    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
            newArray[i,j] = new Random().Next(minValue, maxValue +  1) + new Random().NextDouble();
    }
    return newArray;
}


void Show2dArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " "); 

        Console.WriteLine();
    }
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

double[,] array = CreateArray(m, n, min, max);
Show2dArray(array);
*/

//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

int[,] Create2dArray (int rows, int columns, int minValue, int maxValue)
{
    int [,] newArray = new int [rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void Show2dArray (int[,] array)  
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " "); 

        Console.WriteLine();
    }
    Console.WriteLine();
}
  
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] array1 = Create2dArray (m, n, min, max);
Show2dArray (array1);

Console.Write("Введите номер строки искомого элемента: ");
int r = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер колонки искомого элемента: ");
int c  = Convert.ToInt32(Console.ReadLine());

if( (r < m) && (c < n) ) 
    Console.Write($"Значение элемента {r} строки {c} колонки: {array1[r, c]}");

else Console.Write("Tакого элемента в массиве нет");


//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
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

int [] Average (int[,] array)
{
    int [] AverageArray = new int [array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        int average = 0, sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];

        average = sum / array.GetLength(0);
    
        AverageArray[j] = average;  
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

int [] array1 = Average(array2d);
ShowArray(array1);
*/